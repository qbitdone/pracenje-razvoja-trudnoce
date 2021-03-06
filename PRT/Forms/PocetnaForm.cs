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
    public partial class PocetnaForm : Form
    {
        private majka prijavljenaMajka;
        public PocetnaForm(majka prijavljenaMajka)
        {
            InitializeComponent();
            this.prijavljenaMajka = prijavljenaMajka;
        }
        private void PocetnaForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            moTrackerLabel.Left = (this.ClientSize.Width - moTrackerLabel.Width) / 2;
        }

        private void evidencijaTezineButton_Click(object sender, EventArgs e)
        {
            EvidencijaTezineForm evidencijaTezineForm = new EvidencijaTezineForm(prijavljenaMajka);
            evidencijaTezineForm.ShowDialog();
        }

        private void evidencijaOpsegaButton_Click(object sender, EventArgs e)
        {
            EvidencijaOpsegaForm evidencijaOpsegaForm = new EvidencijaOpsegaForm(prijavljenaMajka);
            evidencijaOpsegaForm.ShowDialog();
        }

        private void informacijeOBebamaButton_Click(object sender, EventArgs e)
        {
            InformacijeOBebamaForm informacijeOBebamaForm = new InformacijeOBebamaForm(prijavljenaMajka);
            informacijeOBebamaForm.ShowDialog();
        }

        private void dnevnikButton_Click(object sender, EventArgs e)
        {
            DnevnikForm dnevnikForm = new DnevnikForm(prijavljenaMajka);
            dnevnikForm.ShowDialog();
        }

        private void dodatciPrehraniButton_Click(object sender, EventArgs e)
        {
            EvidencijaDodatakaPrehraniForm evidencijaDodatakaPrehraniForm = new EvidencijaDodatakaPrehraniForm(prijavljenaMajka);
            evidencijaDodatakaPrehraniForm.ShowDialog();
        }

        private void treningButton_Click(object sender, EventArgs e)
        {
            EvidencijaTreningaForm evidencijaTreningaForm = new EvidencijaTreningaForm(prijavljenaMajka);
            evidencijaTreningaForm.ShowDialog();
        }

        private void doktorButton_Click(object sender, EventArgs e)
        {
            DoktorForm doktorForm = new DoktorForm(prijavljenaMajka);
            doktorForm.ShowDialog();
        }

        private void pregledButton_Click(object sender, EventArgs e)
        {
            PreglediForm preglediForm = new PreglediForm(prijavljenaMajka);
            preglediForm.ShowDialog();
        }
    }
}
