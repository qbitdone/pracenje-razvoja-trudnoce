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
    public partial class PregledForm : Form
    {
        private majka_doktor majkaDoktor;
        private readonly PreglediForm preglediForm;

        public PregledForm(majka_doktor majkaDoktor, PreglediForm preglediForm)
        {
            InitializeComponent();
            this.majkaDoktor = majkaDoktor;
            this.preglediForm = preglediForm;
        }

        private void odustaniButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void spremiButton_Click(object sender, EventArgs e)
        {
            if (sazetakTextBox.Text == "")
            {
                MessageBox.Show("Molimo popunite sva polja");
            }
            else
            {
                try
                {
                    using (var contex = new pregnancydbEntities())
                    {
                        pregled pregled = new pregled();

                        pregled.datum_pregleda = datumDTP.Value;
                        pregled.id_majka_doktor = majkaDoktor.id_majka_doktor;
                        pregled.sazetak = sazetakTextBox.Text;

                        contex.pregled.Add(pregled);
                        contex.SaveChanges();
                    }
                    this.Close();
                    preglediForm.dohvatiPreglede();
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

        private void PregledForm_Load(object sender, EventArgs e)
        {

        }
    }
}
