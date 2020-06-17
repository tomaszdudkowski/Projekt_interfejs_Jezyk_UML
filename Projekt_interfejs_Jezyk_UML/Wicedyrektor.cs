using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt_interfejs_Jezyk_UML
{
    class Wicedyrektor : Dyrektor
    {
        public string utworzZastepstwo(Nauczyciel nauczyciel)
        {
            string message = null;
            if (nauczyciel.StanPracy == false)
            {
                message = "Nauczyciel dostał zastępstwo";
                nauczyciel.zacznijPrace();
            } else
            {
                message = "Nauczyciel pracuje... nie moża dodać zastępstwa";
            }

            return message;
        }

        public string[] stworzPlan(Klasa klasa)
        {
            string[] przedmioty = { "Matematyka", "Polski", "Angielski", "Informatyka" };
            return przedmioty;
        }

        public override int obliczWyplate()
        {
            return base.obliczWyplate() - 1500;
        }
    }
}
