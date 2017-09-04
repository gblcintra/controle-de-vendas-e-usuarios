using System;
using System.Data;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;

namespace LES_17_I_M
{
    public partial class frmramo : Form{

        int nivel = 0;

        public frmramo()
        {
            InitializeComponent();
        }

        public frmramo(int getnivel) {
            InitializeComponent();
            this.nivel = getnivel;
        }

        private void frmramo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void Limpar()
        {
            txtramcodi.Clear();
            txtramnome.Clear();
            rtxtramobs.Clear();
            btnexcluir.Enabled = false;
            btngravar.Enabled = false;
            btnincluir.Enabled = false;
            txtramcodi.Focus();
        }

        private void frmramo_Load(object sender, EventArgs e)
        {
            DgvDados();
            Limpar();
        }

        private void DgvDados()
        {
            Conexao.Active(true);
            try
            {
                DataTable dt = new DataTable();
                FbDataAdapter da = new FbDataAdapter("SELECT RAMCODI,RAMNOME,RAMOBS from RAMO", Conexao.FbCnn);
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dgvramo.DataSource = dt;
                }
            }
            finally
            {
                Conexao.Active(false);
            }
        }

        private void dgvramo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvramo.RowCount > 0 && dgvramo.SelectedRows.Count == 1)
            {
                int paiCodigo = Convert.ToInt32(dgvramo.SelectedRows[0].Cells[RAMCODI.Name].Value);
                string sql = "SELECT * FROM RAMO "
                           + "WHERE RAMCODI = " + paiCodigo;
                try
                {
                    Conexao.Active(true);
                    FbCommand cmd = new FbCommand(sql, Conexao.FbCnn);

                    FbDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        ConsultaRamos(dr);
                        tbcramo.SelectedIndex = 1;
                        btnexcluir.Enabled = false;
                        btngravar.Enabled = true;
                        if (nivel <= 3) {
                            btnexcluir.Enabled = true;
                        }
                        txtramnome.Focus();
                    }
                }
                finally
                {
                    Conexao.Active(false);
                }

            }
            else
            {
                MessageBox.Show("Nenhum registro selecionado!");
            }
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtramcodi_Leave(object sender, EventArgs e)
        {
            Conexao.Active(true);
            if (txtramcodi.Text != "")
            {
                string strConsulta = "SELECT RAMCODI,RAMNOME,RAMOBS FROM RAMO WHERE RAMCODI = " +
                txtramcodi.Text;
                try
                {
                    FbCommand cmd = new FbCommand(strConsulta, Conexao.FbCnn);
                    FbDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        ConsultaRamos(dr);
                        txtramnome.Focus();
                        btnincluir.Enabled = false;
                        btngravar.Enabled = true;
                        if (nivel <= 3) {
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
                            txtramnome.Clear();
                            rtxtramobs.Clear();
                            btngravar.Enabled = false;
                            btnexcluir.Enabled = false;
                            btnincluir.Enabled = true;
                            txtramnome.Focus();
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

        private void ConsultaRamos(FbDataReader dr)
        {
            txtramcodi.Text = dr["RAMCODI"].ToString();
            txtramnome.Text = dr["RAMNOME"].ToString();
            rtxtramobs.Text = dr["RAMOBS"].ToString();
        }

        private void btnincluir_Click(object sender, EventArgs e)
        {
            string strIncluir = "INSERT INTO RAMO(RAMCODI,RAMNOME,RAMOBS)"
            + " VALUES("
            + txtramcodi.Text + ", '" + txtramnome.Text + "', '" + rtxtramobs.Text + "') "; 
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
            string strAlterar = "UPDATE RAMO"
            + " SET RAMCODI = " + txtramcodi.Text + ", "
            + " RAMNOME = '" + txtramnome.Text + "', "
            + " RAMOBS = '" + rtxtramobs.Text + "' "
            + " WHERE RAMCODI = " + txtramcodi.Text;
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

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            string strDelete = "DELETE FROM RAMO WHERE RAMCODI = " + txtramcodi.Text;
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
