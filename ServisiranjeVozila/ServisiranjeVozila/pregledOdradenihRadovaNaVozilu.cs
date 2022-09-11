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
    public partial class pregledOdradenihRadovaNaVozilu : Form
    {
        KomunikacijaSBazom baza = new KomunikacijaSBazom();
        Narudzba odabranaNarudzba;
        public pregledOdradenihRadovaNaVozilu(Narudzba narudzba)
        {
            InitializeComponent();
            odabranaNarudzba = narudzba;
        }

        private void pregledOdradenihRadovaNaVozilu_Load(object sender, EventArgs e)
        {
            dgvPregledOdrađenihRadovaNaVozilu.DataSource = baza.PregledOdradenihRadovaNaVozilu(odabranaNarudzba);
            Osvjezi();
        }

        private void Osvjezi()
        {
            dgvPregledOdrađenihRadovaNaVozilu.Columns[0].Visible = false;
            dgvPregledOdrađenihRadovaNaVozilu.Columns[1].Visible = false;
            dgvPregledOdrađenihRadovaNaVozilu.Columns["Narudzba"].Visible = false;
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
