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
    public partial class dodajDijeloveUKupovinuKolicinaForm : Form
    {
        Kupovina odabranaKupovina;
        Dijelovi odabraniDio;
        KomunikacijaSBazom baza = new KomunikacijaSBazom();

        public dodajDijeloveUKupovinuKolicinaForm(Kupovina kupovina, Dijelovi dio)
        {
            odabranaKupovina = kupovina;
            odabraniDio = dio;
            InitializeComponent();
        }
        public dodajDijeloveUKupovinuKolicinaForm()
        {
            InitializeComponent();
        }

        private void buttonZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonPotvrdi_Click(object sender, EventArgs e)
        {
            var rezultat = baza.DodajDioUKupovinu(odabraniDio, odabranaKupovina, int.Parse(textBoxKolicina.Text));
            if(rezultat == 1)
            {
                MessageBox.Show("Količina koju ste unijeli veća je od količine na skladištu!");
            }
            else if(rezultat == 2)
            {
                MessageBox.Show("Količina ne može biti negativna!");
            }
            this.Close();
        }
    }
}
