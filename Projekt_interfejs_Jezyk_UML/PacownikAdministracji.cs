using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt_interfejs_Jezyk_UML
{
    class PacownikAdministracji : PracownikOswiaty
    {
        private string rodzajPracownikaAdministracji;
        public string RodzajPracownikaAdministracji
        {
            get { return rodzajPracownikaAdministracji; }
            set { rodzajPracownikaAdministracji = value; }
        }

        protected void zabezpieczZasobyMaterialneSzkoly(Szkola szkola)
        {
            if(szkola.StanSzkoly == false)
            {
                string message = "Zasoby materialne szkoły zabezpieczone.";
            }
        }

        public override int obliczWyplate()
        {   
            return 2000;
        }
    }
}
