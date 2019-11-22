using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CashInBox
{
    class GridConsultarFechamentoCaixa
    {
        public int Id { set; get; }
        public DateTime Data { set; get; }
        public float TotalLiquido { set; get; }
        public string Unidade { set; get; }
    }
}
