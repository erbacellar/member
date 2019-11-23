using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;

namespace CashInBox
{
    public partial class frmLogar : Form
    {
        public bool testLogin = false;
        public string User;
        public bool deslogar = false;

        public frmLogar()
        {
            InitializeComponent();
        }

        //Evento de clicar no botao Entrar
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Usuario usu = new Usuario();

            //Verifica se os campos Usuario e Senha estao vazios
            if ((!txtUser.Text.Equals("") && !txtUser.Text.Equals("Username:")) && (!txtSenha.Text.Equals("") && !txtSenha.Text.Equals("Password:")))
            {
                if (txtUser.Text.Equals("admin"))
                {
                    if (txtSenha.Text.Equals(SenhaAdmin.Recuperar()))
                    {
                        User = "admin";
                        testLogin = true;
                        Close();
                    }
                    else
                    {
                        Mensagens.mensagemALERTA("Usuário ou senha incorreto(s)!. Verifique e tente novamente.");
                    }
                }
                else
                {
                    //usu = UsuarioDAO.ProcurarUsuarioPorLogin(txtUser.Text);

                    //Verifica se o objeto login trazido do banco
                    //é diferente de nulo
                    //se for da uma mensagem
                    if (usu == null)
                    {
                        MessageBox.Show("Usuário inválido", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtUser.Clear();
                        txtSenha.Clear();
                        txtUser.Focus();
                    }
                    else
                    {
                        //Verifica se a senha do objeto trazido do banco
                        //é igual a senha informada
                        if (!usu.Senha.Equals(txtSenha.Text))
                        {
                            MessageBox.Show("Senha incorreta", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtSenha.Clear();
                            txtSenha.Focus();
                        }
                        else
                        {
                            testLogin = true;

                            //if (UsuarioLogadoDAO.ObterPorLogin(usu.Login) == null)
                            //{
                            //    UsuarioLogado usuLogado = new UsuarioLogado();
                            //    usuLogado.Usuario = UsuarioDAO.ProcurarUsuarioPorLogin(usu.Login);
                            //    usuLogado.Ips = pegarIP();
                            //    usuLogado.Logado = true;
                            //    usuLogado.Versao = Versao.Obter();
                            //    UsuarioLogadoDAO.Incluir(usuLogado);
                            //}
                            //else
                            //{
                            //    UsuarioLogado usuLogado = UsuarioLogadoDAO.ObterPorLogin(usu.Login);
                            //    usuLogado.Ips = pegarIP();
                            //    usuLogado.Logado = true;

                            //    if (string.IsNullOrEmpty(usuLogado.Versao))
                            //    {
                            //        usuLogado.Versao = Versao.Obter();
                            //    }else
                            //    {
                            //        if (usuLogado.Versao != Versao.Obter())
                            //        {
                            //            usuLogado.Versao = Versao.Obter();
                            //        }
                            //    }

                            //    UsuarioLogadoDAO.Alterar(usuLogado);
                            //}

                            User = usu.Login;
                            Close();
                        }
                    }
                }

            }
            else
            {
                //Verifica se os campos Usuario e Senha estao vazios e da uma mensagem
                if ((txtUser.Text.Equals("") && txtSenha.Text.Equals("")) || (txtUser.Text.Equals("Username:") && txtSenha.Text.Equals("Password:")))
                {
                    MessageBox.Show("Informe usuário e senha válidos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                //Verifica se somente o campo Usuario esta vazio
                else if (txtUser.Text.Equals("") || txtUser.Text.Equals("Username:"))
                {
                    MessageBox.Show("Insira um usuário válido", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                //Verifica se somente o campo senha esta vazio
                else if (txtSenha.Text.Equals("") || txtSenha.Text.Equals("Password:"))
                {
                    MessageBox.Show("Insira uma senha válida", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }

        }

        //Evento de clicar no botao Sair
        private void btnCancel_Click(object sender, EventArgs e)
        {
            deslogar = false;
            Close();
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnEntrar_Click(sender, e);
            }
        }

        private void txtSenha_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (Utils.PressionarEnterCampoTexto(sender, e))
            {
                btnEntrar_Click(sender, e);
            }
        }

        private string pegarIP()
        {
            IPHostEntry he = Dns.GetHostByName(Dns.GetHostName());
            string ip = "";
            for (int i = 0; i < he.AddressList.Count(); i++)
            {
                ip += he.AddressList[i].ToString() + "\r\n";
            }

            return ip;
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUser.Text))
            {
                txtUser.Text = "Username:";
            }
        }

        private void txtSenha_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSenha.Text))
            {
                txtSenha.Text = "Password:";
                txtSenha.UseSystemPasswordChar = false;
            }
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text.Equals("Username:"))
            {
                txtUser.Text = "";
            }
        }

        private void txtSenha_Enter(object sender, EventArgs e)
        {
            if (txtSenha.Text.Equals("Password:"))
            {
                txtSenha.Text = "";
                txtSenha.UseSystemPasswordChar = true;
            }
        }

        private void btnEntrar_MouseEnter(object sender, EventArgs e)
        {
            btnEntrar.Focus();
        }

    }
}
