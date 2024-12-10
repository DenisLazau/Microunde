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
    public partial class MainWindow : Window
    {
        public int ticker = 0;
        public MainWindow()
        {
            Microunde microunde = new Microunde();
            InitializeComponent();
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            timer.Start();
            StareUsa.Text = "Usa Inchisa";
            StareMicrounde.Text = "Oprit";
            ticker = 0;
            Ticker.Text = ticker.ToString();
        }

        private void InchideUsa(object sender, RoutedEventArgs e)
        {
            StareUsa.Text = "Usa Inchisa";
        }

        private void DeschideUsa(object sender, RoutedEventArgs e)
        {
            StareUsa.Text = "Usa Deschisa";
            StareMicrounde.Text = "Oprit";
            Ticker.Text = ticker.ToString();
        }

        private void Pornit(object sender, RoutedEventArgs e)
        {
            if(StareUsa.Text == "Usa Inchisa")
            {
                StareMicrounde.Text = "Pornit";
                ticker = 30;
            }
        }

        void timer_Tick(object sender, EventArgs e)
        {
            if(ticker > 0)
            {
                ticker--;
                Ticker.Text = ticker.ToString();
            }
        }
    }
}