using PAOO.Microunde;

namespace PAOO_Microunde
{
    public class Context
    {
        int timp_ramas = 0;
        public static Stare stare_curenta;
        static IAfisaj_microunde afisare;
        public static Context Instance()
        {
            if (instance == null)
            {
                instance = new Context();
                afisare = MainWindow.GetInstance();
                stare_curenta = Stare_USA_INCHISA.Instance();
            }
            return instance;
        }

        public int Timp_ramas
        { get => timp_ramas; set => timp_ramas = value; }
        private static Context instance;

        public void InchideUsa()
        {
            stare_curenta = Stare_USA_INCHISA.Instance();
            afisare.setUsaInchisa();
        }
        public void DeschideUsa()
        {
            stare_curenta = Stare_USA_DESCHISA.Instance();
            afisare.setUsaDeschisa();
            afisare.setGatesteOff();
        }

        public void Porneste()
        {
            stare_curenta = Stare_GATESTE_ON.Instance();
            afisare.setGatesteOn();
        }
        public void tickCeasContext()
        {
            if (Timp_ramas > 0)
            {
                Timp_ramas -= 1;
                afisare.setTimpRamas(Timp_ramas.ToString());
            }
            else
            {
                afisare.setGatesteOff();
                stare_curenta = Stare_USA_INCHISA.Instance();
            }
        }
    }
}
