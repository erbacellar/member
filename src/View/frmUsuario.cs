using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace CashInBox
{
    public partial class frmUsuario : Form
    {
        Usuario usuario = new Usuario();

        public frmUsuario()
        {
            InitializeComponent();
        }

        public frmUsuario(String Login)
        {
            InitializeComponent();

            if (!Login.Equals("admin"))
            {
                usuario = UsuarioDAO.ProcurarUsuarioPorLogin(Login);
            }
            else
            {
                usuario.Login = "admin";
            }
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            if (!usuario.Login.Equals("admin"))
            {
                VerificarAcesso.Verificar(this, usuario.Id);
            }

            foreach (Funcionario x in FuncionarioDAO.ObterFuncionarios())
            {
                cboFuncionario.Items.Add(x.Nome);
            }

            cboFuncionario.SelectedIndex = -1;

            EstadoInicial();

            foreach (Perfil x in PerfilDAO.Listar())
            {
                if (!usuario.Login.Equals("admin"))
                {
                    if (usuario.Perfil.Descricao.Equals("SUPERADMIN"))
                    {
                        cboPerfil.Items.Add(x.Descricao);
                    }
                    else
                    {
                        if (!x.Descricao.Equals("SUPERADMIN"))
                        {
                            cboPerfil.Items.Add(x.Descricao);
                        }
                    }
                }
                else
                {
                    cboPerfil.Items.Add(x.Descricao);
                }
            }

            foreach (Funcionario x in FuncionarioDAO.ObterFuncionarios())
            {
                cboFuncionario.Items.Add(x.Nome);
            }
        }

        public void checarSenha(object sender, EventArgs e)
        {
            TextBox t = sender as TextBox;

            int i = 0;

            PasswordScore score = ChecarForcaSenha.CheckStrength(t.Text);

            i = (int)score;

            switch (i)
            {
                case 0:
                    txtForca1.BackColor = Color.White;
                    txtForca2.BackColor = Color.White;
                    txtForca3.BackColor = Color.White;
                    txtForca4.BackColor = Color.White;
                    txtForca5.BackColor = Color.White;

                    lblForcaSenha.Text = "Senha Vazia";
                    break;

                case 1:
                    txtForca1.BackColor = Color.DarkRed;
                    txtForca2.BackColor = Color.White;
                    txtForca3.BackColor = Color.White;
                    txtForca4.BackColor = Color.White;
                    txtForca5.BackColor = Color.White;

                    lblForcaSenha.Text = "Senha Muito Fraca";

                    break;

                case 2:
                    txtForca1.BackColor = Color.Red;
                    txtForca2.BackColor = Color.Red;
                    txtForca3.BackColor = Color.White;
                    txtForca4.BackColor = Color.White;
                    txtForca5.BackColor = Color.White;

                    lblForcaSenha.Text = "Senha Fraca";

                    break;

                case 3:
                    txtForca1.BackColor = Color.Yellow;
                    txtForca2.BackColor = Color.Yellow;
                    txtForca3.BackColor = Color.Yellow;
                    txtForca4.BackColor = Color.White;
                    txtForca5.BackColor = Color.White;

                    lblForcaSenha.Text = "Senha Média";

                    break;

                case 4:
                    txtForca1.BackColor = Color.Green;
                    txtForca2.BackColor = Color.Green;
                    txtForca3.BackColor = Color.Green;
                    txtForca4.BackColor = Color.Green;
                    txtForca5.BackColor = Color.White;

                    lblForcaSenha.Text = "Senha Forte";

                    break;

                case 5:
                    txtForca1.BackColor = Color.DarkGreen;
                    txtForca2.BackColor = Color.DarkGreen;
                    txtForca3.BackColor = Color.DarkGreen;
                    txtForca4.BackColor = Color.DarkGreen;
                    txtForca5.BackColor = Color.DarkGreen;

                    lblForcaSenha.Text = "Senha Muito Forte";

                    break;
            }
        }

        private void txtConfirmarSenha_Leave(object sender, EventArgs e)
        {
            if (!txtConfirmarSenha.Text.Equals(""))
            {
                if (!txtConfirmarSenha.Text.Equals(txtSenha.Text))
                {
                    Mensagens.mensagemALERTA("Campo CONFIRMA SENHA precisa ser igual ao campo SENHA!");
                    txtConfirmarSenha.Clear();
                }
            }
        }

        public void EsconderErros()
        {
            erroFuncionario.Visible = false;
            erroLogin.Visible = false;
            erroPerfil.Visible = false;
            erroSenha.Visible = false;
        }

        public void EstadoInicial()
        {
            EsconderErros();

            txtForca1.BackColor = Color.White;
            txtForca2.BackColor = Color.White;
            txtForca3.BackColor = Color.White;
            txtForca4.BackColor = Color.White;
            txtForca5.BackColor = Color.White;

            lblForcaSenha.Text = "Senha Vazia";

            Utils.Desabilitar(this);
            Utils.LimparCampos(this);
            grpCUsuario.Enabled = true;
            txtCUsuario.Enabled = true;
            grdCUsuario.Enabled = true;
            btnNovo.Enabled = true;
            btnSalvar.Enabled = false;
            btnEditar.Enabled = false;
            btnPesquisar.Enabled = true;
        }

        private void PonteiroInicialMascara(object sender, EventArgs e)
        {
            Utils.PonteiroInicialMascara(sender);
        }

        private void FocusInTextMask(object sender, EventArgs e)
        {
            Utils.FocusInTextMask(sender);
        }

        private void FocusOutTextMask(object sender, EventArgs e)
        {
            Utils.FocusOutTextMask(sender);
        }

        private void FocusInCombo(object sender, EventArgs e)
        {
            Utils.FocusInCombo(sender);
        }

        private void FocusOutCombo(object sender, EventArgs e)
        {
            Utils.FocusOutCombo(sender);
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            Utils.LimparCampos(this);
            btnSalvar.Enabled = true;
            btnEditar.Enabled = false;
        }

        public String ValidarCamposObrigatorios()
        {
            String erros = null;

            if (cboFuncionario.SelectedIndex == -1)
            {
                erros += "Campo Funcionario deve ser selecionado\n";
                erroFuncionario.Visible = true;
            }
            else
            {
                erroFuncionario.Visible = false;
            }

            if (cboPerfil.SelectedIndex == -1)
            {
                erros += "Campo Perfil deve ser selecionado\n";
                erroPerfil.Visible = true;
            }
            else
            {
                erroPerfil.Visible = false;
            }


            if (txtLogin.Text.Equals(""))
            {
                erros += "Campo Login devem ser preenchidos\n";
                erroLogin.Visible = true;
            }
            else
            {
                erroLogin.Visible = false;
            }

            if (txtSenha.Text.Equals(""))
            {
                erros += "Campo Senha devem ser preenchidos\n";
                erroSenha.Visible = true;
            }
            else
            {
                erroSenha.Visible = false;
            }


            return erros;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            String erros = null;
            String tipoSalvar = null;
            Usuario usu = new Usuario();

            if (txtCodigo.Text.Equals(""))
            {
                usu.Id = 0;
            }
            else
            {
                usu.Id = int.Parse(txtCodigo.Text);
            }
            if (ValidarCamposObrigatorios() == null)
            {
                if (lblForcaSenha.Text.Equals("Senha Média") || lblForcaSenha.Text.Equals("Senha Forte") || lblForcaSenha.Text.Equals("Senha Muito Forte"))
                {
                    if (!txtConfirmarSenha.Text.Equals(""))
                    {
                        /*
                         * If para inclusão de um Usuário
                         */
                        if (usu.Id == 0)
                        {

                            if (UsuarioDAO.ProcurarUsuarioPorLogin(txtLogin.Text) == null)
                            {
                                tipoSalvar = "i";
                                IncluirAtualizarCadastro(tipoSalvar, usu.Id);
                            }
                            else
                            {
                                Mensagens.mensagemALERTA("Usuário já cadastrado com este Login!");
                            }

                        }
                        /*
                         * Else para alteração de um Usuário
                         */
                        else
                        {
                            tipoSalvar = "a";
                            IncluirAtualizarCadastro(tipoSalvar, usu.Id);
                        }
                    }
                    else
                    {
                        Mensagens.mensagemALERTA("Campo CONFIRMAR SENHA precisa ser igual ao campo SENHA");
                    }
                }
                else
                {
                    Mensagens.mensagemALERTA("Força de senha precisa ser no mínimo MÉDIA");
                }
            }
            else
            {
                erros = ValidarCamposObrigatorios();
                Mensagens.mensagemCamposObrigatorios();
            }

        }

        public void IncluirAtualizarCadastro(String x, int id)
        {
            Usuario usu = new Usuario();

            usu.Id = id;
            if (x.Equals("a"))
            {
                usu = UsuarioDAO.ProcurarUsuarioPorId(id);
            }

            Funcionario funcionario = FuncionarioDAO.ProcurarFuncionarioPorNome(cboFuncionario.SelectedItem.ToString());

            usu.Funcionario = funcionario;

            Perfil perfil = new Perfil();
            perfil.Descricao = cboPerfil.SelectedItem.ToString();
            perfil = PerfilDAO.obterPerfil(perfil.Descricao);

            usu.Perfil = perfil;
            
            usu.Login = txtLogin.Text;
            usu.Senha = txtConfirmarSenha.Text;


            if (x.Equals("i"))
            {
                if (UsuarioDAO.Incluir(usu))
                {
                    grdCUsuario.Rows.Clear();
                    Mensagens.mensagemINFO_INCLUIR();
                    if (Mensagens.mensagemPERGUNTA_INCLUIR())
                    {
                        Utils.LimparCampos(this);
                        cboFuncionario.Focus();
                    }
                    else
                    {
                        EstadoInicial();
                    }
                }
                else
                {
                    Mensagens.mensagemERRO_INCLUIR();
                }
            }
            if (x.Equals("a"))
            {
                if (UsuarioDAO.Alterar(usu))
                {
                    grdCUsuario.Rows.Clear();
                    Mensagens.mensagemINFO_ALTERAR();
                    EstadoInicial();
                }
                else
                {
                    Mensagens.mensagemERRO_ALTERAR();
                }
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            grdCUsuario.Rows.Clear();

            if (txtCUsuario.Text.Equals(""))
            {
                Mensagens.mensagemALERTA("Informe parte do nome, perfil ou login para pesquisar Usuários");
            }
            else
            {
                Usuario usuConsulta = new Usuario();
                usuConsulta.Login = txtCUsuario.Text;

                Perfil perfil = new Perfil();
                perfil.Descricao = txtCUsuario.Text;
                usuConsulta.Perfil = perfil;

                Funcionario func = new Funcionario();
                func.Nome = txtCUsuario.Text;
                usuConsulta.Funcionario = func;

                foreach (Usuario x in UsuarioDAO.ObterUsuariosPorParcial(usuConsulta))
                {
                    if (usuario.Perfil.Descricao.Equals("SUPERADMIN"))
                    {
                        grdCUsuario.Rows.Add(x.Id,x.Perfil.Descricao, x.Login, x.Funcionario.Nome);
                    }
                    else
                    {
                        if (!x.Perfil.Descricao.Equals("SUPERADMIN"))
                        {
                            grdCUsuario.Rows.Add(x.Id, x.Perfil.Descricao, x.Login, x.Funcionario.Nome);
                        }
                    }
                }
            }
        }

        private void grdCUsuario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Usuario usu = UsuarioDAO.ProcurarUsuarioPorId(int.Parse(grdCUsuario.CurrentRow.Cells[0].Value.ToString()));

                txtCodigo.Text = usu.Id.ToString();
                txtLogin.Text = usu.Login;
                txtSenha.Text = usu.Senha;
                txtConfirmarSenha.Text = usu.Senha;
                cboFuncionario.SelectedItem = usu.Funcionario.Nome;
                cboPerfil.SelectedItem = usu.Perfil.Descricao;

                Utils.Desabilitar(this);
                btnNovo.Enabled = true;
                btnEditar.Enabled = true;
                btnSalvar.Enabled = false;
                grpCUsuario.Enabled = true;
                txtCUsuario.Enabled = true;
                grdCUsuario.Enabled = true;
                btnPesquisar.Enabled = true;
            }
            catch
            {
                Mensagens.mensagemALERTA("Selecione uma linha com dados");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Utils.Habilitar(this);
            btnSalvar.Enabled = true;
        }

        private void txtCUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Utils.PressionarEnterCampoTexto(sender, e))
            {
                btnPesquisar_Click(sender, e);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void FocusInButton(object sender, EventArgs e)
        {
            KryptonButton b = sender as KryptonButton;
            b.Focus();
        }
    }
}
