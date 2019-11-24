using System;
using System.Threading;
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
            Versao v = new Versao();
            lblVersao.Text = "Versão: " + v.Obter();
            Show();

            Thread.Sleep(1000);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Close();
        }

    }
}
