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
    public partial class EvidencijaDodatakaPrehraniForm : Form
    {
        private majka prijavljenaMajka;
        public EvidencijaDodatakaPrehraniForm(majka prijavljenaMajka)
        {
            InitializeComponent();
            this.prijavljenaMajka = prijavljenaMajka;
            dohvatiMajkaDodatak();
        }

        private void EvidencijaDodatakaPrehraniForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            moTrackerLabel.Left = (this.ClientSize.Width - moTrackerLabel.Width) / 2;
        }

        private void dodajZapisButton_Click(object sender, EventArgs e)
        {
            DodatakForm dodatakForm = new DodatakForm(prijavljenaMajka, this);
            dodatakForm.ShowDialog();
        }
        public void dohvatiMajkaDodatak()
        {
            using (var contex = new pregnancydbEntities())
            {
                majkadodatakprehraniBindingSource.DataSource = null;

                List<majka_dodatak_prehrani> ListaMajkaDodatak = new List<majka_dodatak_prehrani>();

                var query = from k in contex.majka_dodatak_prehrani.Include("dodatak_prehrani")
                            where k.id_majka == prijavljenaMajka.id_majka
                            select k;

                ListaMajkaDodatak = query.ToList();

                majkadodatakprehraniBindingSource.DataSource = ListaMajkaDodatak;
            }
        }

        private void obrisiZapisButton_Click(object sender, EventArgs e)
        {
            using (var contex = new pregnancydbEntities())
            {
                majka_dodatak_prehrani zapis = majkadodatakprehraniBindingSource.Current as majka_dodatak_prehrani;
                contex.majka_dodatak_prehrani.Attach(zapis);
                // contex.Entry(zapis).State = System.Data.Entity.EntityState.Deleted;
                contex.majka_dodatak_prehrani.Remove(zapis);
                contex.SaveChanges();
            }
            dohvatiMajkaDodatak();
        }
    }
}
