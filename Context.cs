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
                afisare = MainWindow.getInstance();
                stare_curenta = Stare_USA_INCHISA.Instance();
            }
            return instance;
        }

        public int Timp_ramas
        { get => timp_ramas; set => timp_ramas = value; }
        //singleton
        private static Context instance = null;

        public void inchideUsaContext()
        {
            stare_curenta = Stare_USA_INCHISA.Instance();
            afisare.setUsaInchisa();
        }
        public void deschideUsaContext()
        {
            stare_curenta = Stare_USA_DESCHISA.Instance();
            afisare.setUsaDeschisa();
        }
        public void displayErrorUsa()
        {
            afisare.errorUsa();
        }

        public void pornesteContext()
        {
            stare_curenta = Stare_GATESTE_ON.Instance();
            afisare.setGatesteOn();
        }
        public void tickCeasContext()
        {
            if (Timp_ramas > 0)
            {
                Timp_ramas -= 1;
                afisare.setTimpRamas(getParsedTime());
            }
            else
            {
                afisare.setGatesteOff();
                stare_curenta = Stare_USA_INCHISA.Instance();
            }
        }
        public string getParsedTime()
        {
            int min, sec;
            min = Timp_ramas / 60;
            sec = Timp_ramas % 60;
            string af = "";
            if (min < 10)
                af = "0" + min + ":";
            else
                af = min + ":";
            if (sec < 10)
            {
                af = af + "0" + sec;
            }
            else
                af = af + sec;
            return af;

        }

    }
}
