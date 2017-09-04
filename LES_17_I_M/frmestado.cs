using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;

namespace LES_17_I_M
{
    public partial class frmestado : Form {

        int nivel = 0;
        public frmestado() {
            InitializeComponent();
        }

        public frmestado(int getnivel) {
            InitializeComponent();
            this.nivel = getnivel;
        }

        private void frmestado_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
            if (e.KeyCode == Keys.Escape) {
                this.Close();
            }
        }

        private void Limpar() {
            txtestcodi.Clear();
            txtesticms.Clear();
            txtestnome.Clear();
            txtestuf.Clear();
            cbopais.SelectedIndex = -1;
            btnexcluir.Enabled = false;
            btngravar.Enabled = false;
            btnincluir.Enabled = false;
            txtestcodi.Focus();

        }

        private void frmestado_Load(object sender, EventArgs e) {

            DgvDados(); //mostra o dgv ao entrar no formulário
            carregarPais();
            Limpar();

        }

        private void DgvDados() {
            Conexao.Active(true);
            try {
                DataTable dt = new DataTable();
                FbDataAdapter da = new FbDataAdapter("SELECT ESTCODI,ESTUF,ESTNOME,ESTICMS,PAINOME" 
                                                    +" FROM ESTADOS E left join PAIS P on E.PAICODI = P.PAICODI", Conexao.FbCnn);
                da.Fill(dt);
                if (dt.Rows.Count > 0) {
                    dgvestado.DataSource = dt;
                }
            }
            finally {
                Conexao.Active(false);
            }
        }

        private void dgvestado_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            if (dgvestado.RowCount > 0 && dgvestado.SelectedRows.Count == 1) {//para alterar um registro do dgv
                                                                              /*SETAR PROP MULTISELECT PARA FALSE E SELECTIONMODE PARA FULLROWSELECT NO DGV*/
                int paiCodigo = Convert.ToInt32(dgvestado.SelectedRows[0].Cells[ESTCODI.Name].Value);
                string sql = "SELECT * FROM ESTADOS "
                           + "WHERE ESTCODI = " + paiCodigo;
                try {
                    Conexao.Active(true);
                    FbCommand cmd = new FbCommand(sql, Conexao.FbCnn);

                    FbDataReader dr = cmd.ExecuteReader();
                    if (dr.Read()) {
                        ConsultaEstados(dr);
                        tbcestado.SelectedIndex = 1;
                        btnexcluir.Enabled = false;
                        btngravar.Enabled = true;
                        if (nivel <= 5) {
                            btnexcluir.Enabled = true;
                        }
                        txtestnome.Focus();
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

        private void tbcestado_Selected(object sender, TabControlEventArgs e) {
            if (tbcestado.SelectedIndex == 0)
            {
                DgvDados();
            }
        }

        private void btnvoltar_Click(object sender, EventArgs e) {

            this.Close();

        }

        private void txtestcodi_Leave(object sender, EventArgs e) {
            Conexao.Active(true);
            if (txtestcodi.Text != "") {
                string strConsulta = "SELECT ESTCODI, ESTUF, ESTNOME, ESTICMS, PAICODI FROM ESTADOS WHERE ESTCODI = " +
                txtestcodi.Text;
                try {
                    FbCommand cmd = new FbCommand(strConsulta, Conexao.FbCnn);
                    FbDataReader dr = cmd.ExecuteReader();
                    if (dr.Read()) {
                        ConsultaEstados(dr);
                        txtestuf.Focus();
                        btnincluir.Enabled = false;
                        btngravar.Enabled = true;
                        if (nivel <= 5) {
                            btnexcluir.Enabled = true;
                        }

                    }
                    else {
                        if ((MessageBox.Show("Registro não encontrado \n deseja cadastra-lo?",
                        "Cadastro", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)) {
                            Limpar();
                        }
                        else {
                            txtestnome.Clear();
                            txtesticms.Clear();
                            txtestuf.Clear();
                            cbopais.SelectedIndex = -1;
                            btngravar.Enabled = false;
                            btnexcluir.Enabled = false;
                            btnincluir.Enabled = true;
                            txtestuf.Focus();
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

        private void ConsultaEstados(FbDataReader dr) {
            txtestcodi.Text = dr["ESTCODI"].ToString();
            txtestuf.Text = dr["ESTUF"].ToString();
            txtestnome.Text = dr["ESTNOME"].ToString();
            txtesticms.Text = dr["ESTICMS"].ToString();
            int i = 0;
            for (i = 0; i < this.cbopais.Items.Count; i++) {
                this.cbopais.SelectedIndex = i;
                if (this.cbopais.SelectedValue.ToString() == dr["PAICODI"].ToString()) {
                    return;
                }
            }
        }

        private void carregarPais() {
            this.cbopais.Items.Clear();

            string s = "Select * from PAIS order by(PAINOME)";
            Conexao.Active(true);
            FbCommand cmd = new FbCommand(s, Conexao.FbCnn);
            FbDataReader r = cmd.ExecuteReader();

            Dictionary<string, int> p = new Dictionary<string, int>();
            while (r.Read()) {
                p.Add(r["painome"].ToString(), Convert.ToInt32(r["paicodi"]));

            }
            this.cbopais.DataSource = new BindingSource(p, null);
            this.cbopais.DisplayMember = "key";
            this.cbopais.ValueMember = "value";
            this.cbopais.SelectedIndex = -1;
        }

        private void btnincluir_Click(object sender, EventArgs e) {
            string icmsdot;
            icmsdot = txtesticms.Text.Replace(",", ".");
            string strIncluir = "INSERT INTO ESTADOS(ESTCODI,ESTUF,ESTNOME,ESTICMS,PAICODI)"
            + " VALUES("
            + txtestcodi.Text + ", '" + txtestuf.Text + "', '" + txtestnome.Text + "', " + icmsdot + ", "
            + Convert.ToInt32(this.cbopais.SelectedValue)
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
            string icmsdot;
            icmsdot = txtesticms.Text.Replace(",", ".");
            string strAlterar = "UPDATE ESTADOS"
                  + " SET ESTCODI = " + txtestcodi.Text + ", "
                  + " ESTUF = '" + txtestuf.Text + "', "
                  + " ESTNOME = '" + txtestnome.Text + "', "
                  + " ESTICMS = " + txtesticms.Text + ", "
                  + " PAICODI = " + Convert.ToInt32(this.cbopais.SelectedValue)
                  + " WHERE ESTCODI = " + txtestcodi.Text;
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
            string strDelete = "DELETE FROM ESTADOS WHERE ESTCODI = " + txtestcodi.Text;
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
