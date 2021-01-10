using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static NRT6017.StatickeMetode;

namespace NRT6017
{
    public partial class Dodaj_novi_artikal : Form
    {
        enum artikli { Alkoholna_pica = 1, Bezalkoholna_pica = 2, Hrana = 3, Voce = 4, Povrce = 5, Hemikalije = 6 }
        Form roditeljskaForma;

        public Dodaj_novi_artikal(Form roditeljskaForma)
        {
            InitializeComponent();
            this.roditeljskaForma = roditeljskaForma;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (DaLiJeSlovo(tbxNaziv,"naziv")==true && DaLiJeCena(tbxCena.Text,"Cena") ==true && DaLiJeBroj(tbxPopust,"popust")==true)
            {
                if (daLiSuPrazni(this) == false)
                {
                    int ID_grupe;
                    Artikal artikal = new Artikal(0, tbxNaziv.Text, Convert.ToDouble(tbxCena.Text), Convert.ToDouble(tbxPopust.Text), Convert.ToInt32(cbKategorija.SelectedIndex) + 1);
                    noviArtikalUpis(artikal);
                    ID_grupe = artikal.Id_grupe;
                    artikal = poslednjiArtikalUBazi();
                    upisiNovuGrupu(artikal.Id_artikla, ID_grupe);
                    isprazni(this);
                }
            }
        }

        private void Dodaj_novi_artikal_Load(object sender, EventArgs e)
        {
            foreach (var a in Enum.GetNames(typeof(artikli)))
                cbKategorija.Items.Add(((string)a).Replace('_',' '));
        }

        private void Dodaj_novi_artikal_FormClosing(object sender, FormClosingEventArgs e)
        {
            roditeljskaForma.Visible = true;
        }
    }
}
