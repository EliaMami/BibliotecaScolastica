using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaScolastica
{
    class Libro
    {
        private string _autore;
        private string _titolo;
        private int _annoPubblicazione;
        private string _editore;
        private int _numeroPagine;

        #region GetSet
        public string Autore
        {
            get { return _autore; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Autore non valido.");
                }
                _autore = value;
            }
        }
        public string Titolo
        {
            get { return _titolo; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Titolo non valido.");
                }
                _titolo = value;
            }
        }
        public string Editore
        {
            get { return _editore; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Editore non valido.");
                }
                _editore = value;
            }
        }
        public int AnnoPubblicazione
        {
            get { return _annoPubblicazione; }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Anno di pubblicazione non valido.");
                }
                _annoPubblicazione = value;
            }
        }
        public int NumeroPagine
        {
            get { return _numeroPagine; }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Numero pagine non valido.");
                }
                _numeroPagine = value;
            }
        }
        #endregion

        public Libro(string autore, string titolo, int annoPubblicazione, string editore, int numeroPagine)
        {
            Autore = autore;
            Titolo = titolo;
            AnnoPubblicazione = annoPubblicazione;
            Editore = editore;
            NumeroPagine = numeroPagine;
        }
        public string readingTime()
        {
            if(NumeroPagine <= 100)
            {
                return "Il tempo di lettura equivale ad un ora.";
            }
            else if (NumeroPagine > 100 && NumeroPagine < 200)
            {
                return "Il tempo di lettura equivale a due ore.";
            }
            else
            {
                return "Il tempo di lettura è maggiore di due ore.";
            }
        }
        public override string ToString()
        {
            return "Il libro '" + Titolo + "', scritto da " + Autore + " e pubblicato dall'editore " + Editore + " nel " + AnnoPubblicazione + " ha " + NumeroPagine + " pagine.";
        }
    }
}
