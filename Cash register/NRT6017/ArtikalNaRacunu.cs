using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NRT6017
{
    class ArtikalNaRacunu : Artikal
    {
        int kolicina;

        public ArtikalNaRacunu(int kolicina, int id_artikla, string naziv, double cena, double popust,int id_grupe)
        {
            this.kolicina = kolicina;
            this.id_artikla = id_artikla;
            this.naziv = naziv;
            this.cena = cena;
            this.popust = popust;
            this.id_grupe = id_grupe;
        }
        public ArtikalNaRacunu(int kolicina, Artikal artikal)
        {
            this.kolicina = kolicina;
            this.id_artikla = artikal.Id_artikla;
            this.naziv = artikal.Naziv;
            this.cena = artikal.Cena;
            this.popust = artikal.Popust;
            this.id_grupe = artikal.Id_grupe;
        }

        public int Kolicina
        {
            get { return kolicina; }
            set { kolicina = value; }
        }

        public string ispisZaRacun()
        {
            return " Naziv: " + this.naziv + " Broj komada: " + kolicina + " Cena: " + (this.cena - this.cena * (popust / 100));
        }
    }
}
