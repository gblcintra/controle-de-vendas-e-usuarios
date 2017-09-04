using System;
using System.Data;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;

namespace LES_17_I_M
{
    public partial class frmConsDados : Form {
        public frmConsDados() {
            InitializeComponent();
        }

        private void frmConsDados_Load(object sender, EventArgs e) {
            LoadPais();
            LoadEstado();
            LoadMunicipio();
            LoadBairro();
            LoadEndereco();
        }

        private void LoadPais() {
            Conexao.Active(true);
            try {
                DataTable dt = new DataTable();
                FbDataAdapter da = new FbDataAdapter("SELECT * FROM PAIS", Conexao.FbCnn);
                da.Fill(dt);
                if (dt.Rows.Count > 0) {
                    dgvpais.DataSource = dt;
                }
            }
            finally {
                Conexao.Active(false);
            }
        }

        private void LoadEstado() {
            Conexao.Active(true);
            try {
                //Trazer tabela do banco para DGV
                DataTable dt = new DataTable();
                FbDataAdapter da = new FbDataAdapter("SELECT ESTCODI,ESTUF,ESTNOME,ESTICMS,PAINOME"
                                                    + " FROM ESTADOS E left join PAIS P on E.PAICODI = P.PAICODI", Conexao.FbCnn);
                da.Fill(dt);
                if (dt.Rows.Count > 0) {
                    dgvestado.DataSource = dt;
                }
            }
            finally {
                Conexao.Active(false);
            }
        }

        private void LoadMunicipio() {
            Conexao.Active(true);
            try {
                DataTable dt = new DataTable();
                FbDataAdapter da = new FbDataAdapter("SELECT MUNCODI,MUNNOME,ESTNOME"
                                                    + " FROM MUNICIPIO M left join ESTADOS E on M.ESTCODI = E.ESTCODI", Conexao.FbCnn);
                da.Fill(dt);
                if (dt.Rows.Count > 0) {
                    dgvmunicipio.DataSource = dt;
                }
            }
            finally {
                Conexao.Active(false);
            }
        }

        private void LoadBairro() {
            Conexao.Active(true);
            try {
                DataTable dt = new DataTable();
                FbDataAdapter da = new FbDataAdapter("SELECT BAICODI,BAINOME,MUNNOME FROM BAIRRO B left join MUNICIPIO M on B.MUNCODI = M.MUNCODI", Conexao.FbCnn);
                da.Fill(dt);
                if (dt.Rows.Count > 0) {
                    dgvbairro.DataSource = dt;
                }
            }
            finally {
                Conexao.Active(false);
            }
        }

        private void LoadEndereco() {
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

        private void frmConsDados_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
            if (e.KeyCode == Keys.Escape) {
                this.Close();
            }
        }

        private void dgvpais_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvbairro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvestado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
