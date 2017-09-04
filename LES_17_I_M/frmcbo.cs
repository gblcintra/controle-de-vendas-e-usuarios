using System;
using System.Data;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;

namespace LES_17_I_M
{
    public partial class frmcbo : Form{

        int nivel = 0;

        public frmcbo(){
            InitializeComponent();
        }

        public frmcbo(int getnivel) {
            InitializeComponent();
            this.nivel = getnivel;
        }

        private void Limpar() {
            txtcbocodi.Clear();
            txtcbonome.Clear();
            btnincluir.Enabled = false;
            btngravar.Enabled = false;
            btnexcluir.Enabled = false;
            txtcbocodi.Focus();
        }

        private void frmcbo_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
            if (e.KeyCode == Keys.Escape) {
                this.Close();
            }
        }

        private void frmcbo_Load(object sender, EventArgs e) {
            DgvDados();
            Limpar();
        }

        private void DgvDados() {
            Conexao.Active(true);
            try {
                DataTable dt = new DataTable();
                FbDataAdapter da = new FbDataAdapter("SELECT * FROM CBO", Conexao.FbCnn);
                da.Fill(dt);
                if (dt.Rows.Count > 0) {
                    dgvcbo.DataSource = dt;
                }
            }
            finally {
                Conexao.Active(false);
            }
        }

        private void dgvcbo_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            if (dgvcbo.RowCount > 0 && dgvcbo.SelectedRows.Count == 1) {//para alterar um registro do dgv
                                                                        /*SETAR PROP MULTISELECT PARA FALSE E SELECTIONMODE PARA FULLROWSELECT NO DGV*/
                int paiCodigo = Convert.ToInt32(dgvcbo.SelectedRows[0].Cells[CBOCODI.Name].Value);
                string sql = "SELECT * FROM CBO "
                           + "WHERE CBOCODI = " + paiCodigo;
                try {
                    Conexao.Active(true);
                    FbCommand cmd = new FbCommand(sql, Conexao.FbCnn);

                    FbDataReader dr = cmd.ExecuteReader();
                    if (dr.Read()) {
                        txtcbocodi.Text = dr["CBOCODI"].ToString();
                        txtcbonome.Text = dr["CBONOME"].ToString();
                        tbccbo.SelectedIndex = 1;
                        btnincluir.Enabled = false;
                        btngravar.Enabled = true;
                        if (nivel <= 4) {
                            btnexcluir.Enabled = true;
                        }
                        txtcbonome.Focus();
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

        private void Voltar_Click(object sender, EventArgs e){
            this.Close();
        }

        private void txtcbocodi_Leave(object sender, EventArgs e) {
            Conexao.Active(true);
            if (txtcbocodi.Text != "") {
                string strConsulta = "SELECT CBOCODI,CBONOME FROM CBO WHERE CBOCODI = " +
                txtcbocodi.Text;
                try {
                    FbCommand cmd = new FbCommand(strConsulta, Conexao.FbCnn);
                    FbDataReader dr = cmd.ExecuteReader();
                    if (dr.Read()) {
                        ConsultaCbo(dr);
                        txtcbonome.Focus();
                        btnincluir.Enabled = false;
                        btngravar.Enabled = true;
                        if (nivel <= 4) {
                            btnexcluir.Enabled = true;
                        }

                    }
                    else {
                        if ((MessageBox.Show("Registro não encontrado \n deseja cadastra-lo?",
                        "Cadastro", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)) {
                            Limpar();
                        }
                        else {
                            txtcbonome.Text = "";
                            btngravar.Enabled = false;
                            btnexcluir.Enabled = false;
                            btnincluir.Enabled = true;
                            txtcbonome.Focus();
                        }
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
                Conexao.Active(false);
            }
            else {
                Limpar();
            }
        }

        private void ConsultaCbo(FbDataReader dr) {
            txtcbocodi.Text = dr["CBOCODI"].ToString();
            txtcbonome.Text = dr["CBONOME"].ToString();
        }

        private void btnincluir_Click(object sender, EventArgs e) {
            string strIncluir = "INSERT INTO CBO(CBOCODI,CBONOME)"
            + " VALUES("
            + txtcbocodi.Text + ", '" + txtcbonome.Text + "')";
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
            string strAlterar = "UPDATE CBO"
                  + " SET CBOCODI = " + txtcbocodi.Text + ", "
                  + " CBONOME = '" + txtcbonome.Text + "' "
                  + " WHERE CBOCODI = " + txtcbocodi.Text;
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
            string strDelete = "DELETE FROM CBO WHERE CBOCODI = " + txtcbocodi.Text;
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
    }
}
