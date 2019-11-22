using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CashInBox
{
    class VerificarAcesso
    {
        static frmPrincipal frmPrincipalTeste = null;
        static frmMembro frmMembro = null;
        static frmFuncionario frmFuncionario = null;
        static frmPerfil frmPerfil = null;
        static frmUsuario frmUsuario = null;

        static Usuario usuario = new Usuario();

        public static void Verificar(Form f, int IdUsu)
        {
            usuario = UsuarioDAO.ProcurarUsuarioPorId(IdUsu);

            SetarValorForm(f);

            VerificarNulidadeEChamarVerificarAcesso();
            SetarNullNosForms();

        }

        private static void Acesso(frmPrincipal f, Usuario usuario)
        {
            foreach (ItemFuncionalidade x in usuario.Perfil.Items)
            {

                    if (x.Funcionalidade.Descricao.ToUpper().Contains("cadastro de funcionario".ToUpper()))
                    {
                        if (x.Alterar || x.Consultar || x.Incluir)
                        {
                            f.cmdFuncionario.Enabled = true;
                        }
                        else
                        {
                            f.cmdFuncionario.Enabled = false;
                        }
                    }
                    else
                    {
                        if (x.Funcionalidade.Descricao.ToUpper().Contains("cadastro de perfis".ToUpper()))
                        {
                            if (x.Alterar || x.Consultar || x.Incluir)
                            {
                                f.cmdPerfis.Enabled = true;
                                f.btnAcesso.Enabled = true;
                            }
                            else
                            {
                                f.cmdPerfis.Enabled = false;
                            }
                        }
                        else
                        {
                            if (x.Funcionalidade.Descricao.ToUpper().Contains("cadastro de usuario".ToUpper()))
                            {
                                if (x.Alterar || x.Consultar || x.Incluir)
                                {
                                    f.cmdUsuarios.Enabled = true;
                                    f.btnAcesso.Visible = true;
                                }
                                else
                                {
                                    f.cmdUsuarios.Enabled = false;
                                }
                            }
                            else
                            {


                                if (x.Funcionalidade.Descricao.ToUpper().Contains("cadastro de membro".ToUpper()))
                                {
                                    if (x.Alterar || x.Consultar || x.Incluir)
                                    {
                                        f.cmdMembro.Enabled = true;
                                    }
                                    else
                                    {
                                        f.cmdMembro.Enabled = false;
                                    }
                                }
                                else
                                {


                                    if (x.Funcionalidade.Descricao.ToUpper().Contains("ficha de cadastro de membro".ToUpper()))
                                    {
                                        if (x.Visualizar)
                                        {
                                            f.cmdRelFichaCadMembro.Enabled = true;
                                        }
                                        else
                                        {
                                            f.cmdRelFichaCadMembro.Enabled = false;
                                        }
                                    }

                                }

                            }
                        }
                    }
                }
        }
                                                        
        private static void Acesso(frmMembro f, Usuario usuario)
        {
            ItemFuncionalidade item = usuario.Perfil.Items.FirstOrDefault(x => x.Funcionalidade.Descricao.ToUpper().Contains("Membro".ToUpper()));


            if (item != null)
            {
                if (item.Incluir)
                {
                    f.btnNovo.Visible = true;
                }
                else
                {
                    f.btnNovo.Visible = false;
                }

                if (item.Alterar)
                {
                    f.btnEditar.Visible = true;
                }
                else
                {
                    f.btnEditar.Visible = false;
                }

                if (item.Consultar)
                {
                    f.btnConsultar.Visible = true;
                }
                else
                {
                    f.btnConsultar.Visible = false;
                }

                if (!item.Incluir && !item.Alterar)
                {
                    f.btnSalvar.Visible = false;
                }
                else
                {
                    f.btnSalvar.Visible = true;
                }

            }
        }

        private static void Acesso(frmFuncionario f, Usuario usuario)
        {
            ItemFuncionalidade item = usuario.Perfil.Items.FirstOrDefault(x => x.Funcionalidade.Descricao.ToUpper().Contains("funcionario".ToUpper()));

            if (item != null)
            {
                if (item.Incluir)
                {
                    f.btnNovo.Visible = true;
                }
                else
                {
                    f.btnNovo.Visible = false;
                }

                if (item.Alterar)
                {
                    f.btnEditar.Visible = true;
                }
                else
                {
                    f.btnEditar.Visible = false;
                }

                if (item.Consultar)
                {
                    f.btnConsultar.Visible = true;
                }
                else
                {
                    f.btnConsultar.Visible = false;
                }

                if (!item.Incluir && !item.Alterar)
                {
                    f.btnSalvar.Visible = false;
                }
                else
                {
                    f.btnSalvar.Visible = true;
                }

            }
        }

        private static void Acesso(frmPerfil f, Usuario usuario)
        {
            ItemFuncionalidade item = usuario.Perfil.Items.FirstOrDefault(x => x.Funcionalidade.Descricao.ToUpper().Contains("perfis".ToUpper()));

            if (item != null)
            {
                if (item.Incluir)
                {
                    f.btnNovo.Visible = true;
                }
                else
                {
                    f.btnNovo.Visible = false;
                }

                if (item.Alterar)
                {
                    f.btnEditar.Visible = true;
                }
                else
                {
                    f.btnEditar.Visible = false;
                }

                if (item.Consultar)
                {
                    f.grpCPerfil.Visible = true;
                }
                else
                {
                    f.grpCPerfil.Visible = false;
                }

                if (!item.Incluir && !item.Alterar)
                {
                    f.btnSalvar.Visible = false;
                }
                else
                {
                    f.btnSalvar.Visible = true;
                }

            }
        }

        private static void Acesso(frmUsuario f, Usuario usuario)
        {
            ItemFuncionalidade item = usuario.Perfil.Items.FirstOrDefault(x => x.Funcionalidade.Descricao.ToUpper().Contains("usuario".ToUpper()));

            if (item != null)
            {
                if (item.Incluir)
                {
                    f.btnNovo.Visible = true;
                }
                else
                {
                    f.btnNovo.Visible = false;
                }

                if (item.Alterar)
                {
                    f.btnEditar.Visible = true;
                }
                else
                {
                    f.btnEditar.Visible = false;
                }

                if (item.Consultar)
                {
                    f.grpCUsuario.Visible = true;
                }
                else
                {
                    f.grpCUsuario.Visible = false;
                }

                if (!item.Incluir && !item.Alterar)
                {
                    f.btnSalvar.Visible = false;
                }
                else
                {
                    f.btnSalvar.Visible = true;
                }

            }
        }


        private static void SetarValorForm(Form f)
        {
            if (f.Name.Equals("frmPrincipalTeste"))
            {
                frmPrincipalTeste = (frmPrincipal)f;
            }
            else
            {
                if (f.Name.Equals("frmMembro"))
                {
                    frmMembro = (frmMembro)f;
                }
                else
                {
                    if (f.Name.Equals("frmFuncionario"))
                    {
                        frmFuncionario = (frmFuncionario)f;
                    }
                    else
                    {
                        if (f.Name.Equals("frmPerfil"))
                        {
                            frmPerfil = (frmPerfil)f;
                        }
                        else
                        {
                            if (f.Name.Equals("frmUsuario"))
                                {
                                    frmUsuario = (frmUsuario)f;
                                }
                        }
                    }
                }
            }
        }


        private static void VerificarNulidadeEChamarVerificarAcesso()
        {
            if (frmPrincipalTeste != null)
            {
                Acesso(frmPrincipalTeste, usuario);
            }
            else
            {
                if (frmMembro != null)
                {
                    Acesso(frmMembro, usuario);
                }
                else
                {
                    if (frmFuncionario != null)
                    {
                        Acesso(frmFuncionario, usuario);
                    }
                    else
                    {
                        if (frmPerfil != null)
                        {
                            Acesso(frmPerfil, usuario);
                        }
                        else
                        {
                            if (frmUsuario != null)
                                {
                                    Acesso(frmUsuario, usuario);
                                }
                        }
                    }
                }
            }
        }


        private static void SetarNullNosForms()
        {
            frmPrincipalTeste = null;
            frmMembro = null;
            frmFuncionario = null;
            frmPerfil = null;;
            frmUsuario = null;

        }

    }
}
