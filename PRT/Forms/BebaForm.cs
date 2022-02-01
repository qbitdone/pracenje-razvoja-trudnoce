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
    public partial class BebaForm : Form
    {
        private majka prijavljenaMajka;
        private readonly InformacijeOBebamaForm informacijeOBebamaForm;

        public BebaForm(majka prijavljenaMajka, InformacijeOBebamaForm informacijeOBebamaForm)
        {
            InitializeComponent();
            this.prijavljenaMajka = prijavljenaMajka;
            this.informacijeOBebamaForm = informacijeOBebamaForm;

        }

        private void BebaForm_Load(object sender, EventArgs e)
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
                using (var contex = new pregnancydbEntities())
                {
                    beba beba = new beba();

                    beba.ime = imeTextBox.Text;
                    beba.prezime = prezimeTextBox.Text;
                    beba.spol = spolTextBox.Text;
                    beba.id_majka = prijavljenaMajka.id_majka;

                    contex.beba.Add(beba);
                    contex.SaveChanges();
                }
                this.Hide();
                informacijeOBebamaForm.dohvatiBebe();
            }
            catch
            {
                MessageBox.Show("Spol moze biti musko ili zensko");
            }
        }
    }
}
