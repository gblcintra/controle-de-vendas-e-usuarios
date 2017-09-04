using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;

namespace LES_17_I_M
{
    public partial class frmbairro : Form {

        int nivel = 0;

        public frmbairro() {
            InitializeComponent();
        }

        public frmbairro(int getnivel) {
            InitializeComponent();
            this.nivel = getnivel;
        }

        private void frmbairro_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
            if(e.KeyCode == Keys.Escape) {
                this.Close();
            }
        }

        private void Limpar() {
            this.txtbaicodi.Clear();
            this.txtbainome.Clear();
            this.cbomuni.SelectedIndex = -1;
            this.txtbaicodi.Focus();
            this.btnincluir.Enabled = false;
            this.btngravar.Enabled = false;
            this.btnexcluir.Enabled = false;
        }

        private void frmbairro_Load(object sender, EventArgs e) {
            DgvDados();
            carregarMunicipios();
            Limpar();

        }

        private void DgvDados() {
            Conexao.Active(true);
            try {
                DataTable dt = new DataTable();
                FbDataAdapter da = new FbDataAdapter("SELECT BAICODI,BAINOME,MUNNOME FROM BAIRRO B left join MUNICIPIO M on B.MUNCODI = M.MUNCODI", Conexao.FbCnn);
                da.Fill(dt);
                if (dt.Rows.Count > 0) {
                    dgvbairro.DataSource = dt;
                }
            }
            finally {
                Conexao.Active(false);
            }
        }

        private void dgvbairro_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            if (dgvbairro.RowCount > 0 && dgvbairro.SelectedRows.Count == 1) {//para alterar um registro do dgv
                                                                              /*SETAR PROP MULTISELECT PARA FALSE E SELECTIONMODE PARA FULLROWSELECT NO DGV*/
                int paiCodigo = Convert.ToInt32(dgvbairro.SelectedRows[0].Cells[BAICODI.Name].Value);
                string sql = "SELECT * FROM BAIRRO "
                           + "WHERE BAICODI = " + paiCodigo;
                try {
                    Conexao.Active(true);
                    FbCommand cmd = new FbCommand(sql, Conexao.FbCnn);

                    FbDataReader dr = cmd.ExecuteReader();
                    if (dr.Read()) {
                        ConsultaBairro(dr);
                        tbcbairro.SelectedIndex = 1;
                        btnincluir.Enabled = false;
                        btngravar.Enabled = true;
                        if (nivel <= 5) {
                            btnexcluir.Enabled = true;
                        }
                        txtbainome.Focus();
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
            if (tbcbairro.SelectedIndex == 0)//tbclistagempais.SelectedTab == tbplistagem
            {
                DgvDados();
            }
        }

        private void btnvoltar_Click(object sender, EventArgs e) {

            this.Close();

        }

        private void txtbaicodi_Leave(object sender, EventArgs e)
        {
            Conexao.Active(true);
            if (txtbaicodi.Text != "")
            {
                string strConsulta = "SELECT * FROM BAIRRO WHERE BAICODI = " +
                txtbaicodi.Text;
                try
                {
                    FbCommand cmd = new FbCommand(strConsulta, Conexao.FbCnn);
                    FbDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        ConsultaBairro(dr);
                        txtbainome.Focus();
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
                            txtbainome.Text = "";
                            btngravar.Enabled = false;
                            btnexcluir.Enabled = false;
                            btnincluir.Enabled = true;
                            cbomuni.SelectedIndex = -1;
                            txtbainome.Focus();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                Conexao.Active(false);
            }
            else
            {
                Limpar();
            }
        }

        private void ConsultaBairro(FbDataReader dr)
        {
            txtbaicodi.Text = dr["BAICODI"].ToString();
            txtbainome.Text = dr["BAINOME"].ToString();
            int i = 0;
            for (i = 0; i < this.cbomuni.Items.Count; i++)
            {
                this.cbomuni.SelectedIndex = i;
                if (this.cbomuni.SelectedValue.ToString() == dr["MUNCODI"].ToString())
                {
                    return;
                }
            }
        }

        private void carregarMunicipios()
        {
            this.cbomuni.Items.Clear();
            string s = "Select * from MUNICIPIO order by(munnome)";
            Conexao.Active(true);
            FbCommand cmd = new FbCommand(s, Conexao.FbCnn);
            FbDataReader r = cmd.ExecuteReader();

            Dictionary<string, int> p = new Dictionary<string, int>();
            while (r.Read())
            {
                p.Add(r["munnome"].ToString(), Convert.ToInt32(r["muncodi"]));

            }
            this.cbomuni.DataSource = new BindingSource(p, null);
            this.cbomuni.DisplayMember = "key";
            this.cbomuni.ValueMember = "value";
            this.cbomuni.SelectedIndex = -1;
        }

        private void btnincluir_Click(object sender, EventArgs e){
            string strIncluir = "INSERT INTO BAIRRO(BAICODI,BAINOME,MUNCODI)"
                + " VALUES("
                + txtbaicodi.Text + ", '" + txtbainome.Text + "', "
                + Convert.ToInt32(this.cbomuni.SelectedValue)
                + " )";
            Conexao.Active(true);
            try
            {
                FbCommand cmd = new FbCommand(strIncluir, Conexao.FbCnn);
                cmd.ExecuteNonQuery();              
                MessageBox.Show("Registro incluído com sucesso !!!");
                DgvDados();
                Limpar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Conexao.Active(false);
        }

        private void btngravar_Click(object sender, EventArgs e)
        {
            string strAlterar = "UPDATE BAIRRO"
                 + " SET BAICODI = " + txtbaicodi.Text + ", "
                 + " BAINOME = '" + txtbainome.Text + "', "
                 + " MUNCODI = " + Convert.ToInt32(this.cbomuni.SelectedValue)
                 + " WHERE BAICODI = " + txtbaicodi.Text;
            Conexao.Active(true);
            try
            {
                FbCommand cmd = new FbCommand(strAlterar, Conexao.FbCnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro gravado com sucesso !!!");
                Limpar();
                DgvDados();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Conexao.Active(false);
        }

        private void btnexcluir_Click(object sender, EventArgs e){
            string strDelete = "DELETE FROM BAIRRO WHERE BAICODI = " + txtbaicodi.Text;
            Conexao.Active(true);
            try
            {
                FbCommand cmd = new FbCommand(strDelete, Conexao.FbCnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro excluído com sucesso !!!");
                DgvDados();
                Limpar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Conexao.Active(false);
        }
    }
}
