using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CashInBox
{
    class ValidaPlaca
    {
        public static bool IsPlaca(string placa)
        {

            Regex rg = new Regex(@"^[a-zA-Z]{3}[0-9]{4}$");

            if (rg.IsMatch(placa))
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
