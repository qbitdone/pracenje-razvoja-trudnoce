using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PRT.Forms;

namespace PRT.Forms
{
    public partial class RegistracijaForm : Form
    {
        public RegistracijaForm()
        {
            InitializeComponent();
        }

        private void registracijaButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (var contex = new pregnancydbEntities())
                {
                    majka majka = new majka();
                    majka.ime = imeTextBox.Text;
                    majka.prezime = prezimeTextBox.Text;
                    majka.mjesto = mjestoTextBox.Text;
                    majka.godine = int.Parse(godineTextBox.Text);
                    majka.email = emailTextBox.Text;
                    if (lozinkaTextBox.Text == potvrdaLozinkeTextBox.Text)
                    {
                        majka.lozinka = lozinkaTextBox.Text;
                        contex.majka.Add(majka);
                        contex.SaveChanges();
                        MessageBox.Show("Uspješna registracija");
                        PrijavaForm prijavaForm = new PrijavaForm();
                        this.Hide();
                        prijavaForm.ShowDialog();

                    } 
                    else
                    {
                        MessageBox.Show("Lozinke se ne podudaraju");
                    }
                        

                }
            }
            catch
            {
                MessageBox.Show("Godine moraju biti broj");
            }
        }

        private void RegistracijaForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;


            prijavaLabel.Left = (this.ClientSize.Width - prijavaLabel.Width) / 2;
        }

        private void prijavaButton_Click(object sender, EventArgs e)
        {
            PrijavaForm prijavaForm = new PrijavaForm();
            this.Hide();
            prijavaForm.ShowDialog();
        }

        private void mjestoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Mjesto_Click(object sender, EventArgs e)
        {

        }
    }
}
