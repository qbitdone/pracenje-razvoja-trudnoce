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
    public partial class DodatakForm : Form
    {
        private majka prijavljenaMajka;
        private readonly EvidencijaDodatakaPrehraniForm evidencijaDodatakaPrehraniForm;
        public DodatakForm(majka prijavljenaMajka, EvidencijaDodatakaPrehraniForm evidencijaDodatakaPrehraniForm)
        {
            InitializeComponent();
            this.prijavljenaMajka = prijavljenaMajka;
            this.evidencijaDodatakaPrehraniForm = evidencijaDodatakaPrehraniForm;
            dohvatiDodatke();

        }

        private void odustaniButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void DodatakForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            moTrackerLabel.Left = (this.ClientSize.Width - moTrackerLabel.Width) / 2;
        }

        private void dohvatiDodatke()
        {
            using (var contex = new pregnancydbEntities())
            {
                var query = from k in contex.dodatak_prehrani
                            select k;

                List<dodatak_prehrani> ListaDodataka = new List<dodatak_prehrani>();
                ListaDodataka = query.ToList();

                dodatakComboBox.DataSource = ListaDodataka;
            }
        }

        private void spremiButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new pregnancydbEntities())
                {
                    int kolicina = int.Parse(kolicinaTextBox.Text);
                    majka_dodatak_prehrani zapis = new majka_dodatak_prehrani();
                    zapis.id_majka = prijavljenaMajka.id_majka; 
                    zapis.id_dodatak = (dodatakComboBox.SelectedItem as dodatak_prehrani).id_dodatak;
                    zapis.datum_uzimanja = DateTime.Now;
                    zapis.kolicina = kolicina;

                    context.majka_dodatak_prehrani.Add(zapis);
                    context.SaveChanges();
                }
                evidencijaDodatakaPrehraniForm.dohvatiMajkaDodatak();
                this.Hide();
            }
            catch
            {
                MessageBox.Show("Dogodila se greška prilikom unosa");
            }
        }
    }
}
