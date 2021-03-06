
namespace PRT.Forms
{
    partial class EvidencijaTreningaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EvidencijaTreningaForm));
            this.dodajZapisButton = new System.Windows.Forms.Button();
            this.obrisiZapisButton = new System.Windows.Forms.Button();
            this.prikazTreningaDataGridView = new System.Windows.Forms.DataGridView();
            this.moTrackerLabel = new System.Windows.Forms.Label();
            this.treningBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrstatreningaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.biljeskeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrijeme_pocetak = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrijeme_kraj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.prikazTreningaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treningBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dodajZapisButton
            // 
            this.dodajZapisButton.BackColor = System.Drawing.Color.White;
            this.dodajZapisButton.Location = new System.Drawing.Point(202, 289);
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
            this.obrisiZapisButton.Location = new System.Drawing.Point(38, 289);
            this.obrisiZapisButton.Name = "obrisiZapisButton";
            this.obrisiZapisButton.Size = new System.Drawing.Size(136, 54);
            this.obrisiZapisButton.TabIndex = 9;
            this.obrisiZapisButton.Text = "Obriši Zapis";
            this.obrisiZapisButton.UseVisualStyleBackColor = false;
            this.obrisiZapisButton.Click += new System.EventHandler(this.obrisiZapisButton_Click);
            // 
            // prikazTreningaDataGridView
            // 
            this.prikazTreningaDataGridView.AllowUserToAddRows = false;
            this.prikazTreningaDataGridView.AllowUserToDeleteRows = false;
            this.prikazTreningaDataGridView.AutoGenerateColumns = false;
            this.prikazTreningaDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.prikazTreningaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prikazTreningaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.datumDataGridViewTextBoxColumn,
            this.vrstatreningaDataGridViewTextBoxColumn,
            this.biljeskeDataGridViewTextBoxColumn,
            this.vrijeme_pocetak,
            this.vrijeme_kraj});
            this.prikazTreningaDataGridView.DataSource = this.treningBindingSource;
            this.prikazTreningaDataGridView.Location = new System.Drawing.Point(38, 106);
            this.prikazTreningaDataGridView.Name = "prikazTreningaDataGridView";
            this.prikazTreningaDataGridView.ReadOnly = true;
            this.prikazTreningaDataGridView.Size = new System.Drawing.Size(300, 150);
            this.prikazTreningaDataGridView.TabIndex = 8;
            // 
            // moTrackerLabel
            // 
            this.moTrackerLabel.AutoSize = true;
            this.moTrackerLabel.BackColor = System.Drawing.Color.Transparent;
            this.moTrackerLabel.Font = new System.Drawing.Font("Segoe Print", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moTrackerLabel.Location = new System.Drawing.Point(3, 21);
            this.moTrackerLabel.Name = "moTrackerLabel";
            this.moTrackerLabel.Size = new System.Drawing.Size(390, 64);
            this.moTrackerLabel.TabIndex = 7;
            this.moTrackerLabel.Text = "Evidencija treninga";
            // 
            // treningBindingSource
            // 
            this.treningBindingSource.DataSource = typeof(PRT.trening);
            // 
            // datumDataGridViewTextBoxColumn
            // 
            this.datumDataGridViewTextBoxColumn.DataPropertyName = "datum";
            this.datumDataGridViewTextBoxColumn.HeaderText = "Datum";
            this.datumDataGridViewTextBoxColumn.Name = "datumDataGridViewTextBoxColumn";
            this.datumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vrstatreningaDataGridViewTextBoxColumn
            // 
            this.vrstatreningaDataGridViewTextBoxColumn.DataPropertyName = "vrsta_treninga";
            this.vrstatreningaDataGridViewTextBoxColumn.HeaderText = "Vrsta Treninga";
            this.vrstatreningaDataGridViewTextBoxColumn.Name = "vrstatreningaDataGridViewTextBoxColumn";
            this.vrstatreningaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // biljeskeDataGridViewTextBoxColumn
            // 
            this.biljeskeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.biljeskeDataGridViewTextBoxColumn.DataPropertyName = "biljeske";
            this.biljeskeDataGridViewTextBoxColumn.HeaderText = "Bilješke";
            this.biljeskeDataGridViewTextBoxColumn.Name = "biljeskeDataGridViewTextBoxColumn";
            this.biljeskeDataGridViewTextBoxColumn.ReadOnly = true;
            this.biljeskeDataGridViewTextBoxColumn.Width = 68;
            // 
            // vrijeme_pocetak
            // 
            this.vrijeme_pocetak.DataPropertyName = "vrijeme_pocetak";
            this.vrijeme_pocetak.HeaderText = "Vrijeme Početak";
            this.vrijeme_pocetak.Name = "vrijeme_pocetak";
            this.vrijeme_pocetak.ReadOnly = true;
            // 
            // vrijeme_kraj
            // 
            this.vrijeme_kraj.DataPropertyName = "vrijeme_kraj";
            this.vrijeme_kraj.HeaderText = "Vrijeme Kraj";
            this.vrijeme_kraj.Name = "vrijeme_kraj";
            this.vrijeme_kraj.ReadOnly = true;
            // 
            // EvidencijaTreningaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(395, 365);
            this.Controls.Add(this.dodajZapisButton);
            this.Controls.Add(this.obrisiZapisButton);
            this.Controls.Add(this.prikazTreningaDataGridView);
            this.Controls.Add(this.moTrackerLabel);
            this.Name = "EvidencijaTreningaForm";
            this.Text = "moTracker";
            this.Load += new System.EventHandler(this.EvidencijaTreningaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prikazTreningaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treningBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dodajZapisButton;
        private System.Windows.Forms.Button obrisiZapisButton;
        private System.Windows.Forms.DataGridView prikazTreningaDataGridView;
        private System.Windows.Forms.Label moTrackerLabel;
        private System.Windows.Forms.BindingSource treningBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrstatreningaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn biljeskeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrijeme_pocetak;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrijeme_kraj;
    }
}