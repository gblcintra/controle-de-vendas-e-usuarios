using System;
using System.Data;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;

namespace LES_17_I_M
{
    public partial class frmConsVendas : Form {
        public frmConsVendas() {
            InitializeComponent();
        }

        private void frmConsVendas_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
            if (e.KeyCode == Keys.Escape) {
                this.Close();
            }
        }

        private void frmConsVendas_Load(object sender, EventArgs e) {
            carregaCliente();
            carregaGrupo();
            carregaRamo();
            carregaUnidade();
            carregaProduto();
            carregaPedido();
        }

        private void carregaCliente() {
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

        private void carregaGrupo() {
            Conexao.Active(true);
            try {
                DataTable dt = new DataTable();
                FbDataAdapter da = new FbDataAdapter("SELECT GRUCODI,GRUNOME FROM GRUPO", Conexao.FbCnn);
                da.Fill(dt);
                if (dt.Rows.Count > 0) {
                    dgvgrupo.DataSource = dt;
                }
            }
            finally {
                Conexao.Active(false);
            }


        }

        private void carregaRamo() {
            Conexao.Active(true);
            try {
                DataTable dt = new DataTable();
                FbDataAdapter da = new FbDataAdapter("SELECT RAMCODI,RAMNOME,RAMOBS from RAMO", Conexao.FbCnn);
                da.Fill(dt);
                if (dt.Rows.Count > 0) {
                    dgvramo.DataSource = dt;
                }
            }
            finally {
                Conexao.Active(false);
            }
        }

        private void carregaUnidade() {
            Conexao.Active(true);
            try {
                DataTable dt = new DataTable();
                FbDataAdapter da = new FbDataAdapter("SELECT UNICODI,UNINOME FROM UNIDADE", Conexao.FbCnn);
                da.Fill(dt);
                if (dt.Rows.Count > 0) {
                    dgvunidade.DataSource = dt;
                }
            }
            finally {
                Conexao.Active(false);
            }
        }

        private void carregaProduto() {
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

        private void carregaPedido() {
            Conexao.Active(true);
            try {
                DataTable dt = new DataTable();
                FbDataAdapter da = new FbDataAdapter("SELECT PEDCODI,PEDDTEM,PEDDTBA,PEDTOTA,PEDPERC,PEDDESC,PEDLIQU,PEDCOND,"
                                                    + "PEDOBS,CLINOME,FUNNOME from PEDIDO P left join CLIENTE C on P.CLICODI = C.CLICODI "
                                                    + "left join FUNCIONARIO F on P.FUNCODI = F.FUNCODI", Conexao.FbCnn);
                da.Fill(dt);
                if (dt.Rows.Count > 0) {
                    dgvpedidos.DataSource = dt;
                }
            }
            finally {
                Conexao.Active(false);
            }
        }

        private void dgvclientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
