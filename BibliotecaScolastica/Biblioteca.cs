using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaScolastica
{
    class Biblioteca
    {
        private string _nome;
        private string _indirizzo;
        private DateTime _orarioApertura;
        private DateTime _orarioChiusura;
        private List<Libro> _libri;

        public string Nome
        {
            get { return _nome; }
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new Exception("Nome non valido.");
                }
                _nome = value;
            }
        }
        public string Indirizzo
        {
            get { return _indirizzo; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Indirizzo non valido.");
                }
                _indirizzo = value;
            }
        }
        public DateTime OrarioApertura
        {
            get; set;
        }
        public DateTime OrarioChiusura
        {
            get; set;
        }
        public List<Libro> Libri
        {
            get; set;
        }

        public Biblioteca(string nome, string indirizzo, DateTime orarioApertura, DateTime orarioChiusura, List<Libro> libri)
        {
            Nome = nome;
            Indirizzo = indirizzo;
            OrarioApertura = orarioApertura;
            OrarioChiusura = orarioChiusura;
            Libri = libri;
        }
        public Biblioteca(string nome, string indirizzo, DateTime orarioApertura, DateTime orarioChiusura)
        {
            Nome = nome;
            Indirizzo = indirizzo;
            OrarioApertura = orarioApertura;
            OrarioChiusura = orarioChiusura;
            Libri = new List<Libro>();
        }
        public void AddLibro(Libro l)
        {
            _libri.Add(l);
        }
        public string RicercaLibro(string titoloRicercato)
        {
            Libro lRicercato;
            foreach(Libro l in Libri)
            {
                if(l.Titolo = titoloRicercato)
                {
                    lRicercato = l;
                }
            }
            return lRicercato.ToString;
        }
        public List<Libro> RicercaLibriConAutore(string autoreRicercato)
        {
            List<Libro> lRicercati = new List<Libro>();
            foreach (Libro l in Libri)
            {
                if (l.Autore = autoreRicercato)
                {
                    lRicercati.Add(l);
                }
            }
            return lRicercati;
        }
        public int numeroLibri()
        {
            return _libri.Count;
        }
    }
}
