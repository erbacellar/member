using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CashInBox
{
    class ValidaCEP
    {
        public static bool IsCep(string cep)
        {

            Regex rg = new Regex(@"^[0-9]{8}$");

            if (rg.IsMatch(cep))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
