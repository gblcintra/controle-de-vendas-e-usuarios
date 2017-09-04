using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;

namespace LES_17_I_M
{
    public partial class frmcliente : Form{

        int nivel = 0;

        public frmcliente()
        {
            InitializeComponent();
        }

        public frmcliente(int getnivel) {
            InitializeComponent();
            this.nivel = getnivel;
        }

        private void frmcliente_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
            if (e.KeyCode == Keys.Escape) {
                this.Close();
            }
        }

        private void Limpar() {
            txtclicodi.Clear();
            txtclinome.Clear();
            txtclifant.Clear();
            txtcliapel.Clear();
            txtclidtin.Clear();
            txtclilimi.Clear();
            txtcliemai.Clear();
            txtclicnpj.Clear();
            txtcliines.Clear();
            txtclifone.Clear();
            txtclicel1.Clear();
            txtclicelu.Clear();
            txtclinume.Clear();
            cboendereco.SelectedIndex = -1;
            cboramo.SelectedIndex = -1;
            btnexcluir.Enabled = false;
            btngravar.Enabled = false;
            btnincluir.Enabled = false;
            txtclicodi.Focus();
        }

        private void frmcliente_Load(object sender, EventArgs e) {
            DgvDados(); //mostra o dgv ao entrar no formulário
            carregarEndereco();
            carregarRamo();
            Limpar();
        }

        private void DgvDados() {
            Conexao.Active(true);
            try {
                DataTable dt = new DataTable();
                FbDataAdapter da = new FbDataAdapter("SELECT CLICODI, CLINOME, CLIFANT, CLIAPEL, CLILIMI, CLIDTIN, CLICNPJ, "
                                                    + "CLIINES, CLIEMAI, CLIFONE, CLICELU, CLICEL1, CLINUME, CLISTAT, "
                                                    + "RAMNOME, ENDENDE "
                                                    + "FROM CLIENTE C left join RAMO R on C.RAMCODI = R.RAMCODI left join ENDERECO E on C.ENDCEP = E.ENDCEP", Conexao.FbCnn);
                da.Fill(dt);
                if (dt.Rows.Count > 0) {
                    dgvclientes.DataSource = dt;
                }
            }
            finally {
                Conexao.Active(false);
            }
        }

