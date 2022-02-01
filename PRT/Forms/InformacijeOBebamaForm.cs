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
        private majka prijavljenaMajka;
        public InformacijeOBebamaForm(majka prijavljenaMajka)
        {
            InitializeComponent();
            this.prijavljenaMajka = prijavljenaMajka;
            dohvatiBebe();
        }

        private void dodajZapisButton_Click(object sender, EventArgs e)
        {
            BebaForm bebaForm = new BebaForm(prijavljenaMajka, this);
            bebaForm.ShowDialog();
        }

        private void InformacijeOBebamaForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            moTrackerLabel.Left = (this.ClientSize.Width - moTrackerLabel.Width) / 2;
        }

        public void dohvatiBebe()
        {
            using (var contex = new pregnancydbEntities())
            {
                var query = from k in contex.beba
                            where k.id_majka == prijavljenaMajka.id_majka
                            select k;

                bebaBindingSource.DataSource = null;
                bebaBindingSource.DataSource = query.ToList();
            }
        }

        private void obrisiZapisButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (var contex = new pregnancydbEntities())
                {
                    beba zapis = bebaBindingSource.Current as beba;
                    contex.beba.Attach(zapis);
                    // contex.Entry(zapis).State = System.Data.Entity.EntityState.Deleted;
                    contex.beba.Remove(zapis);
                    contex.SaveChanges();
                }
                dohvatiBebe();
            }
            catch
            {
                MessageBox.Show("Ne postoji zapis za brisanje");
            }
        }
    }
}
