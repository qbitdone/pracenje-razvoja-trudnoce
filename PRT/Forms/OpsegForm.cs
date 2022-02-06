using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRT.Forms
{
    public partial class OpsegForm : Form
    {
        private majka prijavljenaMajka;
        private readonly EvidencijaOpsegaForm evidencijaOpsegaForm;
        public OpsegForm(majka prijavljenaMajka, EvidencijaOpsegaForm evidencijaOpsegaForm)
        {
            InitializeComponent();
            this.prijavljenaMajka = prijavljenaMajka;
            this.evidencijaOpsegaForm = evidencijaOpsegaForm;
        }

        private void OpsegForm_Load(object sender, EventArgs e)
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
            if (!Int32.TryParse(opsegTextBox.Text, out int value))
            {
                MessageBox.Show("Opseg mora biti broj");
            } 
            else
            {
                try
                {
                    using (var context = new pregnancydbEntities())
                    {
                        double opseg = double.Parse(opsegTextBox.Text);
                        zapis_opsega zapis = new zapis_opsega();
                        zapis.datum_pocetak = DateTime.Now;
                        zapis.opseg = opseg;
                        zapis.id_majka = prijavljenaMajka.id_majka;

                        context.zapis_opsega.Add(zapis);
                        context.SaveChanges();
                    }
                    evidencijaOpsegaForm.dohvatiOpsege();
                    this.Hide();
                }
                catch (DbUpdateException ex)
                {
                    if (ex.InnerException != null && ex.InnerException.InnerException != null)
                    {
                        MessageBox.Show(ex.InnerException.InnerException.Message);
                    }
                }
            }
        }
    }
}
