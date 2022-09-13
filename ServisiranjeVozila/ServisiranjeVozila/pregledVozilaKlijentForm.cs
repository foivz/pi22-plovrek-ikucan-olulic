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
    public partial class pregledVozilaKlijentForm : Form
    {
        KomunikacijaSBazom baza = new KomunikacijaSBazom();
        Korisnik trenutniKorisnik;
        public pregledVozilaKlijentForm(Korisnik korisnik)
        {
            trenutniKorisnik = korisnik;
            InitializeComponent();
        }
        public pregledVozilaKlijentForm()
        {
            InitializeComponent();
        }

        private void PostaviNaslove()
        {
            dgvVozila.Columns["Narudzba"].Visible = false;
            dgvVozila.Columns["Vlasnistvo"].Visible = false;

            dgvVozila.Columns["Registracija_vozila"].HeaderText = "Registracija vozila";
            dgvVozila.Columns["Marka_vozila"].HeaderText = "Marka vozila";
            dgvVozila.Columns["Model_vozila"].HeaderText = "Model vozila";
            dgvVozila.Columns["Stanje_brojaca"].HeaderText = "Stanje brojača";
        }

        private void buttonZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VozilaForm_Load(object sender, EventArgs e)
        {
            dgvVozila.DataSource = baza.DohvatiVozilaKorisnika(trenutniKorisnik);
            PostaviNaslove();
        }

        private void buttonDodajVozilo_Click(object sender, EventArgs e)
        {
            dodavanjeVozila forma = new dodavanjeVozila(trenutniKorisnik);
            this.Hide();
            forma.ShowDialog();
            this.Show();
            dgvVozila.DataSource = null;
            dgvVozila.DataSource = baza.DohvatiVozilaKorisnika(trenutniKorisnik);
            PostaviNaslove();

        }
    }
}
