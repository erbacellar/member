using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CashInBox
{
    public partial class frmAbertura : Form
    {
        int time = 0;
        public frmAbertura()
        {
            InitializeComponent();

        }



        private void Form3_Load(object sender, EventArgs e)
        {
            try
            {
                Versao v = new Versao();
                lblVersao.Text = "Versão: " + v.Obter();
                Show();
                
                Usuario usuLoad = new Usuario();
                
                usuLoad = UsuarioDAO.ProcurarUsuarioPorId(0);
                
                Perfil perfil = new Perfil();
                
                perfil.Descricao = "lalala";
                
                perfil = PerfilDAO.obterPerfil(perfil.Descricao);
                
            }
            catch(Exception exc)
            {
 
            }
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Close();
        }

    }
}
