using System;
using System.Data;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;

namespace LES_17_I_M
{
    public partial class frmdepto : Form{

        int nivel = 0;

        public frmdepto()
        {
            InitializeComponent();
        }

        public frmdepto(int getnivel) {
            InitializeComponent();
            this.nivel = getnivel;
        }

        private void Limpar() {
            txtdepcodi.Clear();
            txtdepnome.Clear();
            btnexcluir.Enabled = false;
            btngravar.Enabled = false;
            btnexcluir.Enabled = false;
            txtdepcodi.Focus();
        }

        private void frmdepto_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
            if (e.KeyCode == Keys.Escape) {
                this.Close();
            }
        }

        private void frmdepto_Load(object sender, EventArgs e) {
            DgvDados();
            Limpar();
        }

        private void DgvDados() {
            Conexao.Active(true);
            try {
                //Trazer tabela do banco para DGV
                DataTable dt = new DataTable();
                FbDataAdapter da = new FbDataAdapter("SELECT * FROM DEPTO", Conexao.FbCnn);
                da.Fill(dt);
                if (dt.Rows.Count > 0) {
                    dgvdepto.DataSource = dt;
                }
            }
            finally {
                Conexao.Active(false);
            }
        }

        private void dgvdepto_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            if (dgvdepto.RowCount > 0 && dgvdepto.SelectedRows.Count == 1) {
                int paiCodigo = Convert.ToInt32(dgvdepto.SelectedRows[0].Cells[DEPCODI.Name].Value);
                string sql = "SELECT * FROM DEPTO "
                           + "WHERE DEPCODI = " + paiCodigo;
                try {
                    Conexao.Active(true);
                    FbCommand cmd = new FbCommand(sql, Conexao.FbCnn);

                    FbDataReader dr = cmd.ExecuteReader();
                    if (dr.Read()) {
                        txtdepcodi.Text = dr["DEPCODI"].ToString();
                        txtdepnome.Text = dr["DEPNOME"].ToString();
                        tbcdepto.SelectedIndex = 1;
                        btnincluir.Enabled = false;
                        btngravar.Enabled = true;
                        if (nivel <= 4) {
                            btnexcluir.Enabled = true;
                        }
                        txtdepnome.Focus();
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

        private void txtdepcodi_Leave(object sender, EventArgs e) {
            Conexao.Active(true);
            if (txtdepcodi.Text != "") {
                string strConsulta = "SELECT DEPCODI, DEPNOME FROM DEPTO WHERE DEPCODI = " +
                txtdepcodi.Text;
                try {
                    FbCommand cmd = new FbCommand(strConsulta, Conexao.FbCnn);
                    FbDataReader dr = cmd.ExecuteReader();
                    if (dr.Read()) {
                        ConsultaDepto(dr);
                        txtdepnome.Focus();
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
                            txtdepnome.Clear();
                            btngravar.Enabled = false;
                            btnexcluir.Enabled = false;
                            btnincluir.Enabled = true;
                            txtdepnome.Focus();
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

        private void ConsultaDepto(FbDataReader dr) {
            txtdepcodi.Text = dr["DEPCODI"].ToString();
            txtdepnome.Text = dr["DEPNOME"].ToString();
        }

        private void btnincluir_Click(object sender, EventArgs e) {
            string strIncluir = "INSERT INTO DEPTO(DEPCODI,DEPNOME)"
           + " VALUES("
           + txtdepcodi.Text + ", '" + txtdepnome.Text + "')";
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
            string strAlterar = "UPDATE DEPTO"
                  + " SET DEPCODI = " + txtdepcodi.Text + ", "
                  + " DEPNOME = '" + txtdepnome.Text + "'"
                  + " WHERE DEPCODI = " + txtdepcodi.Text;
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
            string strDelete = "DELETE FROM DEPTO WHERE DEPCODI = " + txtdepcodi.Text;
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
