using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NRT6017
{
    class Artikal
    {
        protected int id_artikla;
        protected string naziv;
        protected double cena;
        protected double popust;
        protected int id_grupe;

        public Artikal(int id_artikla, string naziv, double cena, double popust,int id_grupe)
        {
            this.id_artikla = id_artikla;
            this.naziv = naziv;
            this.cena = cena;
            this.popust = popust;
            this.id_grupe = id_grupe;
        }
        public Artikal(string naziv, double cena, double popust)
        {
            this.naziv = naziv;
            this.cena = cena;
            this.popust = popust;
        }
        public Artikal()
        {
            this.id_artikla = 0;
            this.naziv = "";
            this.cena = 0;
            this.popust = 0;
        }

        public int Id_artikla {
            get { return id_artikla; }
            set { id_artikla = value; }
        }
        public string Naziv
        {
            get { return naziv; }
            set { naziv = value; }
        }
        public double Cena
        {
            get { return cena; }
            set { cena = value; }
        }
        public double Popust
        {
            get { return popust; }
            set { popust = value; }
        }
        public int Id_grupe
        {
            get { return id_grupe; }
            set { id_grupe = value; }
        }

        public override string ToString()
        {
            return "ID: " + this.id_artikla + " Naziv: " + this.naziv + " Cena: " + this.cena + " Popust: " + this.popust +" ID grupe: "+this.id_grupe;
        }

        public string ispisZaKorpu()
        {
            return " Naziv: " + this.naziv + " Cena: " + (this.cena-this.cena*(popust/100)) ;
        }
    }
}
