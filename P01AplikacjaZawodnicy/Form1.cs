using P01AplikacjaZawodnicy.Domains;
using P01AplikacjaZawodnicy.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P01AplikacjaZawodnicy
{
    public partial class Form1 : Form
    {
        ManagerZawodnikow mz;
        public Form1()
        {
            InitializeComponent();

            numWzrost.Maximum = decimal.MaxValue;
            numWaga.Maximum = decimal.MaxValue;
           
        }

        private void txtSciezka_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "pliki tekstowe (*.txt)|*.txt|wszystkie pliki (*.*)|*.*";
            ofd.ShowDialog();
            
            txtSciezka.Text = ofd.FileName;
        }

        private void btnWczytaj_Click(object sender, EventArgs e)
        {
            mz = new ManagerZawodnikow(txtSciezka.Text, TypImportu.Loklany);
            Zawodnik[] zawodnicy = mz.WczytajZawodnikow();
           
            foreach (var z in zawodnicy)
                lbDane.Items.Add(z.Imie + " " + z.Nazwisko + " " + z.Kraj);
        }

        private void lbDane_SelectedIndexChanged(object sender, EventArgs e)
        {
            gbSzczegolyZawodnika.Visible = true;

            int indeks = lbDane.SelectedIndex;

            Zawodnik zaznaczony= mz.Zawodnicy[indeks];

            txtImie.Text = zaznaczony.Imie;
            txtNazwisko.Text = zaznaczony.Nazwisko;
            txtKraj.Text = zaznaczony.Kraj;
            dtpDataUrodzenia.Value = zaznaczony.DataUrodzenia;
            numWaga.Value = zaznaczony.Waga;
            numWzrost.Value = zaznaczony.Wzrost;
        }

        //https://github.com/tomasz-trener/12DDzien5
        //https://github.com/tomasz-trener/12ZDzien4
    }
}
