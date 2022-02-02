
namespace PRT.Forms
{
    partial class EvidencijaDodatakaPrehraniForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EvidencijaDodatakaPrehraniForm));
            this.dodajZapisButton = new System.Windows.Forms.Button();
            this.obrisiZapisButton = new System.Windows.Forms.Button();
            this.prikazDodatakaDataGridView = new System.Windows.Forms.DataGridView();
            this.moTrackerLabel = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dodatak_prehrani = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumuzimanjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.majkadodatakprehraniBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.prikazDodatakaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.majkadodatakprehraniBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dodajZapisButton
            // 
            this.dodajZapisButton.BackColor = System.Drawing.Color.White;
            this.dodajZapisButton.Location = new System.Drawing.Point(205, 289);
            this.dodajZapisButton.Name = "dodajZapisButton";
            this.dodajZapisButton.Size = new System.Drawing.Size(136, 54);
            this.dodajZapisButton.TabIndex = 10;
            this.dodajZapisButton.Text = "Dodaj Novi Zapis";
            this.dodajZapisButton.UseVisualStyleBackColor = false;
            this.dodajZapisButton.Click += new System.EventHandler(this.dodajZapisButton_Click);
            // 
            // obrisiZapisButton
            // 
            this.obrisiZapisButton.BackColor = System.Drawing.Color.White;
            this.obrisiZapisButton.Location = new System.Drawing.Point(41, 289);
            this.obrisiZapisButton.Name = "obrisiZapisButton";
            this.obrisiZapisButton.Size = new System.Drawing.Size(136, 54);
            this.obrisiZapisButton.TabIndex = 9;
            this.obrisiZapisButton.Text = "Obriši Zapis";
            this.obrisiZapisButton.UseVisualStyleBackColor = false;
            this.obrisiZapisButton.Click += new System.EventHandler(this.obrisiZapisButton_Click);
            // 
            // prikazDodatakaDataGridView
            // 
            this.prikazDodatakaDataGridView.AllowUserToAddRows = false;
            this.prikazDodatakaDataGridView.AllowUserToDeleteRows = false;
            this.prikazDodatakaDataGridView.AutoGenerateColumns = false;
            this.prikazDodatakaDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.prikazDodatakaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prikazDodatakaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dodatak_prehrani,
            this.kolicinaDataGridViewTextBoxColumn,
            this.datumuzimanjaDataGridViewTextBoxColumn});
            this.prikazDodatakaDataGridView.DataSource = this.majkadodatakprehraniBindingSource;
            this.prikazDodatakaDataGridView.Location = new System.Drawing.Point(41, 106);
            this.prikazDodatakaDataGridView.Name = "prikazDodatakaDataGridView";
            this.prikazDodatakaDataGridView.ReadOnly = true;
            this.prikazDodatakaDataGridView.Size = new System.Drawing.Size(300, 150);
            this.prikazDodatakaDataGridView.TabIndex = 8;
            // 
            // moTrackerLabel
            // 
            this.moTrackerLabel.AutoSize = true;
            this.moTrackerLabel.BackColor = System.Drawing.Color.Transparent;
            this.moTrackerLabel.Font = new System.Drawing.Font("Segoe Print", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moTrackerLabel.Location = new System.Drawing.Point(-5, 20);
            this.moTrackerLabel.Name = "moTrackerLabel";
            this.moTrackerLabel.Size = new System.Drawing.Size(410, 64);
            this.moTrackerLabel.TabIndex = 7;
            this.moTrackerLabel.Text = "Evidencija Dodataka";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "dodatak_prehrani";
            this.dataGridViewTextBoxColumn1.HeaderText = "dodatak_prehrani";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "dodatak_prehrani";
            this.dataGridViewTextBoxColumn2.HeaderText = "dodatak_prehrani";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "dodatak_prehrani";
            this.dataGridViewTextBoxColumn3.HeaderText = "Dodatak";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dodatak_prehrani
            // 
            this.dodatak_prehrani.DataPropertyName = "dodatak_prehrani";
            this.dodatak_prehrani.HeaderText = "Dodatak";
            this.dodatak_prehrani.Name = "dodatak_prehrani";
            this.dodatak_prehrani.ReadOnly = true;
            // 
            // kolicinaDataGridViewTextBoxColumn
            // 
            this.kolicinaDataGridViewTextBoxColumn.DataPropertyName = "kolicina";
            this.kolicinaDataGridViewTextBoxColumn.HeaderText = "Količina";
            this.kolicinaDataGridViewTextBoxColumn.Name = "kolicinaDataGridViewTextBoxColumn";
            this.kolicinaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datumuzimanjaDataGridViewTextBoxColumn
            // 
            this.datumuzimanjaDataGridViewTextBoxColumn.DataPropertyName = "datum_uzimanja";
            this.datumuzimanjaDataGridViewTextBoxColumn.HeaderText = "Datum Uzimanja";
            this.datumuzimanjaDataGridViewTextBoxColumn.Name = "datumuzimanjaDataGridViewTextBoxColumn";
            this.datumuzimanjaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // majkadodatakprehraniBindingSource
            // 
            this.majkadodatakprehraniBindingSource.DataSource = typeof(PRT.majka_dodatak_prehrani);
            // 
            // EvidencijaDodatakaPrehraniForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(388, 365);
            this.Controls.Add(this.dodajZapisButton);
            this.Controls.Add(this.obrisiZapisButton);
            this.Controls.Add(this.prikazDodatakaDataGridView);
            this.Controls.Add(this.moTrackerLabel);
            this.Name = "EvidencijaDodatakaPrehraniForm";
            this.Text = "moTracker";
            this.Load += new System.EventHandler(this.EvidencijaDodatakaPrehraniForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prikazDodatakaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.majkadodatakprehraniBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dodajZapisButton;
        private System.Windows.Forms.Button obrisiZapisButton;
        private System.Windows.Forms.DataGridView prikazDodatakaDataGridView;
        private System.Windows.Forms.Label moTrackerLabel;
        private System.Windows.Forms.BindingSource majkadodatakprehraniBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dodatak_prehrani;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumuzimanjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}