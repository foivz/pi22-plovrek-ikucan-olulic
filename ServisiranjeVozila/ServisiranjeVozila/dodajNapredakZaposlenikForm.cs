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
    public partial class dodajNapredakZaposlenikForm : Form
    {
        KomunikacijaSBazom baza = new KomunikacijaSBazom();
        private Narudzba odabranaNarudzba;
        public dodajNapredakZaposlenikForm(Narudzba narudzba)
        {
            odabranaNarudzba = narudzba;
            InitializeComponent();
        }
        public dodajNapredakZaposlenikForm()
        {
            InitializeComponent();
        }

        private void dodajNapredakForm_Load(object sender, EventArgs e)
        {
            textBoxIDNarudzbe.Text = odabranaNarudzba.ID_narudzbe.ToString();
            textBoxKorime.Text = odabranaNarudzba.Korisnicko_ime.ToString();
            textBoxRegistracija.Text = odabranaNarudzba.Registracija_vozila.ToString();
            textBoxMarka.Text = odabranaNarudzba.Marka_vozila.ToString();
            textBoxModel.Text = odabranaNarudzba.Model_vozila.ToString();
            textBoxStanje.Text = odabranaNarudzba.Stanje_brojaca.ToString();
        }

        private void buttonZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonDodajNapredak_Click(object sender, EventArgs e)
        {
            string opis = textBoxNapredak.Text;
            int id = odabranaNarudzba.ID_narudzbe;
            Napredak napredak = new Napredak
            {
                Opis = opis,
                ID_narudzbe = id
            };

            baza.DodajNapredak(odabranaNarudzba, napredak);
            
            MessageBox.Show("Napredak je uspješno dodan!");
            this.Close();
        }

        private void dodajNapredakZaposlenikForm_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Pomoc pomoc = new Pomoc();
            pomoc.OtvoriPomocDjelatnik(this, "dodajNapredakZaposlenik.htm");
        }
    }
}
