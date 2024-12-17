using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAOO.Microunde
{
    public interface IAfisaj_microunde
    {
        public void Set_gateste_OFF();
        public void Set_gateste_ON();
        public void Set_timp_ramas(int timp);
        public void Set_usa_deschisa();
        public void Set_usa_inchisa();
        public void Ticks();
    }
}
