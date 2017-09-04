using System;
using System.Data;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;

namespace LES_17_I_M
{
    public partial class frmtipohorario : Form{

        int nivel = 0;

        public frmtipohorario()
        {
            InitializeComponent();
        }

        public frmtipohorario(int getnivel) {
            InitializeComponent();
            this.nivel = getnivel;
        }

        private void Limpar() {
            this.txtthocodi.Clear();
            this.txtthonome.Clear();
            this.btnexcluir.Enabled = false;
            this.btngravar.Enabled = false;
            this.btnincluir.Enabled = false;
            this.txtthocodi.Focus();
        }

        private void frmtipohorario_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
            if (e.KeyCode == Keys.Escape) {
                this.Close();
            }
        }

        private void frmtipohorario_Load(object sender, EventArgs e) {
            DgvDados();
            Limpar();
        }

        private void DgvDados() {
            Conexao.Active(true);
            try {
                DataTable dt = new DataTable();
                FbDataAdapter da = new FbDataAdapter("SELECT * FROM TIPOHORARIO", Conexao.FbCnn);
                da.Fill(dt);
                if (dt.Rows.Count > 0) {
                    dgvtipohorario.DataSource = dt;
                }
            }
            finally {
                Conexao.Active(false);
            }
        }

        private void dgvtipohorario_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            if (dgvtipohorario.RowCount > 0 && dgvtipohorario.SelectedRows.Count == 1) {
                int paiCodigo = Convert.ToInt32(dgvtipohorario.SelectedRows[0].Cells[THOCODI.Name].Value);
                string sql = "SELECT * FROM TIPOHORARIO "
                           + "WHERE THOCODI = " + paiCodigo;
                try {
                    Conexao.Active(true);
                    FbCommand cmd = new FbCommand(sql, Conexao.FbCnn);

                    FbDataReader dr = cmd.ExecuteReader();
                    if (dr.Read()) {
                        txtthocodi.Text = dr["THOCODI"].ToString();
                        txtthonome.Text = dr["THONOME"].ToString();
                        tbctipohorario.SelectedIndex = 1;
                        btnincluir.Enabled = false;
                        btngravar.Enabled = true;
                        if (nivel <= 4) {
                            btnexcluir.Enabled = true;
                        }
                        txtthonome.Focus();
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

        private void tbctipohorario_Selected(object sender, TabControlEventArgs e) {
            DgvDados();
        }

        private void btnvoltar_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void txtthocodi_Leave(object sender, EventArgs e) {
            Conexao.Active(true);
            if (txtthocodi.Text != "") {
                string strConsulta = "SELECT THOCODI, THONOME FROM TIPOHORARIO WHERE THOCODI = " +
                txtthocodi.Text;
                try {
                    FbCommand cmd = new FbCommand(strConsulta, Conexao.FbCnn);
                    FbDataReader dr = cmd.ExecuteReader();
                    if (dr.Read()) {
                        ConsultaTipoHorario(dr);
                        txtthonome.Focus();
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
                            txtthonome.Text = "";
                            btngravar.Enabled = false;
                            btnexcluir.Enabled = false;
                            btnincluir.Enabled = true;
                            txtthonome.Focus();
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

        private void ConsultaTipoHorario(FbDataReader dr) {
            txtthocodi.Text = dr["THOCODI"].ToString();
            txtthonome.Text = dr["THONOME"].ToString();
        }

        private void btnincluir_Click(object sender, EventArgs e) {
            string strIncluir = "INSERT INTO TIPOHORARIO(THOCODI,THONOME)"
            + " VALUES("
            + txtthocodi.Text + ", '" + txtthonome.Text + "')";
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
            string strAlterar = "UPDATE TIPOHORARIO"
                  + " SET THOCODI = " + txtthocodi.Text + ", "
                  + " THONOME = '" + txtthonome.Text + "' "
                  + " WHERE THOCODI = " + txtthocodi.Text;
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
            string strDelete = "DELETE FROM TIPOHORARIO WHERE THOCODI = " + txtthocodi.Text;
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
