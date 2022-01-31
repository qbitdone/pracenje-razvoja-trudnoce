﻿using System;
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
    public partial class EvidencijaDodatakaPrehraniForm : Form
    {
        public EvidencijaDodatakaPrehraniForm()
        {
            InitializeComponent();
        }

        private void EvidencijaDodatakaPrehraniForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            moTrackerLabel.Left = (this.ClientSize.Width - moTrackerLabel.Width) / 2;
        }

        private void dodajZapisButton_Click(object sender, EventArgs e)
        {
            DodatakForm dodatakForm = new DodatakForm();
            dodatakForm.ShowDialog();
        }
    }
}