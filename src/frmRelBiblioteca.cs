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
    public partial class frmRelBiblioteca : Form
    {
        public frmRelBiblioteca()
        {
            InitializeComponent();
        }

        private void frmRelBiblioteca_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsMembros.Membros' table. You can move, or remove it, as needed.
            this.RelatorioBibliotecaTableAdapter.Fill(this.dsRelatorioBiblioteca.RelatorioBiblioteca);

            this.rptRelatorioBiblioteca.RefreshReport();
        }

        private void frmRelBiblioteca_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.rptRelatorioBiblioteca.Dispose();
        }
    }
}
