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
        public Dyrektor dyrektor = new Dyrektor();
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
            if (szkola.IloscKlas > 0)
            {
                klasyZarzadzajComboBox.Items.Clear();
                for (int i = 0; i < szkola.IloscKlas; i++)
                {
                    klasyZarzadzajComboBox.Items.Add(szkola.ListaKlas[i].NumerKlasy);
                }
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            UsunKlaseWindow usunKlaseWindow = new UsunKlaseWindow(szkola);
            usunKlaseWindow.Show();
            iloscKlasLabel.Content = "Ilość klas: " + " " + szkola.IloscKlas;
            if (szkola.IloscKlas > 0)
            {
                klasyZarzadzajComboBox.Items.Clear();
                for (int i = 0; i < szkola.IloscKlas; i++)
                {
                    klasyZarzadzajComboBox.Items.Add(szkola.ListaKlas[i].NumerKlasy);
                }
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if(rozporzadzenieRichTextBox != null)
            {
                MessageBoxResult result = MessageBox.Show(dyrektor.wydajRozporzadzenie());
            }
            
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            bool radio = dyrektor.otworzSzkole(szkola);
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            bool radio = dyrektor.zamknijSzkole(szkola);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            ZrekrutujUczniaWindow zrekrutujUczniaWindow = new ZrekrutujUczniaWindow(szkola);
            zrekrutujUczniaWindow.Show();
        }

        private string numerKlasy;
        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            listaUczniowListBox.Items.Clear();
            if (klasyZarzadzajComboBox.SelectedIndex > -1)
            {
                numerKlasy = klasyZarzadzajComboBox.SelectedItem.ToString();
            }

            for(int i = 0; i<szkola.ListaKlas.Count; i++)
            {
                if(szkola.ListaKlas[i].NumerKlasy == Int32.Parse(numerKlasy))
                {
                    for(int j = 0; j<szkola.ListaKlas[j].IloscUczniow; j++)
                    {
                        listaUczniowListBox.Items.Add(szkola.ListaKlas[i].ListaUczniow[j].Imie.ToString());
                    }
                }
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            DodajUczniaWindow dodajUczniaWindow = new DodajUczniaWindow(szkola);
            dodajUczniaWindow.Show();
            listaUczniowListBox.Items.Clear();
            listaUczniowListBox.Items.Clear();
            if (klasyZarzadzajComboBox.SelectedIndex > -1)
            {
                numerKlasy = klasyZarzadzajComboBox.SelectedItem.ToString();
            }

            for (int i = 0; i < szkola.ListaKlas.Count; i++)
            {
                if (szkola.ListaKlas[i].NumerKlasy == Int32.Parse(numerKlasy))
                {
                    for (int j = 0; j < szkola.ListaKlas[j].IloscUczniow; j++)
                    {
                        listaUczniowListBox.Items.Add(szkola.ListaKlas[i].ListaUczniow[j].ToString());
                    }
                }
            }
        }
    }
}
