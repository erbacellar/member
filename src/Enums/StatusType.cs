using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashInBox.Enums
{
    public enum StatusType
    {
        [Description("Ativo")]
        ATIVO = 0,
        [Description("INATIVO")]
        INATIVO = 1,
    }
}
