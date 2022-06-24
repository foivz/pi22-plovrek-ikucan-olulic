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
            dgvSviDijelovi.Columns["Sifra_dijela"].Visible = false;
            dgvSviDijelovi.Columns["Kupovina"].Visible = false;
            dgvSviDijelovi.Columns["Narudzba"].Visible = false;

            dgvSviDijelovi.Columns["Naziv_dijela"].HeaderText = "Naziv dijela";
            dgvSviDijelovi.Columns["Opis_dijela"].HeaderText = "Opis";

            dgvDijeloviUNarudzbi.Columns["ID_dijela"].Visible = false;
            dgvDijeloviUNarudzbi.Columns["Sifra_dijela"].Visible = false;
            dgvDijeloviUNarudzbi.Columns["Kupovina"].Visible = false;
            dgvDijeloviUNarudzbi.Columns["Narudzba"].Visible = false;

            dgvDijeloviUNarudzbi.Columns["Naziv_dijela"].HeaderText = "Naziv dijela";
            dgvDijeloviUNarudzbi.Columns["Opis_dijela"].HeaderText = "Opis";
        }

        private void OsvjeziPodatke()
        {
            using (var context = new EntitetiBaze())
            {
                var querySvi = from d in context.Dijelovi
                               select d;
                var dijeloviSvi = querySvi.ToList();
                dgvSviDijelovi.DataSource = null;
                dgvSviDijelovi.DataSource = dijeloviSvi;



                var queryUNarudzbi = from d in context.Dijelovi
                                     where d.Narudzba.Any(n => n.ID_narudzbe == odabranaNarudzba.ID_narudzbe)
                                     select d;
                var dijeloviUNarudzbi = queryUNarudzbi.ToList();
                dgvDijeloviUNarudzbi.DataSource = null;
                dgvDijeloviUNarudzbi.DataSource = dijeloviUNarudzbi;

                if(dijeloviSvi.Count == dijeloviUNarudzbi.Count)
                {
                    buttonUNarudzbu.Enabled = false;
                }
            }
        }

        private void dodajDijeloveZaposlenikForm_Load(object sender, EventArgs e)
        {
            OsvjeziPodatke();
            PostaviNaslove();
        }

        private void textBoxPretrazivanje_TextChanged(object sender, EventArgs e)
        {
            using (var context = new EntitetiBaze())
            {
                var querySvi = from d in context.Dijelovi
                               where d.Naziv_dijela.Contains(textBoxPretrazivanje.Text)
                               select d;
                var dijeloviSvi = querySvi.ToList();
                dgvSviDijelovi.DataSource = null;
                dgvSviDijelovi.DataSource = dijeloviSvi;
                PostaviNaslove();
            }
        }

        private void buttonUNarudzbu_Click(object sender, EventArgs e)
        {
            try
            {
                Dijelovi odabraniDio = dgvSviDijelovi.CurrentRow.DataBoundItem as Dijelovi;
                using (var context = new EntitetiBaze())
                {
                    context.Dijelovi.Attach(odabraniDio);
                    context.Narudzba.Attach(odabranaNarudzba);
                    if (!odabraniDio.Narudzba.Contains(odabranaNarudzba))
                    {
                        odabraniDio.Narudzba = new List<Narudzba>();
                        odabraniDio.Narudzba.Add(odabranaNarudzba);
                        context.SaveChanges();
                    }
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Odaberite red");
            }

            
            OsvjeziPodatke();
            PostaviNaslove();
        }

        private void buttonZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
