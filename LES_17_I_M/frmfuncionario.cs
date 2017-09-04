using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;

namespace LES_17_I_M
{
    public partial class frmfuncionario : Form{

        int nivel = 0;

        public frmfuncionario()
        {
            InitializeComponent();
        }

        public frmfuncionario(int getnivel) {
            InitializeComponent();
            this.nivel = getnivel;
        }

        private void Limpar() {
            txtfuncodi.Clear();
            txtfunnume.Clear();
            txtfunnome.Clear();
            txtfundtna.Clear();
            txtfunsala.Clear();
            txtfuncpf.Clear();
            txtfunrg.Clear();
            txtfunfone.Clear();
            txtfuncelu.Clear();
            txtfuncel1.Clear();
            cbocep.SelectedIndex = -1;
            cbodepto.SelectedIndex = -1;
            cbofuncao.SelectedIndex = -1;
            cbohorario.SelectedIndex = -1;
            this.btnincluir.Enabled = false;
            this.btngravar.Enabled = false;
            this.btnexcluir.Enabled = false;
            txtfuncodi.Focus();
        }

        private void frmfuncionario_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
            if (e.KeyCode == Keys.Escape) {
                this.Close();
            }
        }

        private void frmfuncionario_Load(object sender, EventArgs e) {
            DgvDados();
            CarregarCeps();
            CarregarDeptos();
            CarregarFuncao();
            CarregarHorario();
            Limpar();
        }

        private void DgvDados() {
            Conexao.Active(true);
            try {
                DataTable dt = new DataTable();
                FbDataAdapter da = new FbDataAdapter("SELECT FUNCODI,FUNNOME,FUNSALA,FUNDTNA,FUNCPF,FUNRG,FUNFONE,FUNCELU,FUNCEL1,FUNNUME"
                                                    +",ENDENDE, DEPNOME,FUCNOME,HORNOME from FUNCIONARIO F left join ENDERECO E on F.ENDCEP = E.ENDCEP"
                                                    +" left join DEPTO D on F.DEPCODI = D.DEPCODI"
                                                    +" left join FUNCAO FU on F.FUCCODI = FU.FUCCODI"
                                                    +" left join HORARIO H on F.HORCODI = H.HORCODI", Conexao.FbCnn);
                da.Fill(dt);
                if (dt.Rows.Count > 0) {
                    dgvfuncionario.DataSource = dt;
                }
            }
            finally {
                Conexao.Active(false);
            }
        }

