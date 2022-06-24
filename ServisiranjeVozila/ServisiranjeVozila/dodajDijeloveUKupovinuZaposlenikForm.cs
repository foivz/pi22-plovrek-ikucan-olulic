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
    public partial class dodajDijeloveUKupovinuZaposlenikForm : Form
    {
        Kupovina odabranaKupovina;
        public dodajDijeloveUKupovinuZaposlenikForm(Kupovina kupovina)
        {
            odabranaKupovina = kupovina;
            InitializeComponent();
        }
        private void PostaviNaslove()
        {
            dgvDijelovi.Columns["ID_dijela"].Visible = false;
            dgvDijelovi.Columns["Kupovina"].Visible = false;
            dgvDijelovi.Columns["Narudzba"].Visible = false;

            dgvDijelovi.Columns["Naziv_dijela"].HeaderText = "Naziv dijela";
            dgvDijelovi.Columns["Opis_dijela"].HeaderText = "Opis";
            dgvDijelovi.Columns["Sifra_dijela"].HeaderText = "Šifra dijela";

            dgvDijeloviUNarudzbi.Columns["ID_dijela"].Visible = false;
            dgvDijeloviUNarudzbi.Columns["Kupovina"].Visible = false;
            dgvDijeloviUNarudzbi.Columns["Narudzba"].Visible = false;

            dgvDijeloviUNarudzbi.Columns["Naziv_dijela"].HeaderText = "Naziv dijela";
            dgvDijeloviUNarudzbi.Columns["Opis_dijela"].HeaderText = "Opis";
            dgvDijeloviUNarudzbi.Columns["Sifra_dijela"].HeaderText = "Šifra dijela";


        }
        public dodajDijeloveUKupovinuZaposlenikForm()
        {
            InitializeComponent();
        }

        private void OsvjeziPodatke()
        {
            using (var context = new EntitetiBaze())
            {
                var querySvi = from d in context.Dijelovi
                               select d;
                var dijeloviSvi = querySvi.ToList();
                dgvDijelovi.DataSource = null;
                dgvDijelovi.DataSource = dijeloviSvi;


                var queryUKupovini = from d in context.Dijelovi
                                     where d.Kupovina.Any(x => x.ID_kupovine == odabranaKupovina.ID_kupovine)
                                     select d;
                var dijeloviUKupovini = queryUKupovini.ToList();
                dgvDijeloviUNarudzbi.DataSource = null;
                dgvDijeloviUNarudzbi.DataSource = dijeloviUKupovini;

            }
            PostaviNaslove();
        }


        private void dodajDijeloveUKupovinuZaposlenikForm_Load(object sender, EventArgs e)
        {
            OsvjeziPodatke();
            
        }

        private void textBoxPretrazivanjeNaziv_TextChanged(object sender, EventArgs e)
        {
            using (var context = new EntitetiBaze())
            {
                var querySvi = from d in context.Dijelovi
                               where d.Naziv_dijela.Contains(textBoxPretrazivanjeNaziv.Text)
                               select d;
                var dijeloviSvi = querySvi.ToList();
                dgvDijelovi.DataSource = null;
                dgvDijelovi.DataSource = dijeloviSvi;
            }
            PostaviNaslove();
        }

        private void textBoxPretrazivanjeSifra_TextChanged(object sender, EventArgs e)
        {
            using (var context = new EntitetiBaze())
            {
                var querySvi = from d in context.Dijelovi
                               where d.Sifra_dijela.Contains(textBoxPretrazivanjeSifra.Text)
                               select d;
                var dijeloviSvi = querySvi.ToList();
                dgvDijelovi.DataSource = null;
                dgvDijelovi.DataSource = dijeloviSvi;
            }
            PostaviNaslove();
        }

        private void buttonUNarudzbu_Click(object sender, EventArgs e)
        {
            Dijelovi odabraniDio = dgvDijelovi.CurrentRow.DataBoundItem as Dijelovi;
            using (var context = new EntitetiBaze())
            {
                context.Dijelovi.Attach(odabraniDio);
                context.Kupovina.Attach(odabranaKupovina);
                if (!odabraniDio.Kupovina.Contains(odabranaKupovina))
                {
                    odabraniDio.Kupovina = new List<Kupovina>();
                    odabraniDio.Kupovina.Add(odabranaKupovina);
                    odabranaKupovina.Ukupna_cijena += odabraniDio.Cijena;
                    context.SaveChanges();
                }
            }
            OsvjeziPodatke();
        }

        private void buttonZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
