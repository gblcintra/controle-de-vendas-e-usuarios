using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;

namespace LES_17_I_M
{
    public partial class frmprincipal : Form
    {

        string usuario = "";
        int nivel = 0;
        public frmprincipal()
        {
            InitializeComponent();
        }

        public frmprincipal(string userlog) {
            InitializeComponent();
            this.usuario = userlog;
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e){
            if(MessageBox.Show("Deseja realmente sair?", "Confirmação", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes){
                this.Close();
            }
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e){
            if (MessageBox.Show("Deseja realmente sair?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes){
                this.Close();
            }
        }

        private void frmprincipal_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
            if (e.KeyCode == Keys.Escape) {
                if (MessageBox.Show("Deseja realmente sair?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes) {
                    this.Close();
                }
            }
        }

        private void endereçoToolStripMenuItem_Click(object sender, EventArgs e) {
            frmendereco endereco = new frmendereco(nivel);
            endereco.ShowDialog();
        }

        private void bairroToolStripMenuItem_Click(object sender, EventArgs e) {
            frmbairro bairro = new frmbairro(nivel);
            bairro.ShowDialog();
        }

        private void municipioToolStripMenuItem_Click(object sender, EventArgs e) {
            frmmunicipio municipio = new frmmunicipio(nivel);
            municipio.ShowDialog();
        }

        private void estadoToolStripMenuItem_Click(object sender, EventArgs e) {
            frmestado estado = new frmestado(nivel);
            estado.ShowDialog();
        }

        private void paisToolStripMenuItem_Click(object sender, EventArgs e) {
            frmpais pais = new frmpais(nivel);
            pais.ShowDialog();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e) {
            frmsobre sobre = new frmsobre();
            sobre.ShowDialog();
        }

        private void funcionarioToolStripMenuItem_Click(object sender, EventArgs e){
            frmfuncionario funcionario = new frmfuncionario(nivel);
            funcionario.ShowDialog();
        }

        private void deptoToolStripMenuItem_Click(object sender, EventArgs e){
            frmdepto depto = new frmdepto(nivel);
            depto.ShowDialog();
        }

        private void tipoHToolStripMenuItem_Click(object sender, EventArgs e){
            frmtipohorario tipohorario = new frmtipohorario(nivel);
            tipohorario.ShowDialog();
        }

        private void horárioToolStripMenuItem_Click(object sender, EventArgs e){
            frmhorario horario = new frmhorario(nivel);
            horario.ShowDialog();
        }

        private void funçãoToolStripMenuItem_Click(object sender, EventArgs e){
            frmfuncao funcao = new frmfuncao(nivel);
            funcao.ShowDialog();
        }

        private void cBOToolStripMenuItem_Click(object sender, EventArgs e){
            frmcbo cbo = new frmcbo(nivel);
            cbo.ShowDialog();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e) {
            frmproduto produto = new frmproduto(nivel);
            produto.ShowDialog();
        }

        private void gruposToolStripMenuItem_Click(object sender, EventArgs e) {
            frmgrupo grupo = new frmgrupo(nivel);
            grupo.ShowDialog();
        }

        private void unidadesToolStripMenuItem_Click(object sender, EventArgs e) {
            frmunidade unidade = new frmunidade(nivel);
            unidade.ShowDialog();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e){
            frmcliente cliente = new frmcliente(nivel);
            cliente.ShowDialog();
        }

        private void ramoToolStripMenuItem_Click(object sender, EventArgs e){
            frmramo ramo = new frmramo(nivel);
            ramo.ShowDialog();
        }

       

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e) {
            frmusuario usuar = new frmusuario(usuario,nivel);
            usuar.ShowDialog();
        }

        private void frmprincipal_Load(object sender, EventArgs e) {

            PegaNivel();
        }

           

        private void lbltrocauser_Click(object sender, EventArgs e) {
            frmlogin login = new frmlogin();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }

        private void PegaNivel() {
            string sql = "SELECT USUNIVEL FROM USUARIO WHERE USUNOME = '" + usuario + "'";
            nivel = 0;
            try {
                Conexao.Active(true);
                FbCommand cmd = new FbCommand(sql, Conexao.FbCnn);
                FbDataReader dr = cmd.ExecuteReader();
                if (dr.Read()) {
                    nivel = Convert.ToInt32(dr["USUNIVEL"].ToString());
                }
            }
            finally {
                Conexao.Active(false);
            }
        }

        private void usuarioToolStripMenuItem1_Click(object sender, EventArgs e) {
            frmusuario usuar = new frmusuario(usuario, nivel);
            usuar.ShowDialog();
        }

        private void consultadados_Click(object sender, EventArgs e) {
            frmConsDados ConsDados = new frmConsDados();
            ConsDados.ShowDialog();
        }

        private void consultafolha_Click(object sender, EventArgs e) {
            frmConsFolha ConsFolha = new frmConsFolha();
            ConsFolha.ShowDialog();
        }

        private void consultavendas_Click(object sender, EventArgs e) {
            frmConsVendas ConsVenda = new frmConsVendas();
            ConsVenda.ShowDialog();
        }

    
    }
}
