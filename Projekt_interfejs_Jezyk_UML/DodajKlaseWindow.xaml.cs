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
    /// Interaction logic for DodajKlaseWindow.xaml
    /// </summary>
    public partial class DodajKlaseWindow : Window
    {
        Szkola szkola;
        public DodajKlaseWindow(Szkola szkola)
        {
            this.szkola = szkola;
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Klasa klasa = new Klasa();
            klasa.NumerKlasy = Int32.Parse(numerKlasyTextBox.Text);
            szkola.dodajKlase(klasa);
            
        }
    }
}
