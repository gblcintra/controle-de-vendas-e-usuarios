using System;
using System.Data;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;

namespace LES_17_I_M
{
    public partial class frmgrupo : Form {

        int nivel = 0;

        public frmgrupo() {
            InitializeComponent();
        }

        public frmgrupo(int getnivel) {
            InitializeComponent();
            this.nivel = getnivel;
        }

        private void frmgrupo_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
            if (e.KeyCode == Keys.Escape) {
                this.Close();
            }
        }

        private void Limpar() {
            txtgrucodi.Clear();
            txtgrunome.Clear();
            btnexcluir.Enabled = false;
            btngravar.Enabled = false;
            btnincluir.Enabled = false;
            txtgrucodi.Focus();
        }

        private void frmgrupo_Load(object sender, EventArgs e) {
            DgvDados();
            Limpar();
        }

        private void DgvDados() {
            Conexao.Active(true);
            try {
                DataTable dt = new DataTable();
                FbDataAdapter da = new FbDataAdapter("SELECT GRUCODI,GRUNOME FROM GRUPO", Conexao.FbCnn);
                da.Fill(dt);
                if (dt.Rows.Count > 0) {
                    dgvgrupo.DataSource = dt;
                }
            }
            finally {
                Conexao.Active(false);
            }
        }

        private void dgvgrupo_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            if (dgvgrupo.RowCount > 0 && dgvgrupo.SelectedRows.Count == 1) {
                int paiCodigo = Convert.ToInt32(dgvgrupo.SelectedRows[0].Cells[GRUCODI.Name].Value);
                string sql = "SELECT * FROM GRUPO "
                           + "WHERE GRUCODI = " + paiCodigo;
                try {
                    Conexao.Active(true);
                    FbCommand cmd = new FbCommand(sql, Conexao.FbCnn);

                    FbDataReader dr = cmd.ExecuteReader();
                    if (dr.Read()) {
                        ConsultaGrupos(dr);
                        tbcgrupo.SelectedIndex = 1;
                        btnexcluir.Enabled = false;
                        btngravar.Enabled = true;
                        if (nivel <= 3) {
                            btnexcluir.Enabled = true;
                        }
                        txtgrunome.Focus();
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

        private void btnvoltar_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void txtgrucodi_Leave(object sender, EventArgs e) {
            Conexao.Active(true);
            if (txtgrucodi.Text != "") {
                string strConsulta = "SELECT GRUCODI,GRUNOME FROM GRUPO WHERE GRUCODI = " +
                txtgrucodi.Text;
                try {
                    FbCommand cmd = new FbCommand(strConsulta, Conexao.FbCnn);
                    FbDataReader dr = cmd.ExecuteReader();
                    if (dr.Read()) {
                        ConsultaGrupos(dr);
                        txtgrunome.Focus();
                        btnincluir.Enabled = false;
                        btngravar.Enabled = true;
                        if (nivel <= 3) {
                            btnexcluir.Enabled = true;
                        }

                    }
                    else {
                        if ((MessageBox.Show("Registro não encontrado \n deseja cadastra-lo?",
                        "Cadastro", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)) {
                            Limpar();
                        }
                        else {
                            txtgrunome.Clear();
                            btngravar.Enabled = false;
                            btnexcluir.Enabled = false;
                            btnincluir.Enabled = true;
                            txtgrunome.Focus();
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

        private void ConsultaGrupos(FbDataReader dr) {
            txtgrucodi.Text = dr["GRUCODI"].ToString();
            txtgrunome.Text = dr["GRUNOME"].ToString();
        }

        private void btnincluir_Click(object sender, EventArgs e) {
            string strIncluir = "INSERT INTO GRUPO(GRUCODI,GRUNOME)"
            + " VALUES("
            + txtgrucodi.Text + ", '" + txtgrunome.Text + "')";
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
            string strAlterar = "UPDATE GRUPO"
                  + " SET GRUCODI = " + txtgrucodi.Text + ", "
                  + " GRUNOME = '" + txtgrunome.Text + "'"
                  + " WHERE GRUCODI = " + txtgrucodi.Text;
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
            string strDelete = "DELETE FROM GRUPO WHERE GRUCODI = " + txtgrucodi.Text;
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
