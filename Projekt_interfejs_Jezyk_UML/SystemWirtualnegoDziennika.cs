using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projekt_interfejs_Jezyk_UML
{
    class PakietUcznia
    {
        public int IDpakiet;
        List<int> listaOcenUcznia = new List<int>();

        public int ListaOcenUcznia
        {
            set { listaOcenUcznia.Add(value); }
        }

        public void ZmienOcene(int ocena)
        {
            int num = listaOcenUcznia.Count;
            listaOcenUcznia[num - 1] = ocena;
        }

        public void UsunOcene(int ocena)
        {
            int num = listaOcenUcznia.Count;
            listaOcenUcznia[num - 1] = 0;
        }

    }

    class SystemWirtualnegoDziennika
    {
        private Hashtable listaOcenUczniow;
        
        public bool DodajOcene(int ocena, int IDucznia)
        {
            if(listaOcenUczniow.ContainsKey(IDucznia) == false)
            {
                PakietUcznia  pakietUcznia = new PakietUcznia();
                pakietUcznia.IDpakiet = IDucznia;
                listaOcenUczniow.Add(IDucznia, pakietUcznia);
                pakietUcznia.ListaOcenUcznia = ocena;
                return true;
            } else if(listaOcenUczniow.ContainsKey(IDucznia) == true)
            {
                foreach (DictionaryEntry item in listaOcenUczniow)
                {
                    if((int)item.Key == IDucznia)
                    {
                        ((PakietUcznia)item.Value).ListaOcenUcznia = ocena;
                    }
                }
            }
            return true;
        }

        public bool ZmienOcene(int ocena, int IDucznia)
        {
            if(listaOcenUczniow.ContainsKey(IDucznia) == true)
            {
                foreach (DictionaryEntry item in listaOcenUczniow)
                {
                    if((int)item.Key == IDucznia)
                    {
                        ((PakietUcznia)item.Value).ZmienOcene(ocena);
                        return true;
                    }
                }
            }
            return true;
        }

        public bool UsunOcene(int ocena, int IDucznia)
        {
            if(listaOcenUczniow.ContainsKey(IDucznia) == true)
            {
                foreach(DictionaryEntry item in listaOcenUczniow)
                {
                    if((int)item.Key == IDucznia)
                    {
                        ((PakietUcznia)item.Value).UsunOcene(ocena);
                        return true;
                    }
                }
            }
            return true;
        }
    }
}
