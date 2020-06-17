using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt_interfejs_Jezyk_UML
{
    class PracownikSocjalny : PracownikOswiaty
    {
        private string rodzajPracownikaSocjalnego;
        public string RodzajPracownikaSocjalnego
        {
            get { return rodzajPracownikaSocjalnego; }
            set { rodzajPracownikaSocjalnego = value; }
        }

        protected void zadbajoSzkole(Szkola szkola)
        {
            if (szkola.StanSzkoly == false)
            {
                string message = "Pracownik socjalny: " + RodzajPracownikaSocjalnego + " zadbał o szkołę.";
            }
        }

        public override int obliczWyplate()
        {
            return 1800;
        }
    }
}
