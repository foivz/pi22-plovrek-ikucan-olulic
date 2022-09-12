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
            textBoxRegistracija.Text = odabranaNarudzba.Vozilo.ToString();
            dgvNapredak.DataSource = baza.DohvatiNapredakZaOdabranuNarudzbu(odabranaNarudzba);
            dgvNapredak.Columns["Datum_vrijeme"].HeaderText = "Datum i vrijeme";

            cmbNapredak.DataSource = baza.DohvatiTipoveNapretka(odabranaNarudzba);
            cmbNapredak.ValueMember = "ID_tipa_napretka";
            cmbNapredak.DisplayMember = "Opis";
        }

        private void buttonZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonDodajNapredak_Click(object sender, EventArgs e)
        {
            Napredak addNapredak = new Napredak
            {
                ID_tipa_napretka = (cmbNapredak.SelectedItem as Tip_napretka).ID_tipa_napretka,
                ID_narudzbe = odabranaNarudzba.ID_narudzbe,
                Datum_vrijeme = DateTime.Now
            };
            baza.DodajNapredak(addNapredak);
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
