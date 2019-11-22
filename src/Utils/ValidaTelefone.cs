using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CashInBox
{
    class ValidaTelefone
    {
        public static bool IsTel(string tel)
        {

            Regex rg = new Regex(@"^[0-9]{10}|[0-9]{11}$");

            if (rg.IsMatch(tel))
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
