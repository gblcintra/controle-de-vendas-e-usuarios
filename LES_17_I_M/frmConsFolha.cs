using System;
using System.Data;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;

namespace LES_17_I_M
{
    public partial class frmConsFolha : Form {
        public frmConsFolha() {
            InitializeComponent();
        }

        private void frmConsFolha_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
            if (e.KeyCode == Keys.Escape) {
                this.Close();
            }
        }

        private void frmConsFolha_Load(object sender, EventArgs e) {
            carregaCbo();
            carregaDepto();
            carregaFuncionario();
            carregaFuncao();
            carregaHorario();
            carregaTipoHorario();
        }

        private void carregaCbo() {
            Conexao.Active(true);
            try {
                DataTable dt = new DataTable();
                FbDataAdapter da = new FbDataAdapter("SELECT * FROM CBO", Conexao.FbCnn);
                da.Fill(dt);
                if (dt.Rows.Count > 0) {
                    dgvcbo.DataSource = dt;
                }
            }
            finally {
                Conexao.Active(false);
            }
        }

        private void carregaDepto() {
            Conexao.Active(true);
            try {
                //Trazer tabela do banco para DGV
                DataTable dt = new DataTable();
                FbDataAdapter da = new FbDataAdapter("SELECT * FROM DEPTO", Conexao.FbCnn);
                da.Fill(dt);
                if (dt.Rows.Count > 0) {
                    dgvdepto.DataSource = dt;
                }
            }
            finally {
                Conexao.Active(false);
            }
        }

        private void carregaFuncionario() {
            Conexao.Active(true);
            try {
                DataTable dt = new DataTable();
                FbDataAdapter da = new FbDataAdapter("SELECT FUNCODI,FUNNOME,FUNSALA,FUNDTNA,FUNCPF,FUNRG,FUNFONE,FUNCELU,FUNCEL1,FUNNUME"
                                                    + ",ENDENDE, DEPNOME,FUCNOME,HORNOME from FUNCIONARIO F left join ENDERECO E on F.ENDCEP = E.ENDCEP"
                                                    + " left join DEPTO D on F.DEPCODI = D.DEPCODI"
                                                    + " left join FUNCAO FU on F.FUCCODI = FU.FUCCODI"
                                                    + " left join HORARIO H on F.HORCODI = H.HORCODI", Conexao.FbCnn);
                da.Fill(dt);
                if (dt.Rows.Count > 0) {
                    dgvfuncionario.DataSource = dt;
                }
            }
            finally {
                Conexao.Active(false);
            }
        }

        private void carregaFuncao() {
            Conexao.Active(true);
            try {
                DataTable dt = new DataTable();
                FbDataAdapter da = new FbDataAdapter("SELECT FUCCODI,FUCNOME,CBONOME"
                                                    + " FROM FUNCAO F left join CBO C on F.CBOCODI = C.CBOCODI", Conexao.FbCnn);
                da.Fill(dt);
                if (dt.Rows.Count > 0) {
                    dgvfuncao.DataSource = dt;
                }
            }
            finally {
                Conexao.Active(false);
            }
        }

        private void carregaHorario() {
            Conexao.Active(true);
            try {
                DataTable dt = new DataTable();
                FbDataAdapter da = new FbDataAdapter("SELECT HORCODI,HORMANE,HORMANS,HORTARE,HORTARS,HORNOME,THONOME"
                                                    + " FROM HORARIO H left join TIPOHORARIO T on H.THOCODI = T.THOCODI", Conexao.FbCnn);
                da.Fill(dt);
                if (dt.Rows.Count > 0) {
                    dgvhorario.DataSource = dt;
                }
            }
            finally {
                Conexao.Active(false);
            }
        }

        private void carregaTipoHorario() {
            Conexao.Active(true);
            try {
                DataTable dt = new DataTable();
                FbDataAdapter da = new FbDataAdapter("SELECT * FROM TIPOHORARIO", Conexao.FbCnn);
                da.Fill(dt);
                if (dt.Rows.Count > 0) {
                    dgvtipohorario.DataSource = dt;
                }
            }
            finally {
                Conexao.Active(false);
            }
        }

        private void dgvcbo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
