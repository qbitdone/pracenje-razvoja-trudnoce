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
    public partial class EvidencijaTreningaForm : Form
    {
        private majka prijavljenaMajka;
        public EvidencijaTreningaForm(majka prijavljenaMajka)
        {
            InitializeComponent();
            this.prijavljenaMajka = prijavljenaMajka;
            dohvatiTreninge();
        }

        private void EvidencijaTreningaForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            moTrackerLabel.Left = (this.ClientSize.Width - moTrackerLabel.Width) / 2;
        }

        private void dodajZapisButton_Click(object sender, EventArgs e)
        {
            TreningForm treningForm = new TreningForm(prijavljenaMajka, this);
            treningForm.ShowDialog();
        }

        public void dohvatiTreninge()
        {
            using (var contex = new pregnancydbEntities())
            {
                var query = from k in contex.trening.Include("vrsta_treninga")
                            where k.id_majka == prijavljenaMajka.id_majka
                            select k;

                treningBindingSource.DataSource = null;
                treningBindingSource.DataSource = query.ToList();

            }
        }

        private void obrisiZapisButton_Click(object sender, EventArgs e)
        {
            using (var contex = new pregnancydbEntities())
            {
                trening zapis = treningBindingSource.Current as trening;
                contex.trening.Attach(zapis);
                // contex.Entry(zapis).State = System.Data.Entity.EntityState.Deleted;
                contex.trening.Remove(zapis);
                contex.SaveChanges();
            }
            dohvatiTreninge();
        }
    }
}
