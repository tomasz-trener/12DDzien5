using System;

namespace P01AplikacjaZawodnicy.Domains
{
    public class Zawodnik
    {
        public int Id;
        public int? Id_trenera;
        public string Imie { get; set; }
        public string Nazwisko;
        public string Kraj;
        public DateTime DataUrodzenia;
        public int Wzrost;
        public int Waga;

        public string Wiersz
        {
            get
            {
                return Imie + " " + Nazwisko + " " + Kraj;
            }
        }

        public string LiniaPliku
        {
            get { return $"{Id};{Id_trenera};{Imie};{Nazwisko};{Kraj};{DataUrodzenia.ToString("dd-MM-yyyy")};{Wzrost};{Waga}"; }
        }

        public string PrzedstawSie()
        {
            return $"Nazywam się {Imie} {Nazwisko} i pochodzę z {Kraj}";
        }
    }
}