﻿using System;
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
    public partial class PocetnaKlijentForm : Form
    {
        Korisnik trenutniKorisnik;
        public PocetnaKlijentForm(Korisnik korisnik)
        {
            InitializeComponent();
            trenutniKorisnik = korisnik;
        }
        public PocetnaKlijentForm()
        {
            InitializeComponent();
        }

        private void OsvjeziPodatke()
        {
            using (var context = new EntitetiBaze())
            {
                var query = from n in context.Narudzba
                            where n.Korisnicko_ime == trenutniKorisnik.Korisnicko_ime
                            orderby n.Datum_narudzbe
                            select n;
                var podaci = query.ToList();
                dgvKorisnikoveNarudzbe.DataSource = podaci;
            }
        }

        private void PocetnaKlijentForm_Load(object sender, EventArgs e)
        {
            OsvjeziPodatke();
            dgvKorisnikoveNarudzbe.Columns["ID_narudzbe"].Visible = false;
            dgvKorisnikoveNarudzbe.Columns["Korisnicko_ime"].Visible = false;
            dgvKorisnikoveNarudzbe.Columns["Korisnik"].Visible = false;
            dgvKorisnikoveNarudzbe.Columns["Racun"].Visible = false;
            dgvKorisnikoveNarudzbe.Columns["Dijelovi"].Visible = false;
            dgvKorisnikoveNarudzbe.Columns["Napredak"].Visible = false;
            dgvKorisnikoveNarudzbe.Columns["Potvrđeno"].Visible = false;
            dgvKorisnikoveNarudzbe.Columns["Otkazano"].Visible = false;
            dgvKorisnikoveNarudzbe.Columns["Zavrsena"].Visible = false;

            dgvKorisnikoveNarudzbe.Columns["Registracija_vozila"].HeaderText = "Registracija vozila";
            dgvKorisnikoveNarudzbe.Columns["Marka_vozila"].HeaderText = "Marka";
            dgvKorisnikoveNarudzbe.Columns["Model_vozila"].HeaderText = "Model";
            dgvKorisnikoveNarudzbe.Columns["Stanje_brojaca"].HeaderText = "Stanje brojača";
            dgvKorisnikoveNarudzbe.Columns["Datum_narudzbe"].HeaderText = "Datum narudžbe";

        }

        private void detaljiNarudzbe_Click(object sender, EventArgs e)
        {
            var odabranaNarudzba = dgvKorisnikoveNarudzbe.CurrentRow.DataBoundItem as Narudzba;
            detaljiNarudzbeKlijentForm detaljiNarudzbeForm = new detaljiNarudzbeKlijentForm(odabranaNarudzba);
            detaljiNarudzbeForm.ShowDialog();
            OsvjeziPodatke();
        }
    }
}