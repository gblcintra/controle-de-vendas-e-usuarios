using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;

namespace LES_17_I_M
{
    public partial class frmfuncao : Form{

        int nivel = 0;
        
        public frmfuncao(){
            InitializeComponent();
        }

        public frmfuncao(int getnivel) {
            InitializeComponent();
            this.nivel = getnivel;
        }

        private void Limpar() {
            txtfuccodi.Clear();
            txtfucnome.Clear();
            btnexcluir.Enabled = false;
            btngravar.Enabled = false;
            btnincluir.Enabled = false;
            cbocbo.SelectedIndex = -1;
            txtfuccodi.Focus();
        }

        private void frmfuncao_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
            if (e.KeyCode == Keys.Escape) {
                this.Close();
            }
        }

        private void frmfuncao_Load(object sender, EventArgs e) {
            DgvDados();
            CarregarDados();
            Limpar();
        }

        private void DgvDados() {
            Conexao.Active(true);
            try {
                DataTable dt = new DataTable();
                FbDataAdapter da = new FbDataAdapter("SELECT FUCCODI,FUCNOME,CBONOME"
                                                    +" FROM FUNCAO F left join CBO C on F.CBOCODI = C.CBOCODI", Conexao.FbCnn);
                da.Fill(dt);
                if (dt.Rows.Count > 0) {
                    dgvfuncao.DataSource = dt;
                }
            }
            finally {
                Conexao.Active(false);
            }
        }

        private void dgvfuncao_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            if (dgvfuncao.RowCount > 0 && dgvfuncao.SelectedRows.Count == 1) {//para alterar um registro do dgv
                                                                                    /*SETAR PROP MULTISELECT PARA FALSE E SELECTIONMODE PARA FULLROWSELECT NO DGV*/
                int paiCodigo = Convert.ToInt32(dgvfuncao.SelectedRows[0].Cells[FUCCODI.Name].Value);
                string sql = "SELECT * FROM FUNCAO "
                           + "WHERE FUCCODI = " + paiCodigo;
                try {
                    Conexao.Active(true);
                    FbCommand cmd = new FbCommand(sql, Conexao.FbCnn);

                    FbDataReader dr = cmd.ExecuteReader();
                    if (dr.Read()) {
                        ConsultaFuncao(dr);
                        tbcfuncao.SelectedIndex = 1;
                        btnincluir.Enabled = false;
                        btngravar.Enabled = true;
                        if (nivel <= 4) {
                            btnexcluir.Enabled = true;
                        }
                        txtfucnome.Focus();
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

        private void txtfuccodi_Leave(object sender, EventArgs e) {
            Conexao.Active(true);
            if (txtfuccodi.Text != "") {
                string strConsulta = "SELECT FUCCODI,FUCNOME,CBOCODI FROM FUNCAO WHERE FUCCODI = " +
                txtfuccodi.Text;
                try {
                    FbCommand cmd = new FbCommand(strConsulta, Conexao.FbCnn);
                    FbDataReader dr = cmd.ExecuteReader();
                    if (dr.Read()) {
                        ConsultaFuncao(dr);
                        txtfucnome.Focus();
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
                            txtfucnome.Text = "";
                            btngravar.Enabled = false;
                            btnexcluir.Enabled = false;
                            btnincluir.Enabled = true;
                            cbocbo.SelectedIndex = -1;
                            txtfucnome.Focus();
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

        private void ConsultaFuncao(FbDataReader dr) {
            txtfuccodi.Text = dr["FUCCODI"].ToString();
            txtfucnome.Text = dr["FUCNOME"].ToString();
            int i = 0;
            for (i = 0; i < this.cbocbo.Items.Count; i++) {
                this.cbocbo.SelectedIndex = i;
                if (this.cbocbo.SelectedValue.ToString() == dr["CBOCODI"].ToString()) {
                    return;
                }
            }
        }

        private void CarregarDados() {
            this.cbocbo.Items.Clear();

            string s = "Select * from CBO order by (CBONOME)";
            Conexao.Active(true);
            FbCommand cmd = new FbCommand(s, Conexao.FbCnn);
            FbDataReader r = cmd.ExecuteReader();

            Dictionary<string, int> p = new Dictionary<string, int>();
            while (r.Read()) {
                p.Add(r["cbonome"].ToString(), Convert.ToInt32(r["cbocodi"]));

            }
            this.cbocbo.DataSource = new BindingSource(p, null);
            this.cbocbo.DisplayMember = "key";
            this.cbocbo.ValueMember = "value";
            this.cbocbo.SelectedIndex = -1;
        }

        private void btnincluir_Click(object sender, EventArgs e) {
            string strIncluir = "INSERT INTO FUNCAO(FUCCODI,FUCNOME,CBOCODI)"
            + " VALUES("
            + txtfuccodi.Text + ", '" + txtfucnome.Text + "', "
            + Convert.ToInt32(this.cbocbo.SelectedValue)
            + " )";
            Conexao.Active(true);
            try {
                FbCommand cmd = new FbCommand(strIncluir, Conexao.FbCnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro incluído com sucesso !!!");
                DgvDados();
                Limpar();
                this.dgvfuncao.Update();
                this.dgvfuncao.Refresh();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            Conexao.Active(false);
        }

        private void btngravar_Click(object sender, EventArgs e) {
            string strAlterar = "UPDATE FUNCAO"
                  + " SET FUCCODI = " + txtfuccodi.Text + ", "
                  + " FUCNOME = '" + txtfucnome.Text + "', "
                  + " CBOCODI = " + Convert.ToInt32(this.cbocbo.SelectedValue)
                  + " WHERE FUCCODI = " + txtfuccodi.Text;
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
            string strDelete = "DELETE FROM FUNCAO WHERE FUCCODI = " + txtfuccodi.Text;
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
