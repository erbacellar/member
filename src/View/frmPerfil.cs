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
    public partial class frmPerfil : Form
    {
        Usuario usuario = new Usuario();

        public frmPerfil(String Login)
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

        private void frmPerfil_Load(object sender, EventArgs e)
        {
            if (!usuario.Login.Equals("admin"))
            {
                VerificarAcesso.Verificar(this, usuario.Id);
            }

            TreeNode ParentNode = new TreeNode();
            foreach (Funcionalidade funcionalidade in FuncionalidadeDAO.Listar())
            {
                GerarNodeChildPorFuncionalidade(ParentNode, funcionalidade.Descricao);
            }

            treFuncionalidades.Nodes.Add(ParentNode);
            EstadoInicial();
        }

        private void GerarNodeChildPorFuncionalidade(TreeNode parentNode, string funcionalidade)
        {
            TreeNode childNodeFuncionalidade = GerarConfigBasicosTreeNode(funcionalidade);
            childNodeFuncionalidade.Nodes.AddRange(GerarOpcoesBasicasFuncionalidade(childNodeFuncionalidade).ToArray());
            parentNode.Nodes.Add(childNodeFuncionalidade);
        }

        private List<TreeNode> GerarOpcoesBasicasFuncionalidade(TreeNode nodeFuncionalidade)
        {
            List<TreeNode> nodes = new List<TreeNode>();
            nodes.Add(GerarConfigBasicosTreeNode("Incluir"));
            nodes.Add(GerarConfigBasicosTreeNode("Alterar"));
            nodes.Add(GerarConfigBasicosTreeNode("Excluir"));
            nodes.Add(GerarConfigBasicosTreeNode("Consultar"));
            return nodes;
        }

        private TreeNode GerarConfigBasicosTreeNode(string nodeName)
        {
            TreeNode node = new TreeNode();
            node.Text = nodeName;
            node.ForeColor = Color.Black;
            node.BackColor = Color.White;
            node.ImageIndex = 0;
            node.SelectedImageIndex = 0;
            return node;
        }

        public void EstadoInicial()
        {
            DesmarcarTodasOpcoesTreeView();
            ContrairNodes();
            txtPerfil.Clear();
            Utils.Desabilitar(this);
            btnNovo.Enabled = true;
            btnEditar.Enabled = false;
            btnSalvar.Enabled = false;
            grdCPerfil.Enabled = true;
            grpCPerfil.Enabled = true;
            btnPesquisar.Enabled = true;
            txtCPerfil.Enabled = true;
        }

        public void EstadoAposConsulta()
        {
            Utils.Desabilitar(this);
            btnEditar.Enabled = true;
            btnSalvar.Enabled = false;
            grdCPerfil.Enabled = true;
            grpCPerfil.Enabled = true;
            btnPesquisar.Enabled = true;
            txtCPerfil.Enabled = true;
        }

        private void treFuncionalidades_AfterCheck(object sender, TreeViewEventArgs e)
        {
            // Se estiver marcado...
            if (e.Node.Checked)
            {
                // ... e tiver filhos...
                if (e.Node.Nodes.Count > 0)
                {
                    // ... marco todos
                    foreach (TreeNode tn in e.Node.Nodes)
                        if (!tn.Checked)
                            tn.Checked = true;
                }

                // ... se tiver pai, verifico se os outros
                // nós de mesmo nível estão marcados
                if (e.Node.Parent != null)
                {
                    bool ok = true;
                    foreach (TreeNode tn in e.Node.Parent.Nodes)
                    {
                        if (!tn.Checked)
                        {
                            ok = false;
                            break;
                        }
                    }

                    if (ok)
                    {
                        // para não criar um efeito cascata com o no pai
                        treFuncionalidades.AfterCheck -= new TreeViewEventHandler(this.treFuncionalidades_AfterCheck);
                        e.Node.Parent.Checked = true;
                        treFuncionalidades.AfterCheck += new TreeViewEventHandler(this.treFuncionalidades_AfterCheck);
                    }
                }
            }
            else
            {
                // se não estiver marcado e tiver pai...
                if (e.Node.Parent != null)
                {
                    // para não criar um efeito cascata com o no pai
                    treFuncionalidades.AfterCheck -= new TreeViewEventHandler(this.treFuncionalidades_AfterCheck);
                    e.Node.Parent.Checked = false;
                    treFuncionalidades.AfterCheck += new TreeViewEventHandler(this.treFuncionalidades_AfterCheck);
                }

                // desmarco os filhos
                if (e.Node.Nodes.Count > 0)
                {
                    foreach (TreeNode tn in e.Node.Nodes)
                        if (tn.Checked)
                            tn.Checked = false;
                }
            }

        }

        public String ValidarCamposObrigatorios()
        {
            String erros = null;

            if (txtPerfil.Text.Equals(""))
            {
                erros += "Campo nome do perfil deve ser preenchido\n";
                erroPerfilNome.Visible = true;
            }
            else
            {
                erroPerfilNome.Visible = false;
            }

            int nodeChecked = 0;

            foreach (TreeNode x in treFuncionalidades.Nodes)
            {
                foreach (TreeNode y in x.Nodes)
                {
                    if (y.Checked)
                    {
                        nodeChecked += 1;

                    }
                }
            }

            if (nodeChecked == 0)
            {
                erros += "Marque ao menos uma funcionalidade\n";
                erroFuncionalidade.Visible = true;
            }
            else
            {
                erroFuncionalidade.Visible = false;
            }

            nodeChecked = 0;

            return erros;

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            String erros = null;
            String tipoSalvar = null;
            Perfil per = new Perfil();

            if (txtId.Text.Equals(""))
            {
                per.Id = 0;
            }
            else
            {
                per.Id = int.Parse(txtId.Text);
            }
            if (ValidarCamposObrigatorios() == null)
            {
                /*
                 * If para inclusão de um cliente
                 */
                if (per.Id == 0)
                {
                    if (PerfilDAO.obterPerfil(txtPerfil.Text) == null)
                    {
                        tipoSalvar = "i";
                        IncluirAtualizarCadastro(tipoSalvar, per.Id);
                    }
                    else
                    {

                        Mensagens.mensagemALERTA("Já existe um perfil cadastrado com esta descrição!");

                    }
                }
                /*
                 * Else para alteração de um cliente
                 */
                else
                {
                    tipoSalvar = "a";
                    IncluirAtualizarCadastro(tipoSalvar, per.Id);
                }
            }
            else
            {
                erros = ValidarCamposObrigatorios();
                Mensagens.mensagemCamposObrigatorios();
            }
        }

        public void IncluirAtualizarCadastro(String acao, int id)
        {
            Perfil perfil = new Perfil();

            perfil.Id = id;
            if (acao.Equals("a"))
            {
                perfil = PerfilDAO.obterPerfil(perfil.Id);
            }

            List<ItemFuncionalidade> itens = new List<ItemFuncionalidade>();
            foreach (TreeNode x in treFuncionalidades.Nodes[0].Nodes)
            {

                bool nodeFilhoChecked = false;

                foreach (TreeNode c in x.Nodes)
                {
                    if (c.Checked)
                    {
                        nodeFilhoChecked = true;
                        break;
                    }
                }

                if (x.Checked || nodeFilhoChecked)
                {
                    ItemFuncionalidade item = new ItemFuncionalidade();

                    Funcionalidade funcio = new Funcionalidade();
                    funcio.Descricao = x.Text;
                    funcio = FuncionalidadeDAO.obterFuncionalidade(funcio);

                    item.Funcionalidade = funcio;

                    foreach (TreeNode y in x.Nodes)
                    {
                        if (y.Text.Equals("Incluir") && y.Checked)
                        {
                            item.Incluir = true;
                        }
                        else
                        {
                            if (y.Text.Equals("Incluir") && !y.Checked)
                            {
                                item.Incluir = false;
                            }
                        }
                        if (y.Text.Equals("Alterar") && y.Checked)
                        {
                            item.Alterar = true;
                        }
                        else
                        {
                            if (y.Text.Equals("Alterar") && !y.Checked)
                            {
                                item.Alterar = false;
                            }
                        }
                        if (y.Text.Equals("Consultar") && y.Checked)
                        {
                            item.Consultar = true;
                        }
                        else
                        {
                            if (y.Text.Equals("Consultar") && !y.Checked)
                            {
                                item.Consultar = false;
                            }
                        }
                        if (y.Text.Equals("Excluir") && y.Checked)
                        {
                            item.Excluir = true;
                        }
                        else
                        {
                            if (y.Text.Equals("Excluir") && !y.Checked)
                            {
                                item.Excluir = false;
                            }
                        }
                        if (y.Text.Equals("Imprimir") && y.Checked)
                        {
                            item.Imprimir = true;
                        }
                        else
                        {
                            if (y.Text.Equals("Imprimir") && !y.Checked)
                            {
                                item.Imprimir = false;
                            }
                        }
                        if (y.Text.Equals("Visualizar") && y.Checked)
                        {
                            item.Visualizar = true;
                        }
                        else
                        {
                            if (y.Text.Equals("Visualizar") && !y.Checked)
                            {
                                item.Visualizar = false;
                            }
                            else
                            {
                                if (x.Text.ToUpper().Equals("cadastro".ToUpper()))
                                {
                                    foreach (TreeNode t in x.Nodes)
                                    {
                                        ItemFuncionalidade itemRel = new ItemFuncionalidade();

                                        Funcionalidade funcioRel = new Funcionalidade();
                                        funcioRel.Descricao = t.Text;
                                        funcioRel = FuncionalidadeDAO.obterFuncionalidade(funcioRel);

                                        itemRel.Funcionalidade = funcioRel;

                                        if (t.Text.Equals("Incluir") && t.Checked)
                                        {
                                            itemRel.Incluir = true;
                                        }
                                        else
                                        {
                                            if (t.Text.Equals("Incluir") && !t.Checked)
                                            {
                                                itemRel.Incluir = false;
                                            }
                                        }
                                        if (t.Text.Equals("Alterar") && t.Checked)
                                        {
                                            itemRel.Alterar = true;
                                        }
                                        else
                                        {
                                            if (t.Text.Equals("Alterar") && !t.Checked)
                                            {
                                                itemRel.Alterar = false;
                                            }
                                        }
                                        if (t.Text.Equals("Consultar") && t.Checked)
                                        {
                                            itemRel.Consultar = true;
                                        }
                                        else
                                        {
                                            if (t.Text.Equals("Consultar") && !t.Checked)
                                            {
                                                itemRel.Consultar = false;
                                            }
                                        }
                                        if (t.Text.Equals("Excluir") && t.Checked)
                                        {
                                            itemRel.Excluir = true;
                                        }
                                        else
                                        {
                                            if (t.Text.Equals("Excluir") && !t.Checked)
                                            {
                                                itemRel.Excluir = false;
                                            }
                                        }
                                        itens.Add(itemRel);
                                    }
                                }
                                else
                                {
                                    if (x.Text.ToUpper().Equals("relatorios".ToUpper()))
                                    {
                                        foreach (TreeNode t in x.Nodes)
                                        {
                                            ItemFuncionalidade itemRel = new ItemFuncionalidade();

                                            Funcionalidade funcioRel = new Funcionalidade();
                                            funcioRel.Descricao = t.Text;
                                            funcioRel = FuncionalidadeDAO.obterFuncionalidade(funcioRel);

                                            itemRel.Funcionalidade = funcioRel;

                                            if (t.Checked)
                                            {
                                                itemRel.Visualizar = true;
                                            }
                                            else
                                            {
                                                itemRel.Visualizar = false;
                                            }
                                            itens.Add(itemRel);
                                        }
                                    }
                                    else
                                    {
                                        if (x.Text.ToUpper().Equals("graficos".ToUpper()))
                                        {
                                            foreach (TreeNode t in x.Nodes)
                                            {
                                                ItemFuncionalidade itemRel = new ItemFuncionalidade();

                                                Funcionalidade funcioRel = new Funcionalidade();
                                                funcioRel.Descricao = t.Text;
                                                funcioRel = FuncionalidadeDAO.obterFuncionalidade(funcioRel);

                                                itemRel.Funcionalidade = funcioRel;

                                                if (t.Checked)
                                                {
                                                    itemRel.Visualizar = true;
                                                }
                                                else
                                                {
                                                    itemRel.Visualizar = false;
                                                }
                                                itens.Add(itemRel);
                                            }
                                        }
                                    }
                                }
                            }
                        }

                    }
                    itens.Add(item);
                }
            }

            perfil.Items = itens;
            perfil.Descricao = txtPerfil.Text;

            if (acao.Equals("i"))
            {
                try
                {
                    PerfilDAO.Incluir(perfil);

                    grdCPerfil.Rows.Clear();
                    Mensagens.mensagemINFO_INCLUIR();
                    if (Mensagens.mensagemPERGUNTA_INCLUIR())
                    {
                        txtPerfil.Clear();
                        DesmarcarTodasOpcoesTreeView();
                        ContrairNodes();

                        txtPerfil.Focus();
                    }
                    else
                    {
                        EstadoInicial();
                    }

                }
                catch (Exception e)
                {
                    Mensagens.mensagemERRO_INCLUIR();

                    //SystemLog systemLog = new SystemLog();
                    //systemLog.Data = DateTime.Now;
                    //systemLog.Funcionario = usuario.Funcionario.Nome;
                    //systemLog.Tela = "Cadastro de Perfis";
                    //systemLog.Tipo = "Erro";

                    //systemLog.Descricao = "Ocorreu um erro ao tentar incluir. Erro: " + e.Message;

                    //SystemLogDAO.Incluir(systemLog);
                }
            }
            if (acao.Equals("a"))
            {
                Perfil perfilCopy = perfil;

                try
                {
                    PerfilDAO.Alterar(perfil);

                    //SystemLog systemLog = new SystemLog();
                    //systemLog.Data = DateTime.Now;
                    //systemLog.Funcionario = usuario.Funcionario.Nome;
                    //systemLog.Tela = "Cadastro de Perfis";
                    //systemLog.Tipo = "Alteração";

                    //String itemsDe = null;
                    //String itemsPara = null;
                    //foreach (ItemFuncionalidade x in perfilCopy.Items)
                    //{
                    //    itemsDe += "Funcionalidade: " + x.Funcionalidade.Descricao;
                    //    itemsDe += " com as funções: ";

                    //    if (x.Alterar)
                    //    {
                    //        itemsDe += "Alterar, ";
                    //    }
                    //    if (x.Consultar)
                    //    {
                    //        itemsDe += "Consultar, ";
                    //    }
                    //    if (x.Excluir)
                    //    {
                    //        itemsDe += "Excluir, ";
                    //    }
                    //    if (x.Incluir)
                    //    {
                    //        itemsDe += "Incluir, ";
                    //    }
                    //}

                    //foreach (ItemFuncionalidade x in perfil.Items)
                    //{
                    //    itemsPara += "Funcionalidade: " + x.Funcionalidade.Descricao;
                    //    itemsPara += " com as funções: ";

                    //    if (x.Alterar)
                    //    {
                    //        itemsPara += "Alterar, ";
                    //    }
                    //    if (x.Consultar)
                    //    {
                    //        itemsPara += "Consultar, ";
                    //    }
                    //    if (x.Excluir)
                    //    {
                    //        itemsPara += "Excluir, ";
                    //    }
                    //    if (x.Incluir)
                    //    {
                    //        itemsPara += "Incluir, ";
                    //    }
                    //}

                    //systemLog.Descricao = "Foi alterado o perfil de: " +
                    //    perfilCopy.Descricao + " " +
                    //    itemsDe + " para: " +
                    //    perfil.Descricao + " " +
                    //    itemsPara;

                    //SystemLogDAO.Incluir(systemLog);

                    grdCPerfil.Rows.Clear();
                    Mensagens.mensagemINFO_ALTERAR();
                    txtPerfil.Clear();
                    DesmarcarTodasOpcoesTreeView();
                    ContrairNodes();

                    EstadoInicial();

                }
                catch (Exception e)
                {
                    Mensagens.mensagemERRO_ALTERAR();

                    //SystemLog systemLog = new SystemLog();
                    //systemLog.Data = DateTime.Now;
                    //systemLog.Funcionario = usuario.Funcionario.Nome;
                    //systemLog.Tela = "Cadastro de Perfis";
                    //systemLog.Tipo = "Erro";

                    //systemLog.Descricao = "Ocorreu um erro ao tentar alterar. Erro: " + e.Message;

                    //SystemLogDAO.Incluir(systemLog);
                }

            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            grdCPerfil.Rows.Clear();

            if (txtCPerfil.Text.Equals(""))
            {

            }
            else
            {
                Perfil per = new Perfil();
                per.Descricao = txtCPerfil.Text;

                foreach (Perfil x in PerfilDAO.Listar(per))
                {
                    grdCPerfil.Rows.Add(x.Id, x.Descricao);
                }
            }
        }

        private void grdCPerfil_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DesmarcarTodasOpcoesTreeView();

                Perfil per = new Perfil();
                per.Id = int.Parse(grdCPerfil.CurrentRow.Cells[0].Value.ToString());
                per = PerfilDAO.obterPerfil(per.Id);

                txtId.Text = per.Id.ToString();
                txtPerfil.Text = per.Descricao;

                foreach (ItemFuncionalidade x in per.Items)
                {
                    foreach (TreeNode y in treFuncionalidades.Nodes)
                    {
                        if (x.Funcionalidade.Descricao.Equals(y.Text))
                        {
                            foreach (TreeNode n in y.Nodes)
                            {
                                if (n.Text.Equals("Incluir") && x.Incluir)
                                {
                                    n.Checked = true;
                                }
                                if (n.Text.Equals("Alterar") && x.Alterar)
                                {
                                    n.Checked = true;
                                }
                                if (n.Text.Equals("Consultar") && x.Consultar)
                                {
                                    n.Checked = true;
                                }
                                if (n.Text.Equals("Excluir") && x.Excluir)
                                {
                                    n.Checked = true;
                                }
                                if (n.Text.Equals("Imprimir") && x.Imprimir)
                                {
                                    n.Checked = true;
                                }
                                if (n.Text.Equals("Visualizar") && x.Visualizar)
                                {
                                    n.Checked = true;
                                }
                                if (y.Text.Equals("Cadastro"))
                                {
                                    foreach (TreeNode t in y.Nodes)
                                    {
                                        foreach (ItemFuncionalidade fun in per.Items)
                                        {
                                            if (t.Text.Equals(fun.Funcionalidade.Descricao) && fun.Alterar)
                                            {
                                                t.Checked = true;
                                            }
                                            else
                                            {
                                                if (t.Text.Equals(fun.Funcionalidade.Descricao) && fun.Consultar)
                                                {
                                                    t.Checked = true;
                                                }
                                                else
                                                {
                                                    if (t.Text.Equals(fun.Funcionalidade.Descricao) && fun.Excluir)
                                                    {
                                                        t.Checked = true;
                                                    }
                                                    else
                                                    {
                                                        if (t.Text.Equals(fun.Funcionalidade.Descricao) && fun.Incluir)
                                                        {
                                                            t.Checked = true;
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                                if (y.Text.Equals("Relatorios"))
                                {
                                    foreach (TreeNode t in y.Nodes)
                                    {
                                        foreach (ItemFuncionalidade fun in per.Items)
                                        {
                                            if (t.Text.Equals(fun.Funcionalidade.Descricao) && fun.Visualizar)
                                            {
                                                t.Checked = true;
                                            }
                                        }
                                    }
                                }
                                if (y.Text.Equals("Graficos"))
                                {
                                    foreach (TreeNode t in y.Nodes)
                                    {
                                        foreach (ItemFuncionalidade fun in per.Items)
                                        {
                                            if (t.Text.Equals(fun.Funcionalidade.Descricao) && fun.Visualizar)
                                            {
                                                t.Checked = true;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

                ContrairNodes();
                EstadoAposConsulta();
            }
            catch
            { }
        }

        public void DesmarcarTodasOpcoesTreeView()
        {
            foreach (TreeNode y in treFuncionalidades.Nodes)
            {
                y.Checked = false;

                foreach (TreeNode n in y.Nodes)
                {
                    n.Checked = false;
                }
            }
        }

        public void ContrairNodes()
        {
            bool nodeChecked = false;

            foreach (TreeNode x in treFuncionalidades.Nodes)
            {
                foreach (TreeNode y in x.Nodes)
                {
                    if (y.Checked)
                    {
                        nodeChecked = true;
                        break;
                    }
                    else
                    {
                        nodeChecked = false;
                    }
                }

                if (nodeChecked)
                {
                    x.Expand();
                }
                else
                {
                    x.Collapse();
                }
            }

        }

        private void txtCPerfil_KeyPress(object sender, KeyPressEventArgs e)
        {
            EventArgs eve = new EventArgs();
            if (Utils.PressionarEnterCampoTexto(sender, e))
            {
                btnPesquisar_Click(sender, eve);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Utils.Habilitar(this);
            btnSalvar.Enabled = true;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Utils.Habilitar(this);
            Utils.LimparCampos(this);
            DesmarcarTodasOpcoesTreeView();
            ContrairNodes();
            btnEditar.Enabled = false;
            btnSalvar.Enabled = true;
        }

        public void FocusInButton(object sender, EventArgs e)
        {
            KryptonButton b = sender as KryptonButton;
            b.Focus();
        }

    }
}
