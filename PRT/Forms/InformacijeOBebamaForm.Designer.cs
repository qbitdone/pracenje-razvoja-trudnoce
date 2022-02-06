
namespace PRT.Forms
{
    partial class InformacijeOBebamaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InformacijeOBebamaForm));
            this.dodajZapisButton = new System.Windows.Forms.Button();
            this.obrisiZapisButton = new System.Windows.Forms.Button();
            this.prikazBebaDataGridView = new System.Windows.Forms.DataGridView();
            this.bebaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.moTrackerLabel = new System.Windows.Forms.Label();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datum_zaceca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datum_poroda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.prikazBebaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bebaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dodajZapisButton
            // 
            this.dodajZapisButton.BackColor = System.Drawing.Color.White;
            this.dodajZapisButton.Location = new System.Drawing.Point(195, 289);
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
            this.obrisiZapisButton.Location = new System.Drawing.Point(31, 289);
            this.obrisiZapisButton.Name = "obrisiZapisButton";
            this.obrisiZapisButton.Size = new System.Drawing.Size(136, 54);
            this.obrisiZapisButton.TabIndex = 13;
            this.obrisiZapisButton.Text = "Obriši Zapis";
            this.obrisiZapisButton.UseVisualStyleBackColor = false;
            this.obrisiZapisButton.Click += new System.EventHandler(this.obrisiZapisButton_Click);
            // 
            // prikazBebaDataGridView
            // 
            this.prikazBebaDataGridView.AllowUserToAddRows = false;
            this.prikazBebaDataGridView.AllowUserToDeleteRows = false;
            this.prikazBebaDataGridView.AutoGenerateColumns = false;
            this.prikazBebaDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.prikazBebaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prikazBebaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.imeDataGridViewTextBoxColumn,
            this.prezimeDataGridViewTextBoxColumn,
            this.spolDataGridViewTextBoxColumn,
            this.datum_zaceca,
            this.datum_poroda});
            this.prikazBebaDataGridView.DataSource = this.bebaBindingSource;
            this.prikazBebaDataGridView.Location = new System.Drawing.Point(31, 106);
            this.prikazBebaDataGridView.Name = "prikazBebaDataGridView";
            this.prikazBebaDataGridView.ReadOnly = true;
            this.prikazBebaDataGridView.Size = new System.Drawing.Size(300, 150);
            this.prikazBebaDataGridView.TabIndex = 12;
            // 
            // bebaBindingSource
            // 
            this.bebaBindingSource.DataSource = typeof(PRT.beba);
            // 
            // moTrackerLabel
            // 
            this.moTrackerLabel.AutoSize = true;
            this.moTrackerLabel.BackColor = System.Drawing.Color.Transparent;
            this.moTrackerLabel.Font = new System.Drawing.Font("Segoe Print", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moTrackerLabel.Location = new System.Drawing.Point(123, 20);
            this.moTrackerLabel.Name = "moTrackerLabel";
            this.moTrackerLabel.Size = new System.Drawing.Size(115, 64);
            this.moTrackerLabel.TabIndex = 11;
            this.moTrackerLabel.Text = "Bebe";
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "ime";
            this.imeDataGridViewTextBoxColumn.HeaderText = "Ime";
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            this.imeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prezimeDataGridViewTextBoxColumn
            // 
            this.prezimeDataGridViewTextBoxColumn.DataPropertyName = "prezime";
            this.prezimeDataGridViewTextBoxColumn.HeaderText = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.Name = "prezimeDataGridViewTextBoxColumn";
            this.prezimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // spolDataGridViewTextBoxColumn
            // 
            this.spolDataGridViewTextBoxColumn.DataPropertyName = "spol";
            this.spolDataGridViewTextBoxColumn.HeaderText = "Spol";
            this.spolDataGridViewTextBoxColumn.Name = "spolDataGridViewTextBoxColumn";
            this.spolDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datum_zaceca
            // 
            this.datum_zaceca.DataPropertyName = "datum_zaceca";
            this.datum_zaceca.HeaderText = "Datum Začeća";
            this.datum_zaceca.Name = "datum_zaceca";
            this.datum_zaceca.ReadOnly = true;
            // 
            // datum_poroda
            // 
            this.datum_poroda.DataPropertyName = "datum_poroda";
            this.datum_poroda.HeaderText = "Datum Poroda";
            this.datum_poroda.Name = "datum_poroda";
            this.datum_poroda.ReadOnly = true;
            // 
            // InformacijeOBebamaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(374, 365);
            this.Controls.Add(this.dodajZapisButton);
            this.Controls.Add(this.obrisiZapisButton);
            this.Controls.Add(this.prikazBebaDataGridView);
            this.Controls.Add(this.moTrackerLabel);
            this.Name = "InformacijeOBebamaForm";
            this.Text = "moTracker";
            this.Load += new System.EventHandler(this.InformacijeOBebamaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prikazBebaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bebaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dodajZapisButton;
        private System.Windows.Forms.Button obrisiZapisButton;
        private System.Windows.Forms.DataGridView prikazBebaDataGridView;
        private System.Windows.Forms.Label moTrackerLabel;
        private System.Windows.Forms.BindingSource bebaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn spolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datum_zaceca;
        private System.Windows.Forms.DataGridViewTextBoxColumn datum_poroda;
    }
}