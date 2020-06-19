using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Projekt_interfejs_Jezyk_UML
{
    /// <summary>
    /// Interaction logic for DodajUczniaWindow.xaml
    /// </summary>
    public partial class DodajUczniaWindow : Window
    {
        Szkola szkola;
        Uczen uczen = new Uczen();
        private string numerKlasy;
        public DodajUczniaWindow(Szkola szkola)
        {
            this.szkola = szkola;
            numerIDUczniaTextBox.Text = uczen.NumerID.ToString();
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string imieUcznia = imieUczniaTextBox.Text;
            string nazwiskoUcznia = nazwiskoUczniaTextBox.Text;
            int numberKlasy = Int32.Parse(numerKlasy);
            uczen.Nazwisko = nazwiskoUcznia;
            uczen.Imie = imieUcznia;
            uczen.NumerKlasy = numberKlasy;
        }
    }
}
