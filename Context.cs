using PAOO.Microunde;

namespace PAOO_Microunde
{
    public class Context : IObservable<Stare>
    {
        public static Stare stare_curenta;
        static IAfisajMicrounde afisare;
        static List<IObserver<Stare>> observers = new List<IObserver<Stare>>();
        public static Context Instance()
        {
            if (instance == null)
            {
                instance = new Context();
                afisare = MainWindow.GetInstance();
                stare_curenta = StareUsaInchisa.Instance();
            }
            return instance;
        }

        public int Timp_ramas
        { get; set; }
        private static Context instance;

        public void InchideUsa()
        {
            stare_curenta = StareUsaInchisa.Instance();
            afisare.setUsaInchisa();
            Notify();
        }
        public void DeschideUsa()
        {
            stare_curenta = StareUsaDeschisa.Instance();
            afisare.setUsaDeschisa();
            afisare.setGatesteOff();
            Notify();
        }

        public void Porneste()
        {
            stare_curenta = StareGatesteOn.Instance();
            afisare.setGatesteOn();
            Notify();
        }
        public void tickCeasContext()
        {
            if (Timp_ramas > 0)
            {
                Timp_ramas -= 1;
                afisare.setTimpRamas(Timp_ramas.ToString());
                Notify();
            }
            else
            {
                afisare.setGatesteOff();
                stare_curenta = StareUsaInchisa.Instance();
                Notify();
            }
        }

        public IDisposable Subscribe(IObserver<Stare> observer)
        {
            if (!observers.Contains(observer))
            {
                observers.Add(observer);
            }
                 
            return new Unsubscriber(observers, observer);
        }

        public void Notify()
        {
            foreach (IObserver<Stare> observerStare in observers)
            {
                observerStare.OnNext(stare_curenta);
            }
        }
    }
}
