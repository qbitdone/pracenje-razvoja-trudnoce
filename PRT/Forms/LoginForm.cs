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
            PocetnaForm pocetna = new PocetnaForm();
            this.Hide();
            pocetna.ShowDialog();
        }
    }
}
