using System;
using System.Data;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;

namespace LES_17_I_M
{
    public partial class frmpais : Form
    {
        int nivel = 0;
        public frmpais()
        {
            InitializeComponent();
        }

        public frmpais(int getnivel) {
            InitializeComponent();
            this.nivel = getnivel;
        }

        private void frmpais_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
            if (e.KeyCode == Keys.Escape) {
                this.Close();
            }
        }

        private void Limpar() {
            txtpaicodi.Clear();
            txtpainome.Clear();
            btnincluir.Enabled = false;
            btngravar.Enabled = false;
            btnexcluir.Enabled = false;
            txtpaicodi.Focus();
        }

        private void frmpais_Load(object sender, EventArgs e) {

            DgvDados(); //mostra o dgv ao entrar no formulário
            Limpar();
        }

        private void DgvDados() { //traz os dados da tabela para o dgv, conforme o select feito
            Conexao.Active(true);
            try {
                //Trazer tabela do banco para DGV
                DataTable dt = new DataTable();
                FbDataAdapter da = new FbDataAdapter("SELECT * FROM PAIS", Conexao.FbCnn);
                da.Fill(dt);
                if (dt.Rows.Count > 0) {
                    dgvpais.DataSource = dt;
                }
            }
            finally {
                Conexao.Active(false);
            }
        }
        private void dgvpais_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            if (dgvpais.RowCount > 0 && dgvpais.SelectedRows.Count == 1) {//para alterar um registro do dgv
                                                                          /*SETAR PROP MULTISELECT PARA FALSE E SELECTIONMODE PARA FULLROWSELECT NO DGV*/
                int paiCodigo = Convert.ToInt32(dgvpais.SelectedRows[0].Cells[PAICODI.Name].Value);
                string sql = "SELECT * FROM PAIS "
                           + "WHERE PAICODI = " + paiCodigo;
                try {
                    Conexao.Active(true);
                    FbCommand cmd = new FbCommand(sql, Conexao.FbCnn);

                    FbDataReader dr = cmd.ExecuteReader();
                    if (dr.Read()) {
                        txtpaicodi.Text = dr["PAICODI"].ToString();
                        txtpainome.Text = dr["PAINOME"].ToString();
                        tbcpais.SelectedIndex = 1;
                        btnincluir.Enabled = false;
                        btngravar.Enabled = true;
                        if (nivel <= 5) {
                            btnexcluir.Enabled = true;
                        }
                        txtpainome.Focus();
                    }
                }
                finally {
                    Conexao.Active(false);
                }

            }
            else {
                MessageBox.Show("Nenhum registro selecionado!");
            }
        }
        private void tbclistagempais_Selected(object sender, TabControlEventArgs e) { //para caregar de novo do dgv caso escolha voltar para a TabPage de listagem
            if (tbcpais.SelectedIndex == 0)//tbclistagempais.SelectedTab == tbplistagem
            {
                DgvDados();
            }
        }

        private void btnvoltar_Click(object sender, EventArgs e) {

            this.Close();

        }

        private void txtpaicodi_Leave(object sender, EventArgs e)
        {
            Conexao.Active(true);
            if (txtpaicodi.Text != "")
            {
                string strConsulta = "SELECT PAICODI, PAINOME FROM PAIS WHERE PAICODI = " +
                txtpaicodi.Text;
                try
                {
                    FbCommand cmd = new FbCommand(strConsulta, Conexao.FbCnn);
                    FbDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        ConsultaPais(dr);
                        txtpainome.Focus();
                        btnincluir.Enabled = false;
                        btngravar.Enabled = true;
                        if (nivel <= 5) {
                            btnexcluir.Enabled = true;
                        }
                    }
                    else
                    {
                        if ((MessageBox.Show("Registro não encontrado \n deseja cadastra-lo?",
                        "Cadastro", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No))
                        {
                            Limpar();
                        }
                        else
                        {
                            txtpainome.Text = "";
                            btngravar.Enabled = false;
                            btnexcluir.Enabled = false;
                            btnincluir.Enabled = true;
                            txtpainome.Focus();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                Conexao.Active(false);
            }
            else {
                Limpar();
            }
        }

        private void ConsultaPais(FbDataReader dr)
        {
            txtpaicodi.Text = dr["PAICODI"].ToString();
            txtpainome.Text = dr["PAINOME"].ToString();
        }

        private void btnincluir_Click(object sender, EventArgs e) {
            string strIncluir = "INSERT INTO PAIS(PAICODI,PAINOME)"
            + " VALUES("
            + txtpaicodi.Text + ", '" + txtpainome.Text + "'"
            + " )";
            Conexao.Active(true);
            try {
                FbCommand cmd = new FbCommand(strIncluir, Conexao.FbCnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro incluído com sucesso !!!");
                DgvDados();
                Limpar();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            Conexao.Active(false);
        }

        private void btngravar_Click(object sender, EventArgs e) {
            string strAlterar = "UPDATE PAIS"
                  + " SET PAICODI = " + txtpaicodi.Text + ", "
                  + " PAINOME = '" + txtpainome.Text + "'"
                  + " WHERE PAICODI = " + txtpaicodi.Text;
            Conexao.Active(true);
            try {
                FbCommand cmd = new FbCommand(strAlterar, Conexao.FbCnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro gravado com sucesso !!!");
                Limpar();
                DgvDados();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            Conexao.Active(false);
        }

        private void btnexcluir_Click(object sender, EventArgs e) {
            string strDelete = "DELETE FROM PAIS WHERE PAICODI = " + txtpaicodi.Text;
            Conexao.Active(true);
            try {
                FbCommand cmd = new FbCommand(strDelete, Conexao.FbCnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro excluído com sucesso !!!");
                DgvDados();
                Limpar();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            Conexao.Active(false);
        }
    }//FIM CODE FORM
}
