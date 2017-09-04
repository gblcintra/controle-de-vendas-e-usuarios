using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;

namespace LES_17_I_M
{
    public partial class frmproduto : Form {

        int nivel = 0;

        public frmproduto() {
            InitializeComponent();
        }

        public frmproduto(int getnivel) {
            InitializeComponent();
            this.nivel = getnivel;
        }

        private void frmproduto_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
            if (e.KeyCode == Keys.Escape) {
                this.Close();
            }
        }

        private void Limpar() {
            txtprocodi.Clear();
            txtpronome.Clear();
            txtprocusto.Clear();
            txtpromarge.Clear();
            txtprovenda.Clear();
            txtproestoque.Clear();
            txtproloca.Clear();
            rtxtobs.Clear();
            cbogrupo.SelectedIndex = -1;
            cbounidade.SelectedIndex = -1;
            btnincluir.Enabled = false;
            btngravar.Enabled = false;
            btnexcluir.Enabled = false;
            txtprocodi.Focus();
        }

        private void frmproduto_Load(object sender, EventArgs e) {

            DgvDados();
            carregarGrupos();
            carregarUnidades();
            Limpar();
        }

        private void DgvDados() {
            Conexao.Active(true);
            try {
                DataTable dt = new DataTable();
                FbDataAdapter da = new FbDataAdapter("SELECT PROCODI,PRONOME,PROCUST,PROMARG,PROVEND,PROESTO,PROLOCA,PROOBS,GRUNOME,UNINOME"
                                                    + " FROM PRODUTO P left join GRUPO G on P.GRUCODI = G.GRUCODI"
                                                    + " left join UNIDADE U on P.UNICODI = U.UNICODI", Conexao.FbCnn);
                da.Fill(dt);
                if (dt.Rows.Count > 0) {
                    dgvprodutos.DataSource = dt;
                }
            }
            finally {
                Conexao.Active(false);
            }
        }

