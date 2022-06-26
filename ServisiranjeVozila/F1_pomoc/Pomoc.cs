using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F1_pomoc
{
    public class Pomoc
    {
        public void OtvoriPomocKorisnik(Form forma, string dio)
        {
            Help.ShowHelp(forma, @"..\..\Resources\pomocKorisnik.chm", dio);
        }

        public void OtvoriPomocDjelatnik(Form forma, string dio)
        {
            Help.ShowHelp(forma, @"..\..\Resources\pomocZaposlenik.chm", dio);
        }
    }
}
