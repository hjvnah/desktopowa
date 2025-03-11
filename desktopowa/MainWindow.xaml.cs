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

        public string haslo = "4$*hK";

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

        private void przyciskgenerujhaslo_Click(object sender, RoutedEventArgs e)
        {
            string ileznakowstring = textileznakow.Text;
            int ileznakow = int.Parse(ileznakowstring);

            Random random = new Random();

            string znakispecjalne = "!@#$%^&*()_+-=";
            string duzelitery = "ABCDEFGHIJKLMNOPRSTUWZXQY";
            string malelitery = "abcdefghijklmnoprstuwzxqy";
            string cyfry = "123456789";

            for ( int i = 0; i < ileznakow; i++)
            {
                
            }
            
            

        }

        private void przyciskzatwierdz_Click(object sender, RoutedEventArgs e)
        {
            string imie = textimie.Text;
            string nazwisko = textnazwisko.Text;
            string stanowisko = combostanowisko.Text;

            MessageBox.Show("Dane pracownika: " + imie + " " + nazwisko+" "+stanowisko+" Hasło: "+haslo);

        }
    }
}