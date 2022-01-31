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
    public partial class InformacijeOBebamaForm : Form
    {
        public InformacijeOBebamaForm()
        {
            InitializeComponent();
        }

        private void moTrackerLabel_Click(object sender, EventArgs e)
        {

        }

        private void obrisiZapisButton_Click(object sender, EventArgs e)
        {

        }

        private void prikazOpsegaDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dodajZapisButton_Click(object sender, EventArgs e)
        {
            BebaForm bebaForm = new BebaForm();
            bebaForm.ShowDialog();
            this.Close();
        }

        private void InformacijeOBebamaForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            moTrackerLabel.Left = (this.ClientSize.Width - moTrackerLabel.Width) / 2;
        }
    }
}
