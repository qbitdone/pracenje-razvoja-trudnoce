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
    public partial class DnevnikForm : Form
    {
        private majka prijavljenaMajka;
        public DnevnikForm(majka prijavljenaMajka)
        {
            InitializeComponent();
            this.prijavljenaMajka = prijavljenaMajka;
            dohvatiZapise();
        }

        private void DnevnikForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            moTrackerLabel.Left = (this.ClientSize.Width - moTrackerLabel.Width) / 2;
        }

        private void dodajZapisButton_Click(object sender, EventArgs e)
        {
            ZapisDnevnikaForm zapisDnevnikaForm = new ZapisDnevnikaForm(prijavljenaMajka, this);
            zapisDnevnikaForm.ShowDialog();
        }

        public void dohvatiZapise()
        {
            using (var contex = new pregnancydbEntities())
            {
                var query = from k in contex.dnevnik
                            where prijavljenaMajka.id_majka == k.id_majka
                            select k;

                List<dnevnik> ListaDnevnika = new List<dnevnik>();
                ListaDnevnika = query.ToList();

                dnevnikBindingSource.DataSource = null;
                dnevnikBindingSource.DataSource = ListaDnevnika;
            }
        }

        private void obrisiZapisButton_Click(object sender, EventArgs e)
        {
            using (var contex = new pregnancydbEntities())
            {
                dnevnik zapis = dnevnikBindingSource.Current as dnevnik;
                contex.dnevnik.Attach(zapis);
                // contex.Entry(zapis).State = System.Data.Entity.EntityState.Deleted;
                contex.dnevnik.Remove(zapis);
                contex.SaveChanges();
            }
            dohvatiZapise();
        }
    }
}
