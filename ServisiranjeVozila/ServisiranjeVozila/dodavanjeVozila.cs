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
    public partial class dodavanjeVozila : Form
    {
        KomunikacijaSBazom baza = new KomunikacijaSBazom();
        Korisnik trenutniKorisnik;
        public dodavanjeVozila(Korisnik korisnik)
        {
            trenutniKorisnik = korisnik;
            InitializeComponent();
        }

    public dodavanjeVozila()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vozilo vozilo = new Vozilo
            {
                Registracija_vozila = registracijaTextbox.Text,
                Marka_vozila = markaTextbox.Text,
                Model_vozila = modelTextbox.Text,
                Stanje_brojaca = int.Parse(stanjeTextbox.Text)
            };

            if(baza.DodajVozilo(vozilo, trenutniKorisnik) == 1){
                MessageBox.Show("Vozilo uspješno dodano!");
            }
            else
            {
                MessageBox.Show("Vozilo s tom registracijom već postoji!");
            }
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
