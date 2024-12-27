using PAOO.Microunde;

namespace PAOO_Microunde
{
    public partial class MainWindow : IAfisajMicrounde, IObserver<Stare>
    {
        static Context microunde;
        static MainWindow instance;
        private IDisposable subscriber;
        public MainWindow()
        {
            InitializeComponent();
            instance = this;
            microunde = Context.Instance();
            Subscribe(microunde);
            StareUsa.Text = "Usa Inchisa";
            StareMicrounde.Text = "Oprit";
            Ticks();
        }
        public static MainWindow GetInstance()
        {
            return instance;
        }

        private void DeschideUsa(object sender, EventArgs e)
        {
            Context.stare_curenta.DeschideUsa();
        }

        private void InchideUsa(object sender, EventArgs e)
        {
            Context.stare_curenta.InchideUsa();
        }

        private void Pornit(object sender, EventArgs e)
        {
            Context.stare_curenta.Porneste();
        }

        async void Ticks()
        {
            while (true)
            {
                await (Task.Delay(1000));
                System.Diagnostics.Debug.WriteLine("A trecut 1 secunda!!!");
                Context.stare_curenta.Tick_ceas();
            }
        }

        public void setTimpRamas(string afis)
        {
            Ticker.Text = afis;
        }

        public void setUsaDeschisa()
        {
            StareUsa.Text = "Usa Deschisa";
        }

        public void setUsaInchisa()
        {
            StareUsa.Text = "Usa Inchisa";
        }

        public void setGatesteOff()
        {
            StareMicrounde.Text = "Oprit";
        }

        public void setGatesteOn()
        {
            StareMicrounde.Text = "Pornit";
        }

        public virtual void Subscribe(IObservable<Stare> context)
        {
           subscriber = context.Subscribe(this);
        }
        public virtual void Unsubscribe()
        {
            subscriber.Dispose();
        }


        public void OnCompleted()
        {
            ((IObserver<Stare>)instance).OnCompleted();
        }

        public void OnError(Exception error)
        {
            ((IObserver<Stare>)instance).OnError(error);
        }

        public void OnNext(Stare value)
        {
            if (value.GetType() == typeof(StareGatesteOn))
            {
                setGatesteOn();
                setTimpRamas(microunde.Timp_ramas.ToString());
                if (microunde.Timp_ramas == 0)
                {
                    setGatesteOff();
                }
            }
            else if (value.GetType() == typeof(StareUsaDeschisa))
            {
                setTimpRamas(microunde.Timp_ramas.ToString());
                setGatesteOff();
                setUsaDeschisa();
            }
            else if (value.GetType() == typeof(StareUsaInchisa))
            {
                setUsaInchisa();
            }
        }
    }
}