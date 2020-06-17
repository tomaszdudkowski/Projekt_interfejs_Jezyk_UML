using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt_interfejs_Jezyk_UML
{
    class NuaczycielPrzedmiotowScislych : Nauczyciel
    {
        private double wzoryMatematyczne;
        private double WzoryMatematyczne
        {
            get { return wzoryMatematyczne; }
            set { wzoryMatematyczne = value; }
        }

        private double wzoryFizyczne;
        private double WzoryFiziczne
        {
            get { return wzoryMatematyczne; }
            set { wzoryMatematyczne = value; }
        }

        public double licz(double a, double b)
        {
            return a * b;
        }

        public double wytlumaczWzor(int wzoryMatematyczne)
        {
            return wzoryMatematyczne * WzoryMatematyczne;
        }

        public double wytlumaczWzor(double wzroFizyczny)
        {
            return wzoryFizyczne * WzoryFiziczne;
        }

        public string przywitajKlase()
        {
            return "Witaj, klaso :)";
        }

        public override int obliczWyplate()
        {
            return base.obliczWyplate();
        }
    }
}