        private void dgvfuncionario_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            if (dgvfuncionario.RowCount > 0 && dgvfuncionario.SelectedRows.Count == 1) {
                int paiCodigo = Convert.ToInt32(dgvfuncionario.SelectedRows[0].Cells[FUNCODI.Name].Value);
                string sql = "SELECT * FROM FUNCIONARIO "
                           + "WHERE FUNCODI = " + paiCodigo;
                try {
                    Conexao.Active(true);
                    FbCommand cmd = new FbCommand(sql, Conexao.FbCnn);

                    FbDataReader dr = cmd.ExecuteReader();
                    if (dr.Read()) {
                        ConsultaFuncionario(dr);
                        tbcFuncionario.SelectedIndex = 1;
                        btnincluir.Enabled = false;
                        btngravar.Enabled = true;
                        if (nivel <= 4) {
                            btnexcluir.Enabled = true;
                        }
                        txtfuncelu.Focus();
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

        private void txtfuncodi_Leave(object sender, EventArgs e) {
            Conexao.Active(true);
            if (txtfuncodi.Text != "") {
                string strConsulta = "SELECT * FROM FUNCIONARIO WHERE FUNCODI = " +
                txtfuncodi.Text;
                try {
                    FbCommand cmd = new FbCommand(strConsulta, Conexao.FbCnn);
                    FbDataReader dr = cmd.ExecuteReader();
                    if (dr.Read()) {
                        ConsultaFuncionario(dr);
                        txtfunnome.Focus();
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
                            txtfunnume.Clear();
                            txtfunnome.Clear();
                            txtfundtna.Clear();
                            txtfunsala.Clear();
                            txtfuncpf.Clear();
                            txtfunrg.Clear();
                            txtfunfone.Clear();
                            txtfuncelu.Clear();
                            txtfuncel1.Clear();
                            btngravar.Enabled = false;
                            btnexcluir.Enabled = false;
                            btnincluir.Enabled = true;
                            cbocep.SelectedIndex = -1;
                            cbodepto.SelectedIndex = -1;
                            cbohorario.SelectedIndex = -1;
                            cbofuncao.SelectedIndex = -1;
                            txtfunnome.Focus();
                        }
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
                Conexao.Active(false);
            }
            else {
                //Limpar();
            }
        }

        private void ConsultaFuncionario(FbDataReader dr) {
            txtfuncodi.Text = dr["FUNCODI"].ToString();
            txtfunnume.Text = dr["FUNNUME"].ToString();
            txtfunnome.Text = dr["FUNNOME"].ToString();
            txtfundtna.Text = dr["FUNDTNA"].ToString();
            txtfunsala.Text = dr["FUNSALA"].ToString();
            txtfuncpf.Text = dr["FUNCPF"].ToString();
            txtfunrg.Text = dr["FUNRG"].ToString();
            txtfunfone.Text = dr["FUNFONE"].ToString();
            txtfuncelu.Text = dr["FUNCELU"].ToString();
            txtfuncel1.Text = dr["FUNCEL1"].ToString();
            CarregaCep(dr);
            CarregaDepto(dr);
            CarregarFuncao(dr);
            CarregarHorario(dr);
        }

        private void CarregaCep(FbDataReader dr) {
            int i = 0;
            for (i = 0; i < this.cbocep.Items.Count; i++) {
                this.cbocep.SelectedIndex = i;
                if (Convert.ToInt32(this.cbocep.SelectedValue.ToString()) == Convert.ToInt32(dr["ENDCEP"].ToString())) {
                    return;
                }
            }
        }

        private void CarregaDepto(FbDataReader dr) {
            int i = 0;
            for (i = 0; i < this.cbodepto.Items.Count; i++) {
                this.cbodepto.SelectedIndex = i;
                if (Convert.ToInt32(this.cbodepto.SelectedValue.ToString()) == Convert.ToInt32(dr["DEPCODI"].ToString())) {
                    return;
                }
            }
        }

        private void CarregarFuncao(FbDataReader dr) {
            int i = 0;
            for (i = 0; i < this.cbofuncao.Items.Count; i++) {
                this.cbofuncao.SelectedIndex = i;
                if (Convert.ToInt32(this.cbofuncao.SelectedValue.ToString()) == Convert.ToInt32(dr["FUCCODI"].ToString())) {
                    return;
                }
            }
        }

        private void CarregarHorario(FbDataReader dr) {
            int i = 0;
            for (i = 0; i < this.cbohorario.Items.Count; i++) {
                this.cbohorario.SelectedIndex = i;
                if (Convert.ToInt32(this.cbohorario.SelectedValue.ToString()) == Convert.ToInt32(dr["HORCODI"].ToString())) {
                    return;
                }
            }
        }

        private void CarregarCeps() {
            this.cbocep.Items.Clear();

            string s = "Select * from ENDERECO order by (ENDENDE)";
            Conexao.Active(true);
            FbCommand cmd = new FbCommand(s, Conexao.FbCnn);
            FbDataReader r = cmd.ExecuteReader();

            Dictionary<string, int> p = new Dictionary<string, int>();
            while (r.Read()) {
                p.Add(r["ENDENDE"].ToString(), Convert.ToInt32(r["ENDCEP"]));

            }
            this.cbocep.DataSource = new BindingSource(p, null);
            this.cbocep.DisplayMember = "key";
            this.cbocep.ValueMember = "value";
            this.cbocep.SelectedIndex = -1;
        }

        private void CarregarDeptos() {
            this.cbodepto.Items.Clear();

            string s = "Select * from DEPTO order by (DEPNOME)";
            Conexao.Active(true);
            FbCommand cmd = new FbCommand(s, Conexao.FbCnn);
            FbDataReader r = cmd.ExecuteReader();

            Dictionary<string, int> p = new Dictionary<string, int>();
            while (r.Read()) {
                p.Add(r["DEPNOME"].ToString(), Convert.ToInt32(r["DEPCODI"]));

            }
            this.cbodepto.DataSource = new BindingSource(p, null);
            this.cbodepto.DisplayMember = "key";
            this.cbodepto.ValueMember = "value";
            this.cbodepto.SelectedIndex = -1;
        }

        private void CarregarFuncao() {
            this.cbofuncao.Items.Clear();

            string s = "Select * from FUNCAO order by (FUCNOME)";
            Conexao.Active(true);
            FbCommand cmd = new FbCommand(s, Conexao.FbCnn);
            FbDataReader r = cmd.ExecuteReader();

            Dictionary<string, int> p = new Dictionary<string, int>();
            while (r.Read()) {
                p.Add(r["FUCNOME"].ToString(), Convert.ToInt32(r["FUCCODI"]));

            }
            this.cbofuncao.DataSource = new BindingSource(p, null);
            this.cbofuncao.DisplayMember = "key";
            this.cbofuncao.ValueMember = "value";
            this.cbofuncao.SelectedIndex = -1;
        }

        private void CarregarHorario() {
            this.cbohorario.Items.Clear();

            string s = "Select * from HORARIO order by (HORNOME)";
            Conexao.Active(true);
            FbCommand cmd = new FbCommand(s, Conexao.FbCnn);
            FbDataReader r = cmd.ExecuteReader();

            Dictionary<string, int> p = new Dictionary<string, int>();
            while (r.Read()) {
                p.Add(r["HORNOME"].ToString(), Convert.ToInt32(r["HORCODI"]));

            }
            this.cbohorario.DataSource = new BindingSource(p, null);
            this.cbohorario.DisplayMember = "key";
            this.cbohorario.ValueMember = "value";
            this.cbohorario.SelectedIndex = -1;
        }

        private void btnincluir_Click(object sender, EventArgs e) {
            string saladot;
            saladot = txtfunsala.Text.Replace(",", ".");

            string strIncluir = "INSERT INTO FUNCIONARIO(FUNCODI,FUNNOME,FUNSALA,FUNDTNA,FUNCPF,FUNRG,FUNFONE,FUNCELU,FUNCEL1,FUNNUME,ENDCEP,DEPCODI,FUCCODI,HORCODI)"
            + " VALUES("
            + txtfuncodi.Text + ", '" + txtfunnome.Text + "', " + saladot + ", '" + txtfundtna.Text + "', '" + txtfuncpf.Text + "', '" + txtfunrg.Text + "', '"
            + txtfunfone.Text + "', '" + txtfuncelu.Text + "', '" + txtfuncel1.Text + "', '" + txtfunnume.Text + "', '" 
            +Convert.ToInt32(this.cbocep.SelectedValue) + "', " + Convert.ToInt32(this.cbodepto.SelectedValue) + ", "
            +Convert.ToInt32(this.cbofuncao.SelectedValue) + ", " + Convert.ToInt32(this.cbohorario.SelectedValue) + ")";
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
            string saladot;
            saladot = txtfunsala.Text.Replace(",", ".");

            string strAlterar = "UPDATE FUNCIONARIO"
                  + " SET FUNCODI = " + txtfuncodi.Text + ", "
                  + " FUNNOME = '" + txtfunnome.Text + "', FUNSALA = " + saladot + ", "
                  + " FUNDTNA = '" + txtfundtna.Text + "', FUNCPF = '" + txtfuncpf.Text + "', "
                  + " FUNRG = '" + txtfunrg.Text + "', FUNFONE = '" + txtfunfone.Text + "', "
                  + " FUNCELU = '" + txtfuncelu.Text + "', FUNCEL1 = '" + txtfuncel1.Text + "', "
                  + " FUNNUME = '" + txtfunnume.Text + "', "
                  + " ENDCEP = " + Convert.ToInt32(this.cbocep.SelectedValue) + ", DEPCODI = " + Convert.ToInt32(this.cbodepto.SelectedValue) + ", "
                  + " FUCCODI = " + Convert.ToInt32(this.cbofuncao.SelectedValue) + ", HORCODI = " + Convert.ToInt32(this.cbohorario.SelectedValue)
                  + " WHERE FUNCODI = " + txtfuncodi.Text;
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
            string strDelete = "DELETE FROM FUNCIONARIO WHERE FUNCODI = " + txtfuncodi.Text;
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
