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
    public partial class TezinaForm : Form
    {
        private majka prijavljenaMajka;
        private readonly EvidencijaTezineForm evidencijaTezineForm;
        public TezinaForm(majka prijavljenaMajka, EvidencijaTezineForm evidencijaTezineForm)
        {
            InitializeComponent();
            this.prijavljenaMajka = prijavljenaMajka;
            this.evidencijaTezineForm = evidencijaTezineForm;

        }

        private void TezinaForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            moTrackerLabel.Left = (this.ClientSize.Width - moTrackerLabel.Width) / 2;
        }

        private void odustaniButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void spremiButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new pregnancydbEntities())
                {
                    double tezina = double.Parse(tezinaTextBox.Text);
                    zapis_tezine zapis = new zapis_tezine();
                    zapis.datum = DateTime.Now;
                    zapis.tezina = tezina;
                    zapis.id_majka = prijavljenaMajka.id_majka;

                    context.zapis_tezine.Add(zapis);
                    context.SaveChanges();
                }
                evidencijaTezineForm.dohvatiTezine();
                //MessageBox.Show("Uspješno zabilježena težina");
                this.Hide();
            }
            catch
            {
                MessageBox.Show("Težina mora biti brojčana vrijednost");
            }
        }
    }
}