        private void dgvclientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            if (dgvclientes.RowCount > 0 && dgvclientes.SelectedRows.Count == 1) {
                int paiCodigo = Convert.ToInt32(dgvclientes.SelectedRows[0].Cells[CLICODI.Name].Value);
                string sql = "SELECT * FROM CLIENTE "
                           + "WHERE CLICODI = " + paiCodigo;
                try {
                    Conexao.Active(true);
                    FbCommand cmd = new FbCommand(sql, Conexao.FbCnn);

                    FbDataReader dr = cmd.ExecuteReader();
                    if (dr.Read()) {
                        ConsultaClientes(dr);
                        tbcclientes.SelectedIndex = 1;
                        btnexcluir.Enabled = false;
                        btngravar.Enabled = true;
                        if (nivel <= 3) {
                            btnexcluir.Enabled = true;
                        }
                        txtclinome.Focus();
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

        private void txtclicodi_Leave(object sender, EventArgs e) {
            Conexao.Active(true);
            if (txtclicodi.Text != "") {
                string strConsulta = "SELECT * FROM CLIENTE WHERE CLICODI = " +
                txtclicodi.Text;
                try {
                    FbCommand cmd = new FbCommand(strConsulta, Conexao.FbCnn);
                    FbDataReader dr = cmd.ExecuteReader();
                    if (dr.Read()) {
                        ConsultaClientes(dr);
                        txtclinome.Focus();
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
                            txtclinome.Clear();
                            txtclifant.Clear();
                            txtcliapel.Clear();
                            txtclidtin.Clear();
                            txtclilimi.Clear();
                            txtcliemai.Clear();
                            txtclicnpj.Clear();
                            txtcliines.Clear();
                            txtclifone.Clear();
                            txtclicel1.Clear();
                            txtclicelu.Clear();
                            txtclinume.Clear();
                            cboendereco.SelectedIndex = -1;
                            cboramo.SelectedIndex = -1;
                            btngravar.Enabled = false;
                            btnexcluir.Enabled = false;
                            btnincluir.Enabled = true;
                            txtclinome.Focus();
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

        private void ConsultaClientes(FbDataReader dr) {
            txtclicodi.Text = dr["CLICODI"].ToString();
            txtclinome.Text = dr["CLINOME"].ToString();
            txtclifant.Text = dr["CLIFANT"].ToString();
            txtcliapel.Text = dr["CLIAPEL"].ToString();
            txtclidtin.Text = dr["CLIDTIN"].ToString();
            txtclilimi.Text = dr["CLILIMI"].ToString();
            txtcliemai.Text = dr["CLIEMAI"].ToString();
            txtclicnpj.Text = dr["CLICNPJ"].ToString();
            txtcliines.Text = dr["CLIINES"].ToString();
            txtclifone.Text = dr["CLIFONE"].ToString();
            txtclicelu.Text = dr["CLICELU"].ToString();
            txtclicel1.Text = dr["CLICEL1"].ToString();
            txtclistat.Text = dr["CLISTAT"].ToString();
            txtclinume.Text = dr["CLINUME"].ToString();
            CarregaRamo(dr);
            CarregaEndereco(dr);
        }

        private void CarregaRamo(FbDataReader dr) {
            int i = 0;
            for (i = 0; i < this.cboramo.Items.Count; i++) {
                this.cboramo.SelectedIndex = i;
                if (this.cboramo.SelectedValue.ToString() == dr["RAMCODI"].ToString()) {
                    return;
                }
            }
        }

        private void CarregaEndereco(FbDataReader dr) {
            int i = 0;
            for (i = 0; i < this.cboendereco.Items.Count; i++) {
                this.cboendereco.SelectedIndex = i;
                if (this.cboendereco.SelectedValue.ToString() == dr["ENDCEP"].ToString()) {
                    return;
                }
            }
        }

        private void carregarRamo() {
            this.cboramo.Items.Clear();

            string s = "Select * from RAMO order by(RAMNOME)";
            Conexao.Active(true);
            FbCommand cmd = new FbCommand(s, Conexao.FbCnn);
            FbDataReader r = cmd.ExecuteReader();

            Dictionary<string, int> p = new Dictionary<string, int>();
            while (r.Read()) {
                p.Add(r["ramnome"].ToString(), Convert.ToInt32(r["ramcodi"]));

            }
            this.cboramo.DataSource = new BindingSource(p, null);
            this.cboramo.DisplayMember = "key";
            this.cboramo.ValueMember = "value";
            this.cboramo.SelectedIndex = -1;
        }

        private void carregarEndereco() {
            this.cboendereco.Items.Clear();

            string s = "Select * from ENDERECO order by(ENDENDE)";
            Conexao.Active(true);
            FbCommand cmd = new FbCommand(s, Conexao.FbCnn);
            FbDataReader r = cmd.ExecuteReader();

            Dictionary<string, int> p = new Dictionary<string, int>();
            while (r.Read()) {
                p.Add(r["endende"].ToString(), Convert.ToInt32(r["endcep"]));

            }
            this.cboendereco.DataSource = new BindingSource(p, null);
            this.cboendereco.DisplayMember = "key";
            this.cboendereco.ValueMember = "value";
            this.cboendereco.SelectedIndex = -1;
        }

        private void btnincluir_Click(object sender, EventArgs e) {
            string limidot;
            limidot = txtclilimi.Text.Replace(",", ".");

            string strIncluir = "INSERT INTO CLIENTE"
            + " VALUES("
            + txtclicodi.Text + ", '" + txtclinome.Text + "', '" + txtclifant.Text + "', '" + txtcliapel.Text + "', "
            + limidot + ", '" + txtclidtin.Text + "', '" + txtclicnpj.Text + "', '" + txtcliines.Text + "', '"
            + txtcliemai.Text + "', '" + txtclifone.Text + "', '" + txtclicelu.Text + "', '" + txtclicel1.Text + "', '"
            + txtclinume.Text + "' , " + txtclistat.Text + ", "
            +Convert.ToInt32(this.cboramo.SelectedValue) + ", " + Convert.ToInt32(this.cboendereco.SelectedValue)
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
            string strAlterar = "UPDATE CLIENTE"
                   + " SET CLICODI = " + txtclicodi.Text + ", "
                   + " CLINOME = '" + txtclinome.Text + "', "
                   + " CLIFANT = '" + txtclifant.Text + "', CLIAPEL = '" + txtcliapel.Text + "', "
                   + " CLILIMI = " + txtclilimi.Text + ", CLIDTIN = '" + txtclidtin.Text + "', "
                   + " CLICNPJ = '" + txtclicnpj.Text + "', CLIINES = '" + txtcliines.Text + "', "
                   + " CLIEMAI = '" + txtcliemai.Text + "', CLIFONE = '" + txtclifone.Text + "', "
                   + " CLICELU = '" + txtclicelu.Text + "', CLICEL1 = '" + txtclicel1.Text + "', "
                   + " CLINUME = '" + txtclinume.Text + "', CLISTAT = " + txtclistat.Text + ", "
                   + " RAMCODI = " + Convert.ToInt32(this.cboramo.SelectedValue)  + ", "
                   + " ENDCEP = " + Convert.ToInt32(this.cboendereco.SelectedValue)
                   + " WHERE CLICODI = " + txtclicodi.Text;
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
            string strDelete = "DELETE FROM CLIENTE WHERE CLICODI = " + txtclicodi.Text;
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

        private void btnvoltar_Click(object sender, EventArgs e) {
            this.Close();
        }

    }
}
