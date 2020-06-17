using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Projekt_interfejs_Jezyk_UML
{
    class PakietUcznia
    {
        List<int> listaOcenUcznia = new List<int>();

        public int ListaOcenUcznia
        {
            set { listaOcenUcznia.Add(value); }
        }

    }

    class SystemWirtualnegoDziennika
    {
        private Hashtable listaOcenUczniow;
        
        public bool dodajOcene(int ocena, int IDucznia)
        {
            if(listaOcenUczniow.ContainsKey(IDucznia) == false)
            {
                PakietUcznia pakietUcznia = new PakietUcznia();
                listaOcenUczniow.Add(IDucznia, pakietUcznia);
                pakietUcznia
            } else if(lista)
            return true;
        }
    }
}
