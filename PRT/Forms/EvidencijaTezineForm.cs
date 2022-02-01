using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRT.Forms
{
    public partial class EvidencijaTezineForm : Form
    {
        private majka prijavljenaMajka;
        public EvidencijaTezineForm(majka prijavljenaMajka)
        {
            InitializeComponent();
            this.prijavljenaMajka = prijavljenaMajka;
            dohvatiTezine();
        }

        private void EvidencijaTezineForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            moTrackerLabel.Left = (this.ClientSize.Width - moTrackerLabel.Width) / 2;
        }

        private void dodajZapisButton_Click(object sender, EventArgs e)
        {
            TezinaForm tezinaForm = new TezinaForm(prijavljenaMajka, this);
            tezinaForm.ShowDialog();
        }

        public void dohvatiTezine()
        {
            using (var contex = new pregnancydbEntities())
            {
                zapistezineBindingSource.DataSource = null;

                List<zapis_tezine> ListaTezina = new List<zapis_tezine>();

                var query = from k in contex.zapis_tezine
                            where k.id_majka == prijavljenaMajka.id_majka
                            select k;

                ListaTezina = query.ToList();

                zapistezineBindingSource.DataSource = ListaTezina;
            }
        }

        private void obrisiZapisButton_Click(object sender, EventArgs e)
        {
            using (var contex = new pregnancydbEntities())
            {
                zapis_tezine zapis = zapistezineBindingSource.Current as zapis_tezine;
                contex.zapis_tezine.Attach(zapis);
                // contex.Entry(zapis).State = System.Data.Entity.EntityState.Deleted;
                contex.zapis_tezine.Remove(zapis);
                contex.SaveChanges();

            }

            dohvatiTezine();
        }
    }
}
