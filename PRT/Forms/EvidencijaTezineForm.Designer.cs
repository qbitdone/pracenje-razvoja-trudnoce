
namespace PRT.Forms
{
    partial class EvidencijaTezineForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EvidencijaTezineForm));
            this.moTrackerLabel = new System.Windows.Forms.Label();
            this.prikazTezineDataGridView = new System.Windows.Forms.DataGridView();
            this.obrisiZapisButton = new System.Windows.Forms.Button();
            this.dodajZapisButton = new System.Windows.Forms.Button();
            this.datum_pocetak = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dohvatiAkutalniButton = new System.Windows.Forms.Button();
            this.tezinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zapistezineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.prikazTezineDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zapistezineBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // moTrackerLabel
            // 
            this.moTrackerLabel.AutoSize = true;
            this.moTrackerLabel.BackColor = System.Drawing.Color.Transparent;
            this.moTrackerLabel.Font = new System.Drawing.Font("Segoe Print", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moTrackerLabel.Location = new System.Drawing.Point(32, 19);
            this.moTrackerLabel.Name = "moTrackerLabel";
            this.moTrackerLabel.Size = new System.Drawing.Size(341, 64);
            this.moTrackerLabel.TabIndex = 3;
            this.moTrackerLabel.Text = "Evidencija težine";
            // 
            // prikazTezineDataGridView
            // 
            this.prikazTezineDataGridView.AllowUserToAddRows = false;
            this.prikazTezineDataGridView.AllowUserToDeleteRows = false;
            this.prikazTezineDataGridView.AutoGenerateColumns = false;
            this.prikazTezineDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.prikazTezineDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prikazTezineDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.datum_pocetak,
            this.tezinaDataGridViewTextBoxColumn});
            this.prikazTezineDataGridView.DataSource = this.zapistezineBindingSource;
            this.prikazTezineDataGridView.Location = new System.Drawing.Point(43, 104);
            this.prikazTezineDataGridView.Name = "prikazTezineDataGridView";
            this.prikazTezineDataGridView.ReadOnly = true;
            this.prikazTezineDataGridView.Size = new System.Drawing.Size(300, 150);
            this.prikazTezineDataGridView.TabIndex = 4;
            // 
            // obrisiZapisButton
            // 
            this.obrisiZapisButton.BackColor = System.Drawing.Color.White;
            this.obrisiZapisButton.Location = new System.Drawing.Point(43, 287);
            this.obrisiZapisButton.Name = "obrisiZapisButton";
            this.obrisiZapisButton.Size = new System.Drawing.Size(136, 54);
            this.obrisiZapisButton.TabIndex = 5;
            this.obrisiZapisButton.Text = "Obriši Zapis";
            this.obrisiZapisButton.UseVisualStyleBackColor = false;
            this.obrisiZapisButton.Click += new System.EventHandler(this.obrisiZapisButton_Click);
            // 
            // dodajZapisButton
            // 
            this.dodajZapisButton.BackColor = System.Drawing.Color.White;
            this.dodajZapisButton.Location = new System.Drawing.Point(207, 287);
            this.dodajZapisButton.Name = "dodajZapisButton";
            this.dodajZapisButton.Size = new System.Drawing.Size(136, 54);
            this.dodajZapisButton.TabIndex = 6;
            this.dodajZapisButton.Text = "Dodaj Novi Zapis";
            this.dodajZapisButton.UseVisualStyleBackColor = false;
            this.dodajZapisButton.Click += new System.EventHandler(this.dodajZapisButton_Click);
            // 
            // datum_pocetak
            // 
            this.datum_pocetak.DataPropertyName = "datum_pocetak";
            this.datum_pocetak.HeaderText = "Datum Zapisa";
            this.datum_pocetak.Name = "datum_pocetak";
            this.datum_pocetak.ReadOnly = true;
            // 
            // dohvatiAkutalniButton
            // 
            this.dohvatiAkutalniButton.BackColor = System.Drawing.Color.White;
            this.dohvatiAkutalniButton.Location = new System.Drawing.Point(119, 370);
            this.dohvatiAkutalniButton.Name = "dohvatiAkutalniButton";
            this.dohvatiAkutalniButton.Size = new System.Drawing.Size(136, 54);
            this.dohvatiAkutalniButton.TabIndex = 12;
            this.dohvatiAkutalniButton.Text = "Dohvati Aktulani Zapis";
            this.dohvatiAkutalniButton.UseVisualStyleBackColor = false;
            this.dohvatiAkutalniButton.Click += new System.EventHandler(this.dohvatiAkutalniButton_Click);
            // 
            // tezinaDataGridViewTextBoxColumn
            // 
            this.tezinaDataGridViewTextBoxColumn.DataPropertyName = "tezina";
            this.tezinaDataGridViewTextBoxColumn.HeaderText = "Tezina";
            this.tezinaDataGridViewTextBoxColumn.Name = "tezinaDataGridViewTextBoxColumn";
            this.tezinaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // zapistezineBindingSource
            // 
            this.zapistezineBindingSource.DataSource = typeof(PRT.zapis_tezine);
            // 
            // EvidencijaTezineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(395, 436);
            this.Controls.Add(this.dohvatiAkutalniButton);
            this.Controls.Add(this.dodajZapisButton);
            this.Controls.Add(this.obrisiZapisButton);
            this.Controls.Add(this.prikazTezineDataGridView);
            this.Controls.Add(this.moTrackerLabel);
            this.Name = "EvidencijaTezineForm";
            this.Text = "moTracker";
            this.Load += new System.EventHandler(this.EvidencijaTezineForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prikazTezineDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zapistezineBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label moTrackerLabel;
        private System.Windows.Forms.DataGridView prikazTezineDataGridView;
        private System.Windows.Forms.Button obrisiZapisButton;
        private System.Windows.Forms.Button dodajZapisButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource zapistezineBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn datum_pocetak;
        private System.Windows.Forms.DataGridViewTextBoxColumn tezinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button dohvatiAkutalniButton;
    }
}