using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;

namespace LES_17_I_M
{
    public partial class frmendereco : Form {

        int nivel = 0;

        public frmendereco() {
            InitializeComponent();
        }

        public frmendereco(int getnivel) {
            InitializeComponent();
            this.nivel = getnivel;
        }

        private void frmendereco_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
            if (e.KeyCode == Keys.Escape) {
                this.Close();
            }
        }

        private void Limpar() {
            txtendcep.Clear();
            txtendnome.Clear();
            btnexcluir.Enabled = false;
            btngravar.Enabled = false;
            btnincluir.Enabled = false;
            cbobairros.SelectedIndex = -1;
            txtendcep.Focus();

        }

        private void frmendereco_Load(object sender, EventArgs e) {

            DgvDados();
            carregarBairros();
            Limpar();

        }

        private void DgvDados() {
            Conexao.Active(true);
            try {
                DataTable dt = new DataTable();
                FbDataAdapter da = new FbDataAdapter("SELECT ENDCEP,ENDENDE,BAINOME FROM ENDERECO E left join BAIRRO B on E.BAICODI = B.BAICODI", Conexao.FbCnn);
                da.Fill(dt);
                if (dt.Rows.Count > 0) {
                    dgvendereco.DataSource = dt;
                }
            }
            finally {
                Conexao.Active(false);
            }
        }

        private void dgvendereco_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            if (dgvendereco.RowCount > 0 && dgvendereco.SelectedRows.Count == 1) {//para alterar um registro do dgv
                                                                                  /*SETAR PROP MULTISELECT PARA FALSE E SELECTIONMODE PARA FULLROWSELECT NO DGV*/
                int paiCodigo = Convert.ToInt32(dgvendereco.SelectedRows[0].Cells[ENDCEP.Name].Value);
                string sql = "SELECT * FROM ENDERECO "
                           + "WHERE ENDCEP = " + paiCodigo;
                try {
                    Conexao.Active(true);
                    FbCommand cmd = new FbCommand(sql, Conexao.FbCnn);

                    FbDataReader dr = cmd.ExecuteReader();
                    if (dr.Read()) {
                        ConsultaEndereco(dr);
                        tbcendereco.SelectedIndex = 1;
                        btnincluir.Enabled = false;
                        btngravar.Enabled = true;
                        if (nivel <= 5) {
                            btnexcluir.Enabled = true;
                        }
                        txtendnome.Focus();
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

        private void txtendcep_Leave(object sender, EventArgs e)
        {
            Conexao.Active(true);
            if (txtendcep.Text != "")
            {
                string strConsulta = "SELECT ENDCEP, ENDENDE, BAICODI FROM ENDERECO WHERE ENDCEP = " +
                txtendcep.Text;
                try
                {
                    FbCommand cmd = new FbCommand(strConsulta, Conexao.FbCnn);
                    FbDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        ConsultaEndereco(dr);
                        txtendnome.Focus();
                        btnincluir.Enabled = false;
                        btngravar.Enabled = true;
                        if (nivel <= 5) {
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
                            txtendnome.Text = "";
                            btngravar.Enabled = false;
                            btnexcluir.Enabled = false;
                            btnincluir.Enabled = true;
                            cbobairros.SelectedIndex = -1;
                            txtendnome.Focus();
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

        private void ConsultaEndereco(FbDataReader dr)
        {
            txtendcep.Text = dr["ENDCEP"].ToString();
            txtendnome.Text = dr["ENDENDE"].ToString();
            int i = 0;
            for(i = 0; i < this.cbobairros.Items.Count; i++)
            {
                this.cbobairros.SelectedIndex = i;
                if(this.cbobairros.SelectedValue.ToString() == dr["BAICODI"].ToString())
                {
                    return;
                }
            }
        }
        
        private void carregarBairros()
        {
            this.cbobairros.Items.Clear();

            string s = "Select * from BAIRRO order by(BAINOME)";
            Conexao.Active(true);
            FbCommand cmd = new FbCommand(s, Conexao.FbCnn);
            FbDataReader r = cmd.ExecuteReader();

            Dictionary<string, int> p = new Dictionary<string, int>();
            while (r.Read())
            {
                p.Add(r["bainome"].ToString(), Convert.ToInt32(r["baicodi"]));

            }
            this.cbobairros.DataSource = new BindingSource(p, null);
            this.cbobairros.DisplayMember = "key";
            this.cbobairros.ValueMember = "value";
            this.cbobairros.SelectedIndex = -1;
        }

        private void btnincluir_Click(object sender, EventArgs e)
        {
            string strIncluir = "INSERT INTO ENDERECO(ENDCEP,ENDENDE,BAICODI)"
        + " VALUES("
        + txtendcep.Text + ", '" + txtendnome.Text + "', "
        + Convert.ToInt32(this.cbobairros.SelectedValue)
        + " )";
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
            string strAlterar = "UPDATE ENDERECO"
                  + " SET ENDCEP = " + txtendcep.Text + ", "
                  + " ENDENDE = '" + txtendnome.Text + "', "
                  + " BAICODI = " + Convert.ToInt32(this.cbobairros.SelectedValue)
                  + " WHERE ENDCEP = " + txtendcep.Text;
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
            string strDelete = "DELETE FROM ENDERECO WHERE ENDCEP = " + txtendcep.Text;
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
