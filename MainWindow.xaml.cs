using PAOO.Microunde;

namespace PAOO_Microunde
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : IAfisaj_microunde
    {
        static Context context;
        static MainWindow instance;
        public MainWindow()
        {
            InitializeComponent();
            instance = this;
            context = Context.Instance();
            StareUsa.Text = "Usa Inchisa";
            Ticks();
        }
        public static MainWindow getInstance()
        {
            return instance;
        }

        private void DeschideUsa(object sender, EventArgs e)
        {
            Context.stare_curenta.deschideUsa();
        }

        private void InchideUsa(object sender, EventArgs e)
        {
            Context.stare_curenta.inchideUsa();
        }

        private void Pornit(object sender, EventArgs e)
        {
            context.Timp_ramas += 30;
            setTimpRamas(context.getParsedTime());
            Context.stare_curenta.porneste();
        }

        async void Ticks()
        {
            while (true)
            {
                await (Task.Delay(1000));
                System.Diagnostics.Debug.WriteLine("A trecut 1 secunda!!!");
                //prelucrarile care se fac la fiecare secunda:
                //decrementarea ceasului si actualizarea afisarilor pe interfata
                Context.stare_curenta.Tick_ceas();
            }
        }

        //interface implementation
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
        public void errorUsa()
        {
            StareMicrounde.Text = "Oprit";
        }
    }
}