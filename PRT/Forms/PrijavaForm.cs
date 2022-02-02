using PRT.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRT
{
    public partial class PrijavaForm : Form
    {
        public PrijavaForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            
            prijavaLabel.Left = (this.ClientSize.Width - prijavaLabel.Width) / 2;
            prijavaButton.Left = (this.ClientSize.Width - prijavaButton.Width) / 2;
            registracijaButton.Left = (this.ClientSize.Width - registracijaButton.Width) / 2;
            passwordTextBox.Left = (this.ClientSize.Width - passwordTextBox.Width) / 2;
            emailTextBox.Left = (this.ClientSize.Width - passwordTextBox.Width) / 2;
        }

        private void prijavaButton_Click(object sender, EventArgs e)
        {
            using (var contex = new pregnancydbEntities())
            {
                string email = emailTextBox.Text;
                string lozinka = passwordTextBox.Text;

                var prijava = from k in contex.majka
                              where k.email == email && k.lozinka == lozinka
                              select k;
                if (prijava.Count() == 0)
                {
                    MessageBox.Show("Neuspješna prijava");
                } 
                else
                {
                    PocetnaForm pocetna = new PocetnaForm(prijava.First());
                    this.Hide();
                    pocetna.ShowDialog();
                }
            }

        }

        private void registracijaButton_Click(object sender, EventArgs e)
        {
            RegistracijaForm registracijaForm = new RegistracijaForm();
            this.Hide();
            registracijaForm.ShowDialog();
        }
    }
}
