using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microunde
{
    public class Microunde
    {
        public Enums.StareUsa StareUsa
        { get; set; }

        public Enums.StareMicrounde StareMicrounde
        { get; set; }

        public int Ticker
        { get; set; }

        public Microunde()
        {
            StareUsa = Enums.StareUsa.Inchisa;
            StareMicrounde = Enums.StareMicrounde.Oprit;
            Ticker = 0;
        }

        public void InchideUsa()
        {
            StareUsa = Enums.StareUsa.Inchisa;
        }

        public void DeschideUsa()
        {
            StareUsa = Enums.StareUsa.Deschisa;
            StareMicrounde = Enums.StareMicrounde.Oprit;
            Ticker = 0;
        }

        public void Pornit()
        {
            if (StareUsa == Enums.StareUsa.Inchisa)
            {
                StareMicrounde = Enums.StareMicrounde.Pornit;
            }
        }
    }
}
