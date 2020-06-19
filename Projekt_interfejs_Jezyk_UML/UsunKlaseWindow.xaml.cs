using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    /// Interaction logic for UsunKlaseWindow.xaml
    /// </summary>
    public partial class UsunKlaseWindow : Window
    {
        Szkola szkola;
        private string numerKlasy;
        public UsunKlaseWindow(Szkola szkola)
        {
            this.szkola = szkola;
            InitializeComponent();
            klasaListBox.Items.Clear();
            for(int i=0; i<szkola.IloscKlas; i++)
            {
                klasaListBox.Items.Add(szkola.ListaKlas[i].NumerKlasy);
            }
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(klasaListBox.SelectedIndex > -1)
            {
                numerKlasy = klasaListBox.SelectedItem.ToString();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            szkola.usunKlase(Int32.Parse(numerKlasy));
            klasaListBox.Items.Clear();
            for (int i = 0; i < szkola.IloscKlas; i++)
            {
                klasaListBox.Items.Add(szkola.ListaKlas[i].NumerKlasy);
            }
        }
    }
}
