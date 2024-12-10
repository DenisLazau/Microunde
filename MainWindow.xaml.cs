using PAOO.Microunde;

using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace PAOO_Microunde
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IAfisaj_microunde
    {
        public Microunde microunde;
        public MainWindow()
        {
            microunde = new Microunde(this);
            InitializeComponent();
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            timer.Start();
        }

        private void InchideUsa(object sender, RoutedEventArgs e)
        {
            microunde.InchideUsa();
        }

        private void DeschideUsa(object sender, RoutedEventArgs e)
        {
            microunde.DeschideUsa();
        }

        private void Pornit(object sender, RoutedEventArgs e)
        {
            microunde.Pornit();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            Ticks();
        }

        public void Deschide_usa_Click()
        {
            throw new NotImplementedException();
        }

        public void Gateste_ON_Click()
        {
            throw new NotImplementedException();
        }

        public void Inchide_usa_Click()
        {
            throw new NotImplementedException();
        }

        void IAfisaj_microunde.MainWindow()
        {
            throw new NotImplementedException();
        }

        public void Set_gateste_OFF()
        {
            StareMicrounde.Text = "Oprit";
        }

        public void Set_gateste_ON()
        {
            StareMicrounde.Text = "Pornit";
        }

        public void Set_timp_ramas(int timp)
        {
            Ticker.Text = timp.ToString();
        }

        public void Set_usa_deschisa()
        {
            StareUsa.Text = "Usa Deschisa";
        }

        public void Set_usa_inchisa()
        {
            StareUsa.Text = "Usa Inchisa";
        }

        public void Ticks()
        {
            microunde.Ticks();
        }
    }
}