        private void dgvprodutos_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            if (dgvprodutos.RowCount > 0 && dgvprodutos.SelectedRows.Count == 1) {//para alterar um registro do dgv
                                                                              /*SETAR PROP MULTISELECT PARA FALSE E SELECTIONMODE PARA FULLROWSELECT NO DGV*/
                int paiCodigo = Convert.ToInt32(dgvprodutos.SelectedRows[0].Cells[PROCODI.Name].Value);
                string sql = "SELECT * FROM PRODUTO "
                           + "WHERE PROCODI = " + paiCodigo;
                try {
                    Conexao.Active(true);
                    FbCommand cmd = new FbCommand(sql, Conexao.FbCnn);

                    FbDataReader dr = cmd.ExecuteReader();
                    if (dr.Read()) {
                        ConsultaProdutos(dr);
                        tbcproduto.SelectedIndex = 1;
                        btnexcluir.Enabled = false;
                        btngravar.Enabled = true;
                        if (nivel <= 3) {
                            btnexcluir.Enabled = true;
                        }
                        txtpronome.Focus();
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

        private void txtprocodi_Leave(object sender, EventArgs e) {
            Conexao.Active(true);
            if (txtprocodi.Text != "") {
                string strConsulta = "SELECT * FROM PRODUTO WHERE PROCODI = " +
                txtprocodi.Text;
                try {
                    FbCommand cmd = new FbCommand(strConsulta, Conexao.FbCnn);
                    FbDataReader dr = cmd.ExecuteReader();
                    if (dr.Read()) {
                        ConsultaProdutos(dr);
                        txtpronome.Focus();
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
                            txtpronome.Clear();
                            txtprocusto.Clear();
                            txtpromarge.Clear();
                            txtprovenda.Clear();
                            txtproestoque.Clear();
                            txtproloca.Clear();
                            rtxtobs.Clear();
                            cbogrupo.SelectedIndex = -1;
                            cbounidade.SelectedIndex = -1;
                            btngravar.Enabled = false;
                            btnexcluir.Enabled = false;
                            btnincluir.Enabled = true;
                            txtpronome.Focus();
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

        private void ConsultaProdutos(FbDataReader dr) {
            txtprocodi.Text = dr["PROCODI"].ToString();
            txtpronome.Text = dr["PRONOME"].ToString();
            txtprocusto.Text = dr["PROCUST"].ToString();
            txtpromarge.Text = dr["PROMARG"].ToString();
            txtprovenda.Text = dr["PROVEND"].ToString();
            txtproestoque.Text = dr["PROESTO"].ToString();
            txtproloca.Text = dr["PROLOCA"].ToString();
            rtxtobs.Text = dr["PROOBS"].ToString();
            ConsultaGrupo(dr);
            ConsultaUnidade(dr);
        }

        private void ConsultaGrupo(FbDataReader dr) {
            int i = 0;
            for (i = 0; i < this.cbogrupo.Items.Count; i++) {
                this.cbogrupo.SelectedIndex = i;
                if (this.cbogrupo.SelectedValue.ToString() == dr["GRUCODI"].ToString()) {
                    return;
                }
            }
        }

        private void ConsultaUnidade(FbDataReader dr) {
            int i = 0;
            for (i = 0; i < this.cbounidade.Items.Count; i++) {
                this.cbounidade.SelectedIndex = i;
                if (this.cbounidade.SelectedValue.ToString() == dr["UNICODI"].ToString()) {
                    return;
                }
            }
        }

        private void carregarGrupos() {
            this.cbogrupo.Items.Clear();

            string s = "Select * from GRUPO order by(GRUNOME)";
            Conexao.Active(true);
            FbCommand cmd = new FbCommand(s, Conexao.FbCnn);
            FbDataReader r = cmd.ExecuteReader();

            Dictionary<string, int> p = new Dictionary<string, int>();
            while (r.Read()) {
                p.Add(r["grunome"].ToString(), Convert.ToInt32(r["grucodi"]));

            }
            this.cbogrupo.DataSource = new BindingSource(p, null);
            this.cbogrupo.DisplayMember = "key";
            this.cbogrupo.ValueMember = "value";
            this.cbogrupo.SelectedIndex = -1;
        }

        private void carregarUnidades() {
            this.cbounidade.Items.Clear();

            string s = "Select * from UNIDADE order by(UNINOME)";
            Conexao.Active(true);
            FbCommand cmd = new FbCommand(s, Conexao.FbCnn);
            FbDataReader r = cmd.ExecuteReader();

            Dictionary<string, int> p = new Dictionary<string, int>();
            while (r.Read()) {
                p.Add(r["uninome"].ToString(), Convert.ToInt32(r["unicodi"]));

            }
            this.cbounidade.DataSource = new BindingSource(p, null);
            this.cbounidade.DisplayMember = "key";
            this.cbounidade.ValueMember = "value";
            this.cbounidade.SelectedIndex = -1;
        }

        private void btnincluir_Click(object sender, EventArgs e) {
            string custdot, margdot, venddot, estodot;
            custdot = txtprocusto.Text.Replace(",", ".");
            margdot = txtpromarge.Text.Replace(",", ".");
            venddot = txtprovenda.Text.Replace(",", ".");
            estodot = txtproestoque.Text.Replace(",", ".");

            string strIncluir = "INSERT INTO PRODUTO(PROCODI,PRONOME,PROCUST,PROMARG,PROVEND,PROESTO,PROLOCA,PROOBS,GRUCODI,UNICODI)"
            + " VALUES("
            + txtprocodi.Text + ", '" + txtpronome.Text + "', " + custdot + ", " + margdot + ", " + venddot + ", "
            + estodot + ", '" + txtproloca.Text + "', '" + rtxtobs.Text + "', "
            + Convert.ToInt32(this.cbogrupo.SelectedValue) + ", " + Convert.ToInt32(this.cbounidade.SelectedValue)
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
            string custdot, margdot, venddot, estodot;
            custdot = txtprocusto.Text.Replace(",", ".");
            margdot = txtpromarge.Text.Replace(",", ".");
            venddot = txtprovenda.Text.Replace(",", ".");
            estodot = txtproestoque.Text.Replace(",", ".");

            string strAlterar = "UPDATE PRODUTO"
                  + " SET PROCODI = " + txtprocodi.Text + ", "
                  + " PRONOME = '" + txtpronome.Text + "', "
                  + " PROCUST = " + custdot + ", "
                  + " PROMARG = " + margdot + ", "
                  + " PROVEND = " + venddot + ", "
                  + " PROESTO = " + estodot + ", "
                  + " PROLOCA = '" + txtproloca.Text + "', "
                  + " PROOBS = '" + rtxtobs.Text + "', "
                  + " GRUCODI = " + Convert.ToInt32(this.cbogrupo.SelectedValue) + ", "
                  + " UNICODI = " + Convert.ToInt32(this.cbounidade.SelectedValue)
                  + " WHERE PROCODI = " + txtprocodi.Text;
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
            string strDelete = "DELETE FROM PRODUTO WHERE PROCODI = " + txtprocodi.Text;
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
