using System;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;

namespace LES_17_I_M
{
    public partial class frmlogin : Form {
        public frmlogin() {
            InitializeComponent();
        }
        //Variaveis Teste
        string login = "";
        string pass = "";
        string acesso = "";
        string data = "";
        string qtde = "";
        //
        int tentativas = 3;
        string user = "";

        private void chkmostrar_CheckedChanged(object sender, EventArgs e) {
            if(chkmostrar.Checked == true) {
                txtpass.PasswordChar = '\0';
            }
            else {
                txtpass.PasswordChar = '*';
            }
        }

        private void btnsair_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnlogar_Click(object sender, EventArgs e) {
            if((txtpass.Text == "") || (txtuser.Text == "")) {
                MessageBox.Show("Por favor, preencha os campos de usuario e senha","Campos em Branco",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else {
                TentaLogin();
            }

        }

        private void TentaLogin() {
            string sql = "SELECT * FROM USUARIO WHERE USUNOME = '" + txtuser.Text + "'";
            try {
                Conexao.Active(true);
                FbCommand cmd = new FbCommand(sql, Conexao.FbCnn);
                FbDataReader dr = cmd.ExecuteReader();
                if (dr.Read()) {
                    login = dr["USUNOME"].ToString();
                    pass = dr["USUSENHA"].ToString();
                    acesso = dr["USUBLOQ"].ToString();
                    data = dr["USUDATA"].ToString();
                    qtde = dr["USUQTDE"].ToString();

                }

                if (!user.Equals(login)) {
                    user = login;
                    tentativas = 3;
                }
                //Inicia Comparações
                if(acesso == "S") {
                    MessageBox.Show("Conto bloqueada por motivos de segurança\n" +
                                    "Entre em contato com um usuario de nivel superior para solicitar o desbloqueio", "Conta Bloqueada",
                                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else {
                    //INICIA TESTE DE SENHAS
                    if (pass.Equals(txtpass.Text)) {
                        if (Convert.ToInt32((DateTime.Now - Convert.ToDateTime(data)).TotalDays) >= 30) {
                            if (Convert.ToInt32(qtde) <= 0) {
                                EfetuaBloqueio();
                            }
                            else {
                                int quantia = Convert.ToInt32(qtde);
                                quantia--;
                                MessageBox.Show("Faz 30 ou mais dias desde que sua senha foi modificada pela ultima vez.\n" +
                                                "Acesse o painel de manutenção de seu perfil e escolha uma nova senha assim que possivel.\n\n" +
                                                "Numero de Logins disponiveis antes do bloqueio da conta: " + quantia,"Senha expirada",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                                AtualizaQtde(quantia);
                                frmprincipal principal = new frmprincipal(login);
                                principal.ShowDialog();
                                this.Close();
                            }
                        }
                        else {
                            MessageBox.Show("Login efetuado com sucesso!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frmprincipal principal = new frmprincipal(login);
                            this.Hide();
                            principal.ShowDialog();
                            this.Close();

                        }
                    }
                    //LOGIN INCORRETO
                    else {
                        MessageBox.Show("Usuario e/ou senha incorretos!", "Erro Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tentativas--;
                        if(tentativas <= 0) {
                            //EFETUA BLOQUEIO
                            EfetuaBloqueio();
                        }
                    }
                }

            }//FIM TRY
            catch {
                MessageBox.Show("Usuario e/ou senha incorretos!", "Erro Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally {
                Conexao.Active(false);
            }
        }

        private void EfetuaBloqueio() {
            string sql = "UPDATE USUARIO SET USUBLOQ = 'S' WHERE USUNOME = '" + login + "'";
            Conexao.Active(true);
            try {
                FbCommand cmd = new FbCommand(sql, Conexao.FbCnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Conto bloqueada por motivos de segurança\n" +
                            "Entre em contato com um usuario de nivel superior para solicitar o desbloqueio", "Conta Bloqueada",
                             MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            Conexao.Active(false);
        }

        private void AtualizaQtde(int quantia) {
            string sql = "UPDATE USUARIO SET USUQTDE ="+ quantia +" WHERE USUNOME = '" + login + "'";
            Conexao.Active(true);
            try {
                FbCommand cmd = new FbCommand(sql, Conexao.FbCnn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            Conexao.Active(false);
        }

        private void frmlogin_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
            if (e.KeyCode == Keys.Escape) {
                this.Close();
            }
        }
        /**/
    }
}
