using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashInBox
{
    public partial class frmSelecionarTipoAcesso : Form
    {
        public string tipo;
        public frmSelecionarTipoAcesso()
        {
            InitializeComponent();
        }

        private void frmSelecionarTipoAcesso_Load(object sender, EventArgs e)
        {
            cboTipo.Items.Add("Interno");
            cboTipo.Items.Add("Externo");

            cboTipo.SelectedIndex = 0;
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            tipo = cboTipo.SelectedItem.ToString();
            Close();
        }

        private void btnSelecionar_MouseEnter(object sender, EventArgs e)
        {
            btnSelecionar.Focus();
        }

        private void cboTipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnSelecionar_Click(sender, e);
            }
        }
    }
}
