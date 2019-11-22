using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.IO;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace CashInBox
{
    class ConfigImpressora
    {
        [DllImport("Winspool.drv")]
        private static extern bool SetDefaultPrinter(string printerName);

        public static void Executar(string nomeImpressora)
        {
            SetDefaultPrinter(nomeImpressora);
        }

        
    }
}
