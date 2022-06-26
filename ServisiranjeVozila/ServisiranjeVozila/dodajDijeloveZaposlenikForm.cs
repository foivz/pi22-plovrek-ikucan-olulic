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

namespace ServisiranjeVozila
{
    public partial class dodajDijeloveZaposlenikForm : Form
    {
        Narudzba odabranaNarudzba;
        KomunikacijaSBazom baza = new KomunikacijaSBazom();
        public dodajDijeloveZaposlenikForm(Narudzba narudzba)
        {
            odabranaNarudzba = narudzba;
            InitializeComponent();
        }
        public dodajDijeloveZaposlenikForm()
        {
            InitializeComponent();
        }

        private void PostaviNaslove()
        {
            dgvSviDijelovi.Columns["ID_dijela"].Visible = false;
            dgvSviDijelovi.Columns["Kupovina"].Visible = false;
            dgvSviDijelovi.Columns["Narudzba"].Visible = false;

            dgvSviDijelovi.Columns["Naziv_dijela"].HeaderText = "Naziv dijela";
            dgvSviDijelovi.Columns["Opis_dijela"].HeaderText = "Opis";
            dgvSviDijelovi.Columns["Sifra_dijela"].HeaderText = "Šifra dijela";

            dgvDijeloviUNarudzbi.Columns["ID_dijela"].Visible = false;
            dgvDijeloviUNarudzbi.Columns["Kupovina"].Visible = false;
            dgvDijeloviUNarudzbi.Columns["Narudzba"].Visible = false;

            dgvDijeloviUNarudzbi.Columns["Naziv_dijela"].HeaderText = "Naziv dijela";
            dgvDijeloviUNarudzbi.Columns["Opis_dijela"].HeaderText = "Opis";
            dgvDijeloviUNarudzbi.Columns["Sifra_dijela"].HeaderText = "Šifra dijela";
        }

        private void OsvjeziPodatke()
        {
            dgvSviDijelovi.DataSource = baza.DohvatiDijeloveOsimUNarudzbi(odabranaNarudzba);
            dgvDijeloviUNarudzbi.DataSource = baza.DohvatiDijeloveUNarudzbi(odabranaNarudzba);

            if(baza.DohvatiSveDijelove().Count == baza.DohvatiDijeloveUNarudzbi(odabranaNarudzba).Count)
            {
                buttonUNarudzbu.Enabled = false;
            }
            
        }

        private void dodajDijeloveZaposlenikForm_Load(object sender, EventArgs e)
        {
            OsvjeziPodatke();
            PostaviNaslove();
        }

        private void textBoxPretrazivanje_TextChanged(object sender, EventArgs e)
        {
            dgvSviDijelovi.DataSource = baza.FiltrirajDijelovePremaNazivuZaNarudzbu(textBoxPretrazivanje.Text, odabranaNarudzba);
            PostaviNaslove();
        }

        private void buttonUNarudzbu_Click(object sender, EventArgs e)
        {
            if (dgvSviDijelovi.SelectedRows.Count > 0)
            {
                Dijelovi odabraniDio = dgvSviDijelovi.CurrentRow.DataBoundItem as Dijelovi;
                baza.DodajDioUNarudzbu(odabraniDio, odabranaNarudzba);
                OsvjeziPodatke();
                PostaviNaslove();
            }
            else
            {
                MessageBox.Show("Označite red!");
            }

        }

        private void buttonZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxPretrazivanjeSifra_TextChanged(object sender, EventArgs e)
        {
            dgvSviDijelovi.DataSource = baza.FiltrirajDijelovePremaSifriZaNarudzbu(textBoxPretrazivanjeSifra.Text, odabranaNarudzba);
            PostaviNaslove();
        }

        private void dodajDijeloveZaposlenikForm_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Pomoc pomoc = new Pomoc();
            pomoc.OtvoriPomocDjelatnik(this, "dodajDijeloveNarudzbiZaposlenik.htm");
        }
    }
}
