using F1_pomoc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Baza;

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
                Napomene = textBoxNapomena.Text,
                Datum_narudzbe = DateTime.Now,
                Potvrđeno = 0,
                Otkazano = 0,
                Zavrsena = 0,
                Ukupna_cijena = 0,
                Vozilo = (cmbVozila.SelectedItem as Vozilo).Registracija_vozila
            };
            baza.DodajNarudzbu(narudzba);
            MessageBox.Show("Narudžba uspješno dodana!");
            this.Close();
        }

        private void kreirajNarudzbuKlijentForm_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Pomoc pomoc = new Pomoc();
            pomoc.OtvoriPomocKorisnik(this, "kreirajNarudzbu.htm");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kreirajNarudzbuKlijentForm_Load(object sender, EventArgs e)
        {
            cmbVozila.DataSource = baza.DohvatiVozilaKorisnika(trenutniKorisnik);
            cmbVozila.DisplayMember = "Registracija_vozila";
            cmbVozila.ValueMember = "Registracija_vozila";
        }
    }
}
