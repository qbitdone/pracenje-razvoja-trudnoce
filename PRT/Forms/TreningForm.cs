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
    public partial class TreningForm : Form
    {
        private majka prijavljenaMajka;
        private readonly EvidencijaTreningaForm evidencijaTreningaForm;
        public TreningForm(majka prijavljenaMajka, EvidencijaTreningaForm evidencijaTreningaForm)
        {
            InitializeComponent();
            this.prijavljenaMajka = prijavljenaMajka;
            this.evidencijaTreningaForm = evidencijaTreningaForm;
            dohvatiTreninge();
        }

        private void odustaniButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void TreningForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            moTrackerLabel.Left = (this.ClientSize.Width - moTrackerLabel.Width) / 2;

            vrijemePocetakDTP.Format = DateTimePickerFormat.Time;
            vrijemePocetakDTP.ShowUpDown = true;
        }

        private void dohvatiTreninge()
        {
            using (var contex = new pregnancydbEntities())
            {
                var query = from k in contex.vrsta_treninga
                            select k;

                vrstaTreningaComboBox.DataSource = null;
                vrstaTreningaComboBox.DataSource = query.ToList();

            }
        }

        private void spremiButton_Click(object sender, EventArgs e)
        {
            if (!Int32.TryParse(trajanjeTextBox.Text, out int value))
            {
                MessageBox.Show("Trajanje treninga mora biti brojčana vrijednost");
            }
            else
            {
                using (var contex = new pregnancydbEntities())
                {
                    trening trening = new trening();
                    trening.id_majka = prijavljenaMajka.id_majka;
                    trening.id_vrsta = (vrstaTreningaComboBox.SelectedItem as vrsta_treninga).id_vrsta;
                    trening.datum = datumDTP.Value;
                    trening.biljeske = sazetakTextBox.Text;
                    trening.vrijeme_pocetak = vrijemePocetakDTP.Value.TimeOfDay;
                    trening.trajanje = int.Parse(trajanjeTextBox.Text);

                    contex.trening.Add(trening);
                    contex.SaveChanges();
                }
                this.Hide();
                evidencijaTreningaForm.dohvatiTreninge();
            }
        }
    }
}
