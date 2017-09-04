using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;

namespace LES_17_I_M
{
    public partial class frmusuario : Form {

        string user = "", funcodi = "", usunivel = "";
        int nivel = 0;

        public frmusuario() {
            InitializeComponent();
        }

        public frmusuario(string getuser,int getnivel) {
            InitializeComponent();
            this.user = getuser;
            this.nivel = getnivel;
        }

        private void frmusuario_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
            if (e.KeyCode == Keys.Escape) {
                this.Close();
            }
        }

        private void frmusuario_Load(object sender, EventArgs e) {

            carregaFuncionario();
            carregaPerfis();
            carregaContas();
            liberaPermissoes();
        }


        //ABA CADASTRO
        private void carregaFuncionario() {
            string sql = "SELECT U.FUNCODI,FUNNOME FROM USUARIO U left join FUNCIONARIO F on U.FUNCODI = F.FUNCODI WHERE U.USUNOME = '" + user + "'";
            try {
                Conexao.Active(true);
                FbCommand cmd = new FbCommand(sql, Conexao.FbCnn);
                FbDataReader dr = cmd.ExecuteReader();
                if (dr.Read()) {
                    funcodi = dr["FUNCODI"].ToString();
                    txtfuncionario.Text = dr["FUNNOME"].ToString();
                }
            }
            finally {
                Conexao.Active(false);
            }
            DgvDados();
        }

        private void DgvDados() {
            Conexao.Active(true);
            try {
                DataTable dt = new DataTable();
                FbDataAdapter da = new FbDataAdapter("SELECT USUNOME,FUNNOME,USUNIVEL,USUDATA,USUQTDE from USUARIO U "
                                                    + "left join FUNCIONARIO F on U.FUNCODI = F.FUNCODI WHERE U.FUNCODI = " + funcodi, Conexao.FbCnn);
                da.Fill(dt);
                if (dt.Rows.Count > 0) {
                    dgvusuario.DataSource = dt;
                }
            }
            finally {
                Conexao.Active(false);
            }
        }

        private void chkmostrac_CheckedChanged(object sender, EventArgs e) {
            if (chkmostrac.Checked == true) {
                txtpass.PasswordChar = '\0';
                txtpass2.PasswordChar = '\0';
            }
            else {
                txtpass.PasswordChar = '*';
                txtpass2.PasswordChar = '*';

            }
        }

