using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt_interfejs_Jezyk_UML
{
    public abstract class PracownikOswiaty
    {
        private string imie;
        public string Imie
        {
            get { return imie; }
            set { imie = value; }
        }

        private string nazwisko;
        public string Nazwisko
        {
            get { return nazwisko; }
            set { nazwisko = value; }
        }

        private DateTime dataUrodzenia;
        public DateTime DataUrodzenia
        {
            get { return dataUrodzenia; }
            set { dataUrodzenia = value; }
        }

        private int[] pesel;
        private int[] PESEL 
        {
            get { return pesel; }
            set { pesel = value; }
        }

        private bool stanPracy;
        public bool StanPracy
        {
            get { return stanPracy; }
            set { stanPracy = value; }
        }

        private string wyksztalcenie;
        public string Wyksztalcenie
        {
            get { return wyksztalcenie; }
            set { wyksztalcenie = value; }
        }

        private int wyplata;
        private int Wyplata
        {
            get { return wyplata; }
            set { wyplata = value; }
        }

        public void zacznijPrace()
        {
            stanPracy = true;
        }

        public void zakonczPrace()
        {
            stanPracy = false;
        }

        protected void jedzNaWakacje()
        {
            zakonczPrace();
            string message = "Jadę na wakacje !!!";
        }

        abstract public int obliczWyplate();
    }
}
