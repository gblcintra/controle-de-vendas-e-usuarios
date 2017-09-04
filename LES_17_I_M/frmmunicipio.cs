using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;

namespace LES_17_I_M
{
    public partial class frmmunicipio : Form {

        int nivel = 0;

        public frmmunicipio() {
            InitializeComponent();
        }
        
        public frmmunicipio(int getnivel) {
            InitializeComponent();
            this.nivel = getnivel;
        }

        private void Limpar() {
            txtmuncodi.Clear();
            txtmunnome.Clear();
            btnexcluir.Enabled = false;
            btngravar.Enabled = false;
            btnincluir.Enabled = false;
            cboestados.SelectedIndex = -1;
            txtmuncodi.Focus();

        }

        private void frmmunicipio_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
            if (e.KeyCode == Keys.Escape) {
                this.Close();
            }
        }

        private void frmmunicipio_Load(object sender, EventArgs e) {
            DgvDados(); //mostra o dgv ao entrar no formulário
            CarregarEstados();
            Limpar();
        }

        private void DgvDados() { 
            Conexao.Active(true);
            try {
                DataTable dt = new DataTable();
                FbDataAdapter da = new FbDataAdapter("SELECT MUNCODI,MUNNOME,ESTNOME"
                                                    +" FROM MUNICIPIO M left join ESTADOS E on M.ESTCODI = E.ESTCODI", Conexao.FbCnn);
                da.Fill(dt);
                if (dt.Rows.Count > 0) {
                    dgvmunicipio.DataSource = dt;
                }
            }
            finally {
                Conexao.Active(false);
            }
        }

        private void dgvmunicipio_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            if (dgvmunicipio.RowCount > 0 && dgvmunicipio.SelectedRows.Count == 1) {
                int paiCodigo = Convert.ToInt32(dgvmunicipio.SelectedRows[0].Cells[MUNCODI.Name].Value);
                string sql = "SELECT * FROM MUNICIPIO "
                           + "WHERE MUNCODI = " + paiCodigo;
                try {
                    Conexao.Active(true);
                    FbCommand cmd = new FbCommand(sql, Conexao.FbCnn);

                    FbDataReader dr = cmd.ExecuteReader();
                    if (dr.Read()) {
                        ConsultaMunicipio(dr);
                        tbcmunicipio.SelectedIndex = 1;
                        btnincluir.Enabled = false;
                        btngravar.Enabled = true;
                        if (nivel <= 5) {
                            btnexcluir.Enabled = true;
                        }
                        txtmunnome.Focus();
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

        private void tbclistagempais_Selected(object sender, TabControlEventArgs e) { 
            if (tbcmunicipio.SelectedIndex == 0)
            {
                DgvDados();
            }
        }

        private void btnvoltar_Click(object sender, EventArgs e) {

            this.Close();

        }

        private void txtmuncodi_Leave(object sender, EventArgs e) {
            Conexao.Active(true);
            if (txtmuncodi.Text != "") {
                string strConsulta = "SELECT MUNCODI, MUNNOME, ESTCODI FROM MUNICIPIO WHERE MUNCODI = " +
                txtmuncodi.Text;
                try {
                    FbCommand cmd = new FbCommand(strConsulta, Conexao.FbCnn);
                    FbDataReader dr = cmd.ExecuteReader();
                    if (dr.Read()) {
                        ConsultaMunicipio(dr);
                        txtmunnome.Focus();
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
                            txtmunnome.Text = "";
                            btngravar.Enabled = false;
                            btnexcluir.Enabled = false;
                            btnincluir.Enabled = true;
                            cboestados.SelectedIndex = -1;
                            txtmunnome.Focus();
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

        private void ConsultaMunicipio(FbDataReader dr) {
            txtmuncodi.Text = dr["MUNCODI"].ToString();
            txtmunnome.Text = dr["MUNNOME"].ToString();
            int i = 0;
            for (i = 0; i < this.cboestados.Items.Count; i++) {
                this.cboestados.SelectedIndex = i;
                if (this.cboestados.SelectedValue.ToString() == dr["ESTCODI"].ToString()) {
                    return;
                }
            }
        }

        private void CarregarEstados() {
            this.cboestados.Items.Clear();

            string s = "Select * from ESTADOS order by(ESTNOME)";
            Conexao.Active(true);
            FbCommand cmd = new FbCommand(s, Conexao.FbCnn);
            FbDataReader r = cmd.ExecuteReader();

            Dictionary<string, int> p = new Dictionary<string, int>();
            while (r.Read()) {
                p.Add(r["estnome"].ToString(), Convert.ToInt32(r["estcodi"]));

            }
            this.cboestados.DataSource = new BindingSource(p, null);
            this.cboestados.DisplayMember = "key";
            this.cboestados.ValueMember = "value";
            this.cboestados.SelectedIndex = -1;
        }

        private void btnincluir_Click(object sender, EventArgs e) {
            string strIncluir = "INSERT INTO MUNICIPIO(MUNCODI,MUNNOME,ESTCODI)"
            + " VALUES("
            + txtmuncodi.Text + ", '" + txtmunnome.Text + "', "
            + Convert.ToInt32(this.cboestados.SelectedValue)
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
            string strAlterar = "UPDATE MUNICIPIO"
                  + " SET MUNCODI = " + txtmuncodi.Text + ", "
                  + " MUNNOME = '" + txtmunnome.Text + "', "
                  + " ESTCODI = " + Convert.ToInt32(this.cboestados.SelectedValue)
                  + " WHERE MUNCODI = " + txtmuncodi.Text;
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
            string strDelete = "DELETE FROM MUNICIPIO WHERE MUNCODI = " + txtmuncodi.Text;
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