        private void btncadastro_Click(object sender, EventArgs e) {
            //BUSCA LOGINS IGUAIS
            string reglogin = "";
            string sql = "SELECT * from USUARIO WHERE USUNOME = '" + txtlogin.Text + "'";
            try {
                Conexao.Active(true);
                FbCommand cmd = new FbCommand(sql, Conexao.FbCnn);
                FbDataReader dr = cmd.ExecuteReader();
                if (dr.Read()) {
                    reglogin = dr["USUNOME"].ToString();
                }
            }
            finally {
                Conexao.Active(false);

            }

            if(reglogin == "") {
                if(verificaSenha()) {

                    //INSERÇÃO
                    string strIncluir = "INSERT INTO USUARIO(USUNOME,FUNCODI,USUSENHA,USUNIVEL,USUDATA,USUQTDE,USUBLOQ)"
                            + " VALUES('"
                            + txtlogin.Text + "', " + funcodi + ", '" + txtpass.Text + "', 10, '" + DateTime.Now.ToString("dd/MM/yyyy") + "', 10, 'N'"
                            + " )";
                    Conexao.Active(true);
                    try {
                        FbCommand cmd = new FbCommand(strIncluir, Conexao.FbCnn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Cadastro de conta efetuado com sucesso!\nFoi atribuido um nivel de permissão 10 para a nova conta.",
                                        "Sucesso",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        DgvDados();
                    }
                    catch (Exception ex) {
                        MessageBox.Show(ex.Message);
                    }
                    Conexao.Active(false);
                }
                //FIM INSERÇÃO  
            }
            else {
                MessageBox.Show("Nome de Usuario não disponivel.", "Usuario Indisponivel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtlogin.Clear();
                txtlogin.Focus();
            }

        }

        private bool verificaSenha() {

            //Verifica se as senha são iguais
            if (txtpass.Text != txtpass2.Text) {
                MessageBox.Show("As senhas digitadas não são iguais.", "Senhas diferentes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtpass.Clear();
                txtpass2.Clear();
                txtpass.Focus();
                return false;
            }

            //Verifica tamanho da senha
            if((txtpass.Text.Length < 6) || (txtpass.Text.Length > 10)) {
                MessageBox.Show("A senha deve conter no minimo 6 caracteres e no maximo 10 caracteres", "Formato senha", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtpass.Clear();
                txtpass2.Clear();
                txtpass.Focus();
                return false;
            }

            //Verifica condições da senha

            if ( (txtpass.Text.Any(char.IsUpper)) && (txtpass.Text.Any(char.IsLower)) && (txtpass.Text.Any(char.IsNumber)) 
                                                 && ( (txtpass.Text.Any(char.IsSymbol)) || (txtpass.Text.Any(char.IsPunctuation)) )){
                return true;
            }
            else {
                MessageBox.Show("A senha deve conter pelomenos:\n•Um caractere minusculo (a-z).\n•Um caractere maiusculo(A-Z)\n•Um numero(0-9)\n"
                               + "•Um simbolo Ex.(!@#$%¨&*()-+)", "Senha Padrão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtpass.Clear();
                txtpass2.Clear();
                txtpass.Focus();
                return false;
            }

        }

        private void btnlimpar_Click(object sender, EventArgs e) {
            txtlogin.Clear();
            txtpass.Clear();
            txtpass2.Clear();
            chkmostrac.Checked = false;
        }

        private void btnvoltarc_Click(object sender, EventArgs e) {
            this.Close();
        }

        //FIM ABA CADASTRO

        //INICIO ABA MANUTENÇÃO PERFIL
        private void carregaPerfis() {
            this.cboperfil.Items.Clear();
            string s = "Select * from USUARIO WHERE FUNCODI = "+ funcodi + " order by(USUNOME)";
            Conexao.Active(true);
            FbCommand cmd = new FbCommand(s, Conexao.FbCnn);
            FbDataReader r = cmd.ExecuteReader();

            Dictionary<string, string> p = new Dictionary<string, string>();
            while (r.Read()) {
                p.Add(r["usunome"].ToString(), r["usunome"].ToString());

            }
            this.cboperfil.DataSource = new BindingSource(p, null);
            this.cboperfil.DisplayMember = "key";
            this.cboperfil.ValueMember = "value";
            this.cboperfil.SelectedIndex = -1;
        }

        private void carregaContas() {
            tbcusuario.SelectedIndex = 0;
            this.cbousuario.Items.Clear();
            string s = "Select * from USUARIO WHERE USUNIVEL >= "+ nivel +"order by(usunome)";
            Conexao.Active(true);
            FbCommand cmd = new FbCommand(s, Conexao.FbCnn);
            FbDataReader r = cmd.ExecuteReader();

            Dictionary<string, string> p = new Dictionary<string, string>();
            while (r.Read()) {
                p.Add(r["usunome"].ToString(), r["usunome"].ToString());

            }
            this.cbousuario.DataSource = new BindingSource(p, null);
            this.cbousuario.DisplayMember = "key";
            this.cbousuario.ValueMember = "value";
            this.cbousuario.SelectedIndex = -1;
        }

        private void chkmostram_CheckedChanged(object sender, EventArgs e) {
            if (chkmostram.Checked == true) {
                txtantiga.PasswordChar = '\0';
                txtnova.PasswordChar = '\0';
                txtnovarepete.PasswordChar = '\0';
            }
            else {
                txtpass.PasswordChar = '*';
                txtpass2.PasswordChar = '*';
                txtnovarepete.PasswordChar = '*';

            }
        }

        private void btnsalvar_Click(object sender, EventArgs e) {
            string senha = "";

            string sql = "SELECT USUSENHA from USUARIO where USUNOME = '" + cboperfil.SelectedValue.ToString() + "'";
            try {
                Conexao.Active(true);
                FbCommand cmd = new FbCommand(sql, Conexao.FbCnn);
                FbDataReader dr = cmd.ExecuteReader();
                if (dr.Read()) {
                    senha = dr["USUSENHA"].ToString();
                }
            }
            finally {
                Conexao.Active(false);
            }
            if(senha != txtantiga.Text) {
                MessageBox.Show("A senha digitada não confere com a senha antiga.", "Senha incorreta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtantiga.Clear();
                txtantiga.Focus();
            }
            else {
                if (ValidarTrocaSenha()) {
                    string strAlterar = "UPDATE USUARIO"
                            + " SET USUSENHA = '" + txtnova.Text + "', "
                            + " USUDATA = '" + DateTime.Now.ToString("dd/MM/yyyy") + "', "
                            + " USUQTDE = 10"
                            + " WHERE USUNOME = '" + cboperfil.SelectedValue.ToString() + "'";
                    MessageBox.Show(strAlterar);
                    Conexao.Active(true);
                    try {
                        FbCommand cmd = new FbCommand(strAlterar, Conexao.FbCnn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Senha atualizada com sucesso!","Senha atualizada",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        DgvDados();
                    }
                    catch (Exception ex) {
                        MessageBox.Show(ex.Message);
                    }
                    Conexao.Active(false);
                }
            }

        }

        private bool ValidarTrocaSenha() {

            //VERIFICA SENHAS IGUAIS
            if(txtnova.Text != txtnovarepete.Text) {
                MessageBox.Show("As novas senhas digitadas não são iguais.", "Senhas diferentes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtnova.Clear();
                txtnovarepete.Clear();
                txtnova.Focus();
                return false;
            }

            //VERIFICA TAMANHO SENHA
            if ((txtnova.Text.Length < 6) || (txtnova.Text.Length > 10)) {
                MessageBox.Show("A nova senha deve conter no minimo 6 caracteres e no maximo 10 caracteres", "Formato senha", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtnova.Clear();
                txtnovarepete.Clear();
                txtnova.Focus();
                return false;
            }

            //VERIFICA PADRÃO SENHA
            if ((txtnova.Text.Any(char.IsUpper)) && (txtnova.Text.Any(char.IsLower)) && (txtnova.Text.Any(char.IsNumber))
                                                 && ((txtnova.Text.Any(char.IsSymbol)) || (txtnova.Text.Any(char.IsPunctuation)))) {
                return true;
            }
            else {
                MessageBox.Show("A senha deve conter pelomenos:\n•Um caractere minusculo (a-z).\n•Um caractere maiusculo(A-Z)\n•Um numero(0-9)\n"
                               + "•Um simbolo Ex.(!@#$%¨&*()-+)", "Senha Padrão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtnova.Clear();
                txtnovarepete.Clear();
                txtnova.Focus();
                return false;
            }
        }

        //FIM ABA MANUTENÇÃO PERFIL

        //INICIO ABA MANUTENÇÃO USUARIOS
        private void liberaPermissoes() {
            switch (nivel) {
                case 1:
                    rbgergeral.Visible = true;
                    rbgervendas.Visible = true;
                    rbgerfolha.Visible = true;
                    rbgerdados.Visible = true;
                    rbvendas.Visible = true;
                    rbfolha.Visible = true;
                    rbdados.Visible = true;
                    rbvendedor.Visible = true;
                    rbcomum.Visible = true;
                    btnsalvalt.Visible = true;
                    btnapagar.Visible = true;
                    break;
                case 2:
                    rbgergeral.Visible = true;
                    rbgervendas.Visible = true;
                    rbgerfolha.Visible = true;
                    rbgerdados.Visible = true;
                    rbvendas.Visible = true;
                    rbfolha.Visible = true;
                    rbdados.Visible = true;
                    rbvendedor.Visible = true;
                    rbcomum.Visible = true;
                    btnsalvalt.Visible = true;
                    btnapagar.Visible = true;
                    break;
                case 3:
                    rbgervendas.Visible = true;
                    rbgerfolha.Visible = true;
                    rbgerdados.Visible = true;
                    rbvendas.Visible = true;
                    rbfolha.Visible = true;
                    rbdados.Visible = true;
                    rbvendedor.Visible = true;
                    rbcomum.Visible = true;
                    btnsalvalt.Visible = true;
                    break;
                case 4:
                    rbgerfolha.Visible = true;
                    rbgerdados.Visible = true;
                    rbvendas.Visible = true;
                    rbfolha.Visible = true;
                    rbdados.Visible = true;
                    rbvendedor.Visible = true;
                    rbcomum.Visible = true;
                    btnsalvalt.Visible = true;
                    break;
                case 5:
                    rbgerdados.Visible = true;
                    rbvendas.Visible = true;
                    rbfolha.Visible = true;
                    rbdados.Visible = true;
                    rbvendedor.Visible = true;
                    rbcomum.Visible = true;
                    btnsalvalt.Visible = true;
                    break;
                default:
                    break;

            }
        }

        private void cbousuario_SelectionChangeCommitted(object sender, EventArgs e) {
            string bloq = "";
            string sql = "SELECT USUBLOQ,USUNIVEL FROM USUARIO WHERE USUNOME ='" + cbousuario.SelectedValue.ToString() + "'";
            try {
                Conexao.Active(true);
                FbCommand cmd = new FbCommand(sql, Conexao.FbCnn);
                FbDataReader dr = cmd.ExecuteReader();
                if (dr.Read()) {
                    bloq = dr["USUBLOQ"].ToString();
                    usunivel = dr["USUNIVEL"].ToString();
                }
            }
            finally {
                Conexao.Active(false);
            }

            if(bloq == "S") {
                btndesbloc.Visible = true;
            }
            else {
                btndesbloc.Visible = false;
            }

            selecionaNivel();
        }

        private void selecionaNivel() {
            switch (Convert.ToInt32(usunivel)) {
                case 2:
                    rbgergeral.Checked = true;
                    break;
                case 3:
                    rbgervendas.Checked = true;
                    break;
                case 4:
                    rbgerfolha.Checked = true;
                    break;
                case 5:
                    rbgerdados.Checked = true;
                    break;
                case 6:
                    rbvendas.Checked = true;
                    break;
                case 7:
                    rbfolha.Checked = true;
                    break;
                case 8:
                    rbdados.Checked = true;
                    break;
                case 9:
                    rbvendedor.Checked = true;
                    break;
                case 10:
                    rbcomum.Checked = true;
                    break;
            }
        }

        private void btnapagar_Click(object sender, EventArgs e) {
            string strDelete = "DELETE FROM USUARIO WHERE USUNOME = '" + cbousuario.SelectedValue.ToString() + "'";
            Conexao.Active(true);
            try {
                FbCommand cmd = new FbCommand(strDelete, Conexao.FbCnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Usuario excluido com sucesso!");
                DgvDados();
                cbousuario.SelectedIndex = -1;
                carregaContas();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            Conexao.Active(false);
        }

 

        private void btndesbloc_Click(object sender, EventArgs e) {
            string strAlterar = "UPDATE USUARIO"
                            + " SET USUQTDE = 1,"
                            + " USUBLOQ = 'N'"
                            + " WHERE USUNOME = '" + cbousuario.SelectedValue.ToString() + "'";
            Conexao.Active(true);
            try {
                FbCommand cmd = new FbCommand(strAlterar, Conexao.FbCnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Usuario Desbloqueado.\nA conta tera 1 acesso disponivel para a troca de senha.", "Usuario desbloqueado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DgvDados();
                btndesbloc.Visible = false;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            Conexao.Active(false);
        }

        private void btnsalvalt_Click(object sender, EventArgs e) {
            int changnivel = 0;
            if (rbcomum.Checked == true) {
                changnivel = 10;
            }
            else if(rbvendedor.Checked == true) {
                changnivel = 9;
            }
            else if(rbdados.Checked == true){
                changnivel = 8;
            }
            else if(rbfolha.Checked == true) {
                changnivel = 7;
            }
            else if(rbvendas.Checked == true) {
                changnivel = 6;
            }
            else if(rbgerdados.Checked == true) {
                changnivel = 5;
            }
            else if(rbgerfolha.Checked == true) {
                changnivel = 4;
            }
            else if(rbgervendas.Checked == true) {
                changnivel = 3;
            }
            else if(rbgergeral.Checked == true) {
                changnivel = 2;
            }

            string strAlterar = "UPDATE USUARIO"
                            + " SET USUNIVEL = " + changnivel
                            + " WHERE USUNOME = '" + cbousuario.SelectedValue.ToString() + "'";
            Conexao.Active(true);
            try {
                FbCommand cmd = new FbCommand(strAlterar, Conexao.FbCnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Permissão de usuario alterada!.", "Permissão alterada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DgvDados();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            Conexao.Active(false);
        }
        /**/
    }
}
