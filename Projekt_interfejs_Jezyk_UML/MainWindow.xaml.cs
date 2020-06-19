using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Projekt_interfejs_Jezyk_UML
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Szkola szkola = new Szkola();
        public MainWindow()
        {
            InitializeComponent();
            szkola.IloscKlas = 0;
            string iloscKlasValue = szkola.IloscKlas.ToString();
            iloscKlasLabel.Content = iloscKlasLabel.Content + " " + iloscKlasValue;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DodajKlaseWindow dodajKlaseWindow = new DodajKlaseWindow(szkola);
            dodajKlaseWindow.Show();
            iloscKlasLabel.Content = "Ilość klas: " + " " + szkola.IloscKlas;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            UsunKlaseWindow usunKlaseWindow = new UsunKlaseWindow(szkola);
            usunKlaseWindow.Show();
            iloscKlasLabel.Content = "Ilość klas: " + " " + szkola.IloscKlas;
        }
    }
}
