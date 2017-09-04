using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;

namespace LES_17_I_M
{
    public partial class frmhorario : Form{

        int nivel = 0;

        public frmhorario()
        {
            InitializeComponent();
        }

        public frmhorario(int getnivel) {
            InitializeComponent();
            this.nivel = getnivel;
        }
        private void Limpar() {
            txthorcodi.Clear();
            txthormane.Clear();
            txthormans.Clear();
            txthortare.Clear();
            txthortars.Clear();
            txthornome.Clear();
            btnexcluir.Enabled = false;
            btngravar.Enabled = false;
            btnincluir.Enabled = false;
            cbotipohora.SelectedIndex = -1;
            txthorcodi.Focus();
        }

        private void frmhorario_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
            if (e.KeyCode == Keys.Escape) {
                this.Close();
            }
        }

        private void frmhorario_Load(object sender, EventArgs e) {
            DgvDados();
            CarregarTipoHora();
            Limpar();
        }

        private void DgvDados() {
            Conexao.Active(true);
            try {
                DataTable dt = new DataTable();
                FbDataAdapter da = new FbDataAdapter("SELECT HORCODI,HORMANE,HORMANS,HORTARE,HORTARS,HORNOME,THONOME"
                                                    +" FROM HORARIO H left join TIPOHORARIO T on H.THOCODI = T.THOCODI", Conexao.FbCnn);
                da.Fill(dt);
                if (dt.Rows.Count > 0) {
                    dgvhorario.DataSource = dt;
                }
            }
            finally {
                Conexao.Active(false);
            }
        }

        private void dgvhorario_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            if (dgvhorario.RowCount > 0 && dgvhorario.SelectedRows.Count == 1) {
                                                                                    /*SETAR PROP MULTISELECT PARA FALSE E SELECTIONMODE PARA FULLROWSELECT NO DGV*/
                int paiCodigo = Convert.ToInt32(dgvhorario.SelectedRows[0].Cells[HORCODI.Name].Value);
                string sql = "SELECT * FROM HORARIO "
                           + "WHERE HORCODI = " + paiCodigo;
                try {
                    Conexao.Active(true);
                    FbCommand cmd = new FbCommand(sql, Conexao.FbCnn);

                    FbDataReader dr = cmd.ExecuteReader();
                    if (dr.Read()) {
                        ConsultaHorario(dr);
                        tbchorario.SelectedIndex = 1;
                        btnincluir.Enabled = false;
                        btngravar.Enabled = true;
                        if (nivel <= 4) {
                            btnexcluir.Enabled = true;
                        }
                        txthornome.Focus();
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

        private void txthorcodi_Leave(object sender, EventArgs e) {
            Conexao.Active(true);
            if (txthorcodi.Text != "") {
                string strConsulta = "SELECT HORCODI, HORNOME, HORMANE, HORMANS, HORTARE, HORTARS, THOCODI FROM HORARIO WHERE HORCODI = " +
                txthorcodi.Text;
                try {
                    FbCommand cmd = new FbCommand(strConsulta, Conexao.FbCnn);
                    FbDataReader dr = cmd.ExecuteReader();
                    if (dr.Read()) {
                        ConsultaHorario(dr);
                        txthornome.Focus();
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
                            txthornome.Clear() ;
                            txthormane.Clear();
                            txthormans.Clear();
                            txthortare.Clear();
                            txthortars.Clear();
                            btngravar.Enabled = false;
                            btnexcluir.Enabled = false;
                            btnincluir.Enabled = true;
                            cbotipohora.SelectedIndex = -1;
                            txthornome.Focus();
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

        private void ConsultaHorario(FbDataReader dr) {
            txthorcodi.Text = dr["HORCODI"].ToString();
            txthornome.Text = dr["HORNOME"].ToString();
            txthormane.Text = dr["HORMANE"].ToString();
            txthormans.Text = dr["HORMANS"].ToString();
            txthortare.Text = dr["HORTARE"].ToString();
            txthortars.Text = dr["HORTARS"].ToString();
            int i = 0;
            for (i = 0; i < this.cbotipohora.Items.Count; i++) {
                this.cbotipohora.SelectedIndex = i;
                if (this.cbotipohora.SelectedValue.ToString() == dr["THOCODI"].ToString()) {
                    return;
                }
            }
        }

        private void CarregarTipoHora() {
            this.cbotipohora.Items.Clear();

            string s = "Select * from TIPOHORARIO order by(THONOME)";
            Conexao.Active(true);
            FbCommand cmd = new FbCommand(s, Conexao.FbCnn);
            FbDataReader r = cmd.ExecuteReader();

            Dictionary<string, int> p = new Dictionary<string, int>();
            while (r.Read()) {
                p.Add(r["thonome"].ToString(), Convert.ToInt32(r["thocodi"]));

            }
            this.cbotipohora.DataSource = new BindingSource(p, null);
            this.cbotipohora.DisplayMember = "key";
            this.cbotipohora.ValueMember = "value";
            this.cbotipohora.SelectedIndex = -1;
        }

        private void btnincluir_Click(object sender, EventArgs e) {
            string strIncluir = "INSERT INTO HORARIO(HORCODI,HORNOME,HORMANE,HORMANS,HORTARE,HORTARS,THOCODI)"
           + " VALUES("
           + txthorcodi.Text + ", '" + txthornome.Text + "', '" + txthormane.Text + "', '" + txthormans.Text + "', '"
           + txthortare.Text + "', '" + txthortars.Text + "', "
           + Convert.ToInt32(this.cbotipohora.SelectedValue)
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
            string strAlterar = "UPDATE HORARIO"
                  + " SET HORCODI = " + txthorcodi.Text + ", "
                  + " HORNOME = '" + txthornome.Text + "', "
                  + " HORMANE = '" + txthormane.Text + "', HORMANS = '" + txthormans.Text + "', "
                  + " HORTARE = '" + txthortare.Text + "', HORTARS = '" + txthortars.Text + "', "
                  + " THOCODI = " + Convert.ToInt32(this.cbotipohora.SelectedValue)
                  + " WHERE HORCODI = " + txthorcodi.Text;
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
            string strDelete = "DELETE FROM HORARIO WHERE HORCODI = " + txthorcodi.Text;
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
