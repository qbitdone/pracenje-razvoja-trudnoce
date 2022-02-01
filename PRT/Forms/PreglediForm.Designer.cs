
namespace PRT.Forms
{
    partial class PreglediForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PreglediForm));
            this.dodajZapisButton = new System.Windows.Forms.Button();
            this.obrisiZapisButton = new System.Windows.Forms.Button();
            this.prikazPregledaDataGridView = new System.Windows.Forms.DataGridView();
            this.moTrackerLabel = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pregledBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datumpregledaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sazetakDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.prikazPregledaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pregledBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dodajZapisButton
            // 
            this.dodajZapisButton.BackColor = System.Drawing.Color.White;
            this.dodajZapisButton.Location = new System.Drawing.Point(199, 290);
            this.dodajZapisButton.Name = "dodajZapisButton";
            this.dodajZapisButton.Size = new System.Drawing.Size(136, 54);
            this.dodajZapisButton.TabIndex = 14;
            this.dodajZapisButton.Text = "Dodaj Novi Zapis";
            this.dodajZapisButton.UseVisualStyleBackColor = false;
            this.dodajZapisButton.Click += new System.EventHandler(this.dodajZapisButton_Click);
            // 
            // obrisiZapisButton
            // 
            this.obrisiZapisButton.BackColor = System.Drawing.Color.White;
            this.obrisiZapisButton.Location = new System.Drawing.Point(35, 290);
            this.obrisiZapisButton.Name = "obrisiZapisButton";
            this.obrisiZapisButton.Size = new System.Drawing.Size(136, 54);
            this.obrisiZapisButton.TabIndex = 13;
            this.obrisiZapisButton.Text = "Obriši Zapis";
            this.obrisiZapisButton.UseVisualStyleBackColor = false;
            this.obrisiZapisButton.Click += new System.EventHandler(this.obrisiZapisButton_Click);
            // 
            // prikazPregledaDataGridView
            // 
            this.prikazPregledaDataGridView.AllowUserToAddRows = false;
            this.prikazPregledaDataGridView.AllowUserToDeleteRows = false;
            this.prikazPregledaDataGridView.AutoGenerateColumns = false;
            this.prikazPregledaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prikazPregledaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.datumpregledaDataGridViewTextBoxColumn,
            this.sazetakDataGridViewTextBoxColumn});
            this.prikazPregledaDataGridView.DataSource = this.pregledBindingSource;
            this.prikazPregledaDataGridView.Location = new System.Drawing.Point(35, 107);
            this.prikazPregledaDataGridView.Name = "prikazPregledaDataGridView";
            this.prikazPregledaDataGridView.ReadOnly = true;
            this.prikazPregledaDataGridView.Size = new System.Drawing.Size(300, 150);
            this.prikazPregledaDataGridView.TabIndex = 12;
            // 
            // moTrackerLabel
            // 
            this.moTrackerLabel.AutoSize = true;
            this.moTrackerLabel.BackColor = System.Drawing.Color.Transparent;
            this.moTrackerLabel.Font = new System.Drawing.Font("Segoe Print", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moTrackerLabel.Location = new System.Drawing.Point(91, 19);
            this.moTrackerLabel.Name = "moTrackerLabel";
            this.moTrackerLabel.Size = new System.Drawing.Size(178, 64);
            this.moTrackerLabel.TabIndex = 11;
            this.moTrackerLabel.Text = "Pregledi";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "majka_doktor";
            this.dataGridViewTextBoxColumn1.HeaderText = "majka_doktor";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // pregledBindingSource
            // 
            this.pregledBindingSource.DataSource = typeof(PRT.pregled);
            // 
            // datumpregledaDataGridViewTextBoxColumn
            // 
            this.datumpregledaDataGridViewTextBoxColumn.DataPropertyName = "datum_pregleda";
            this.datumpregledaDataGridViewTextBoxColumn.HeaderText = "Datum Pregleda";
            this.datumpregledaDataGridViewTextBoxColumn.Name = "datumpregledaDataGridViewTextBoxColumn";
            this.datumpregledaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sazetakDataGridViewTextBoxColumn
            // 
            this.sazetakDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sazetakDataGridViewTextBoxColumn.DataPropertyName = "sazetak";
            this.sazetakDataGridViewTextBoxColumn.HeaderText = "Sažetak";
            this.sazetakDataGridViewTextBoxColumn.Name = "sazetakDataGridViewTextBoxColumn";
            this.sazetakDataGridViewTextBoxColumn.ReadOnly = true;
            this.sazetakDataGridViewTextBoxColumn.Width = 71;
            // 
            // PreglediForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(388, 365);
            this.Controls.Add(this.dodajZapisButton);
            this.Controls.Add(this.obrisiZapisButton);
            this.Controls.Add(this.prikazPregledaDataGridView);
            this.Controls.Add(this.moTrackerLabel);
            this.Name = "PreglediForm";
            this.Text = "moTracker";
            this.Load += new System.EventHandler(this.PreglediForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prikazPregledaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pregledBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dodajZapisButton;
        private System.Windows.Forms.Button obrisiZapisButton;
        private System.Windows.Forms.DataGridView prikazPregledaDataGridView;
        private System.Windows.Forms.Label moTrackerLabel;
        private System.Windows.Forms.BindingSource pregledBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumpregledaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sazetakDataGridViewTextBoxColumn;
    }
}