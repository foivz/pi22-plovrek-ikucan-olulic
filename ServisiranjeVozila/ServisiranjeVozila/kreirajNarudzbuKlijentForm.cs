using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServisiranjeVozila
{
    public partial class kreirajNarudzbuKlijentForm : Form
    {
        Korisnik trenutniKorisnik;
        KomunikacijaSBazom baza = new KomunikacijaSBazom();
        public kreirajNarudzbuKlijentForm(Korisnik korisnik)
        {
            InitializeComponent();
            trenutniKorisnik = korisnik;
        }
        public kreirajNarudzbuKlijentForm()
        {
            InitializeComponent();
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            Narudzba narudzba = new Narudzba
            {
                Korisnicko_ime = trenutniKorisnik.Korisnicko_ime,
                Registracija_vozila = textBoxRegistracija.Text,
                Marka_vozila = textBoxMarka.Text,
                Model_vozila = textBoxModel.Text,
                Stanje_brojaca = int.Parse(textBoxStanje.Text),
                Napomene = textBoxNapomena.Text,
                Datum_narudzbe = DateTime.Now,
                Potvrđeno = 0,
                Otkazano = 0,
                Zavrsena = 0
            };
            baza.DodajNarudzbu(narudzba);
            MessageBox.Show("Narudžba uspješno dodana!");
            this.Close();
        }

        private void kreirajNarudzbuKlijentForm_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this, @"..\..\Resources\pomocKorisnik.chm", "kreirajNarudzbu.htm");
        }

        private void kreirajNarudzbuKlijentForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
