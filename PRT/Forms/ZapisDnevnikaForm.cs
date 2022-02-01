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
    public partial class ZapisDnevnikaForm : Form
    {
        private majka prijavljenaMajka;
        private readonly DnevnikForm dnevnikForm;
        public ZapisDnevnikaForm(majka prijavljenaMajka, DnevnikForm dnevnikForm)
        {
            InitializeComponent();
            this.prijavljenaMajka = prijavljenaMajka;
            this.dnevnikForm = dnevnikForm;
        }

        private void odustaniButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ZapisDnevnikaForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            moTrackerLabel.Left = (this.ClientSize.Width - moTrackerLabel.Width) / 2;
        }

        private void spremiButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new pregnancydbEntities())
                {
                    dnevnik zapis = new dnevnik();
                    zapis.id_majka = prijavljenaMajka.id_majka;

                    zapis.naslov = naslovTextBox.Text;
                    zapis.sadrzaj = sadrzajTextBox.Text;
                    zapis.datum_zapisa = DateTime.Now;

                    context.dnevnik.Add(zapis);
                    context.SaveChanges();
                }
                this.Hide();
                dnevnikForm.dohvatiZapise();
            }
            catch
            {
                MessageBox.Show("Pogreška");
            }
        }
    }
}
