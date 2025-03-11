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

namespace desktopowa
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public bool czymaleiwielkielitery = false;
        public bool czycyfry = false;
        public bool czyznakispecjalne = false;

        private void checkmaleiwielkielitery_Checked(object sender, RoutedEventArgs e)
        {
            czymaleiwielkielitery = true;
        }

        private void checkmaleiwielkielitery_Unchecked(object sender, RoutedEventArgs e)
        {
            czymaleiwielkielitery = false;
        }

        private void checkcyfry_Checked(object sender, RoutedEventArgs e)
        {
            czycyfry = true;
        }

        private void checkcyfry_Unchecked(object sender, RoutedEventArgs e)
        {
            czycyfry = false;
        }

        private void checkznakispecjalne_Checked(object sender, RoutedEventArgs e)
        {
            czyznakispecjalne = true;
        }

        private void checkznakispecjalne_Unchecked(object sender, RoutedEventArgs e)
        {
            czyznakispecjalne = false;
        }
    }
}