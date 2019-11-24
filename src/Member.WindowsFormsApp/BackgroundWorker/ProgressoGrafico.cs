using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CashInBox
{
    public partial class ProgressoGrafico : Form
    {
        private bool _allowClose = false;

        public ProgressoGrafico()
        {
            InitializeComponent();
        }

        private void Progresso_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing & _allowClose)
                e.Cancel = true;
        }

        public void ForceClose()
        {
            _allowClose = true;
            Close();
            _allowClose = false;
        }
    }
}