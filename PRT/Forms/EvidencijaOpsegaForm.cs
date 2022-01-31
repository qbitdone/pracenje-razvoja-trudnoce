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
    public partial class EvidencijaOpsegaForm : Form
    {
        private majka prijavljenaMajka;
        public EvidencijaOpsegaForm(majka prijavljenaMajka)
        {
            InitializeComponent();
            this.prijavljenaMajka = prijavljenaMajka;
            dohvatiOpsege();
        }

        private void EvidencijaOpsegaForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            moTrackerLabel.Left = (this.ClientSize.Width - moTrackerLabel.Width) / 2;
        }

        private void dodajZapisButton_Click(object sender, EventArgs e)
        {
            OpsegForm opsegForm = new OpsegForm(prijavljenaMajka, this);
            opsegForm.ShowDialog();
        }

        public void dohvatiOpsege()
        {
            using (var contex = new pregnancydbEntities())
            {
                zapisopsegaBindingSource.DataSource = null;

                List<zapis_opsega> ListaOpsega = new List<zapis_opsega>();

                var query = from k in contex.zapis_opsega
                            where k.id_majka == prijavljenaMajka.id_majka
                            select k;

                ListaOpsega = query.ToList();

                zapisopsegaBindingSource.DataSource = ListaOpsega;
            }
        }

        private void obrisiZapisButton_Click(object sender, EventArgs e)
        {
            using (var contex = new pregnancydbEntities())
            {
                zapis_opsega zapis = zapisopsegaBindingSource.Current as zapis_opsega;
                contex.zapis_opsega.Attach(zapis);
               // contex.Entry(zapis).State = System.Data.Entity.EntityState.Deleted;
                contex.zapis_opsega.Remove(zapis);
                contex.SaveChanges();

            }

            dohvatiOpsege();

        }
    }
}
