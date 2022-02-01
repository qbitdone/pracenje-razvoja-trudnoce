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
    public partial class DoktorForm : Form
    {
        private majka prijavljenaMajka;
        public DoktorForm(majka prijavljenaMajka)
        {
            InitializeComponent();
            this.prijavljenaMajka = prijavljenaMajka;
            dohvatiDoktora();
        }

        private void odustaniButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void DoktorForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            moTrackerLabel.Left = (this.ClientSize.Width - moTrackerLabel.Width) / 2;

            imeTextBox.ReadOnly = true;
            prezimeTextBox.ReadOnly = true;
            kontaktBrojTextBox.ReadOnly = true;
            adresaTextBox.ReadOnly = true;
        }
        
        private void dohvatiDoktora()
        {
            using (var contex = new pregnancydbEntities())
            {
                var query = from k in contex.majka_doktor
                            where k.id_majka == prijavljenaMajka.id_majka && k.datum_kraj == null
                            select k;

                majka_doktor majka_ = query.Single();


                imeTextBox.Text = majka_.doktor.ime;
                prezimeTextBox.Text = majka_.doktor.prezime;
                kontaktBrojTextBox.Text = majka_.doktor.broj_telefona;
                adresaTextBox.Text = majka_.doktor.adresa;

                var upitovski = from k in contex.doktor
                                select k;

                List<doktor> ListaDoktora = upitovski.ToList();
                noviDoktorComboBox.DataSource = null;
                noviDoktorComboBox.DataSource = ListaDoktora;
            }
        }

        private void spremiButton_Click(object sender, EventArgs e)
        {
            using (var contex = new pregnancydbEntities())
            {
                doktor noviDoktor = noviDoktorComboBox.SelectedItem as doktor;
                majka_doktor majkaDoktor = new majka_doktor();
                majkaDoktor.id_majka = prijavljenaMajka.id_majka;
                majkaDoktor.id_doktor = noviDoktor.id_doktor;
                majkaDoktor.datum_pocetak = DateTime.Now;

                contex.majka_doktor.Add(majkaDoktor);
                contex.SaveChanges();
            }
            dohvatiDoktora();
        }
    }
}
