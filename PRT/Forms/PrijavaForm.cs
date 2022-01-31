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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            prijavaButton.Left = (this.ClientSize.Width - prijavaButton.Width) / 2;
            prijavaLabel.Left = (this.ClientSize.Width - prijavaLabel.Width) / 2;
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
    }
}
