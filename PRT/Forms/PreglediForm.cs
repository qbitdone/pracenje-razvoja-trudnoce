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
    public partial class PreglediForm : Form
    {
        private majka prijavljenaMajka;
        private majka_doktor majkaDoktor;
        public PreglediForm(majka prijavljenaMajka)
        {
            InitializeComponent();
            this.prijavljenaMajka = prijavljenaMajka;
            dohvatiPreglede();
        }

        private void PreglediForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            moTrackerLabel.Left = (this.ClientSize.Width - moTrackerLabel.Width) / 2;
        }

        private void dodajZapisButton_Click(object sender, EventArgs e)
        {
            PregledForm pregledForm = new PregledForm(majkaDoktor, this);
            pregledForm.ShowDialog();
        }

        public void dohvatiPreglede()
        {
            using (var contex = new pregnancydbEntities())
            {
                int idMajkaDoktor = (from k in contex.majka_doktor
                                     where k.id_majka == prijavljenaMajka.id_majka && k.datum_kraj == null
                                     select k.id_majka_doktor).Single();

                majkaDoktor = (from k in contex.majka_doktor
                               where k.id_majka == prijavljenaMajka.id_majka && k.datum_kraj == null
                               select k).Single();

                
                var query = from k in contex.pregled
                            where k.id_majka_doktor == idMajkaDoktor
                            select k;

                pregledBindingSource.DataSource = null;
                pregledBindingSource.DataSource = query.ToList();
            }
        }

        private void obrisiZapisButton_Click(object sender, EventArgs e)
        {
            using (var contex = new pregnancydbEntities())
            {
                pregled zapis = pregledBindingSource.Current as pregled;
                contex.pregled.Attach(zapis);
                // contex.Entry(zapis).State = System.Data.Entity.EntityState.Deleted;
                contex.pregled.Remove(zapis);
                contex.SaveChanges();
            }
            dohvatiPreglede();
        }
    }
}
