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
    public partial class napredakNarudzbeKlijentForm : Form
    {
        private Narudzba odabranaNarudzba;
        public napredakNarudzbeKlijentForm(Narudzba narudzba)
        {
            odabranaNarudzba = narudzba;
            InitializeComponent();
        }
        public napredakNarudzbeKlijentForm()
        {
            InitializeComponent();
        }

        private void napredakNarudzbeForm_Load(object sender, EventArgs e)
        {
            using (var context = new EntitetiBaze())
            {
                context.Narudzba.Attach(odabranaNarudzba);
                var query = from n in context.Napredak
                            where n.ID_narudzbe == odabranaNarudzba.ID_narudzbe
                            select n;
                var podaci = query.ToList();
                foreach(var pod in podaci)
                {
                    textBoxNapredak.Text += pod.Opis.ToString()+ "\r\n";
                }
            }
        }

        private void buttonZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
