using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing.Printing;

namespace CashInBox
{
    partial class ImprimirDocumento : PrintDocument
    {
        public List<string> texto { set; get; }
        public int numeroPagina { set; get; }
        public int offset { set; get; }


        public ImprimirDocumento(List<string> _doc)
        {
            this.texto = _doc;
        }
    }
}
