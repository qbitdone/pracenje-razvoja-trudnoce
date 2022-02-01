
namespace PRT.Forms
{
    partial class DnevnikForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DnevnikForm));
            this.moTrackerLabel = new System.Windows.Forms.Label();
            this.prikazDnevnikaDataGridView = new System.Windows.Forms.DataGridView();
            this.dodajZapisButton = new System.Windows.Forms.Button();
            this.obrisiZapisButton = new System.Windows.Forms.Button();
            this.dnevnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.naslovDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sadrzajDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumzapisaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.prikazDnevnikaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dnevnikBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // moTrackerLabel
            // 
            this.moTrackerLabel.AutoSize = true;
            this.moTrackerLabel.BackColor = System.Drawing.Color.Transparent;
            this.moTrackerLabel.Font = new System.Drawing.Font("Segoe Print", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moTrackerLabel.Location = new System.Drawing.Point(278, 25);
            this.moTrackerLabel.Name = "moTrackerLabel";
            this.moTrackerLabel.Size = new System.Drawing.Size(179, 64);
            this.moTrackerLabel.TabIndex = 16;
            this.moTrackerLabel.Text = "Dnevnik";
            // 
            // prikazDnevnikaDataGridView
            // 
            this.prikazDnevnikaDataGridView.AllowUserToAddRows = false;
            this.prikazDnevnikaDataGridView.AllowUserToDeleteRows = false;
            this.prikazDnevnikaDataGridView.AutoGenerateColumns = false;
            this.prikazDnevnikaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prikazDnevnikaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.naslovDataGridViewTextBoxColumn,
            this.sadrzajDataGridViewTextBoxColumn,
            this.datumzapisaDataGridViewTextBoxColumn});
            this.prikazDnevnikaDataGridView.DataSource = this.dnevnikBindingSource;
            this.prikazDnevnikaDataGridView.Location = new System.Drawing.Point(40, 109);
            this.prikazDnevnikaDataGridView.Name = "prikazDnevnikaDataGridView";
            this.prikazDnevnikaDataGridView.ReadOnly = true;
            this.prikazDnevnikaDataGridView.Size = new System.Drawing.Size(677, 211);
            this.prikazDnevnikaDataGridView.TabIndex = 17;
            // 
            // dodajZapisButton
            // 
            this.dodajZapisButton.BackColor = System.Drawing.Color.White;
            this.dodajZapisButton.Location = new System.Drawing.Point(374, 334);
            this.dodajZapisButton.Name = "dodajZapisButton";
            this.dodajZapisButton.Size = new System.Drawing.Size(136, 54);
            this.dodajZapisButton.TabIndex = 19;
            this.dodajZapisButton.Text = "Dodaj Novi Zapis";
            this.dodajZapisButton.UseVisualStyleBackColor = false;
            this.dodajZapisButton.Click += new System.EventHandler(this.dodajZapisButton_Click);
            // 
            // obrisiZapisButton
            // 
            this.obrisiZapisButton.BackColor = System.Drawing.Color.White;
            this.obrisiZapisButton.Location = new System.Drawing.Point(210, 334);
            this.obrisiZapisButton.Name = "obrisiZapisButton";
            this.obrisiZapisButton.Size = new System.Drawing.Size(136, 54);
            this.obrisiZapisButton.TabIndex = 18;
            this.obrisiZapisButton.Text = "Obriši Zapis";
            this.obrisiZapisButton.UseVisualStyleBackColor = false;
            this.obrisiZapisButton.Click += new System.EventHandler(this.obrisiZapisButton_Click);
            // 
            // dnevnikBindingSource
            // 
            this.dnevnikBindingSource.DataSource = typeof(PRT.dnevnik);
            // 
            // naslovDataGridViewTextBoxColumn
            // 
            this.naslovDataGridViewTextBoxColumn.DataPropertyName = "naslov";
            this.naslovDataGridViewTextBoxColumn.HeaderText = "Naslov";
            this.naslovDataGridViewTextBoxColumn.Name = "naslovDataGridViewTextBoxColumn";
            this.naslovDataGridViewTextBoxColumn.ReadOnly = true;
            this.naslovDataGridViewTextBoxColumn.Width = 150;
            // 
            // sadrzajDataGridViewTextBoxColumn
            // 
            this.sadrzajDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sadrzajDataGridViewTextBoxColumn.DataPropertyName = "sadrzaj";
            this.sadrzajDataGridViewTextBoxColumn.HeaderText = "Sadržaj";
            this.sadrzajDataGridViewTextBoxColumn.Name = "sadrzajDataGridViewTextBoxColumn";
            this.sadrzajDataGridViewTextBoxColumn.ReadOnly = true;
            this.sadrzajDataGridViewTextBoxColumn.Width = 67;
            // 
            // datumzapisaDataGridViewTextBoxColumn
            // 
            this.datumzapisaDataGridViewTextBoxColumn.DataPropertyName = "datum_zapisa";
            this.datumzapisaDataGridViewTextBoxColumn.HeaderText = "Datum Zapisa";
            this.datumzapisaDataGridViewTextBoxColumn.Name = "datumzapisaDataGridViewTextBoxColumn";
            this.datumzapisaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // DnevnikForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(769, 400);
            this.Controls.Add(this.dodajZapisButton);
            this.Controls.Add(this.obrisiZapisButton);
            this.Controls.Add(this.prikazDnevnikaDataGridView);
            this.Controls.Add(this.moTrackerLabel);
            this.Name = "DnevnikForm";
            this.Text = "moTracker";
            this.Load += new System.EventHandler(this.DnevnikForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prikazDnevnikaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dnevnikBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label moTrackerLabel;
        private System.Windows.Forms.DataGridView prikazDnevnikaDataGridView;
        private System.Windows.Forms.Button dodajZapisButton;
        private System.Windows.Forms.Button obrisiZapisButton;
        private System.Windows.Forms.BindingSource dnevnikBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn naslovDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sadrzajDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumzapisaDataGridViewTextBoxColumn;
    }
}