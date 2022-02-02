
namespace PRT.Forms
{
    partial class EvidencijaOpsegaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EvidencijaOpsegaForm));
            this.dodajZapisButton = new System.Windows.Forms.Button();
            this.obrisiZapisButton = new System.Windows.Forms.Button();
            this.prikazOpsegaDataGridView = new System.Windows.Forms.DataGridView();
            this.moTrackerLabel = new System.Windows.Forms.Label();
            this.datumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opsegDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zapisopsegaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.prikazOpsegaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zapisopsegaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dodajZapisButton
            // 
            this.dodajZapisButton.BackColor = System.Drawing.Color.White;
            this.dodajZapisButton.Location = new System.Drawing.Point(202, 289);
            this.dodajZapisButton.Name = "dodajZapisButton";
            this.dodajZapisButton.Size = new System.Drawing.Size(136, 54);
            this.dodajZapisButton.TabIndex = 10;
            this.dodajZapisButton.Text = "Dodaj Zapis";
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
            // prikazOpsegaDataGridView
            // 
            this.prikazOpsegaDataGridView.AllowUserToAddRows = false;
            this.prikazOpsegaDataGridView.AllowUserToDeleteRows = false;
            this.prikazOpsegaDataGridView.AutoGenerateColumns = false;
            this.prikazOpsegaDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.prikazOpsegaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prikazOpsegaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.datumDataGridViewTextBoxColumn,
            this.opsegDataGridViewTextBoxColumn});
            this.prikazOpsegaDataGridView.DataSource = this.zapisopsegaBindingSource;
            this.prikazOpsegaDataGridView.Location = new System.Drawing.Point(38, 106);
            this.prikazOpsegaDataGridView.Name = "prikazOpsegaDataGridView";
            this.prikazOpsegaDataGridView.ReadOnly = true;
            this.prikazOpsegaDataGridView.Size = new System.Drawing.Size(300, 150);
            this.prikazOpsegaDataGridView.TabIndex = 8;
            // 
            // moTrackerLabel
            // 
            this.moTrackerLabel.AutoSize = true;
            this.moTrackerLabel.BackColor = System.Drawing.Color.Transparent;
            this.moTrackerLabel.Font = new System.Drawing.Font("Segoe Print", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moTrackerLabel.Location = new System.Drawing.Point(20, 9);
            this.moTrackerLabel.Name = "moTrackerLabel";
            this.moTrackerLabel.Size = new System.Drawing.Size(363, 64);
            this.moTrackerLabel.TabIndex = 7;
            this.moTrackerLabel.Text = "Evidencija Opsega";
            // 
            // datumDataGridViewTextBoxColumn
            // 
            this.datumDataGridViewTextBoxColumn.DataPropertyName = "datum";
            this.datumDataGridViewTextBoxColumn.HeaderText = "Datum";
            this.datumDataGridViewTextBoxColumn.Name = "datumDataGridViewTextBoxColumn";
            this.datumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // opsegDataGridViewTextBoxColumn
            // 
            this.opsegDataGridViewTextBoxColumn.DataPropertyName = "opseg";
            this.opsegDataGridViewTextBoxColumn.HeaderText = "Opseg";
            this.opsegDataGridViewTextBoxColumn.Name = "opsegDataGridViewTextBoxColumn";
            this.opsegDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // zapisopsegaBindingSource
            // 
            this.zapisopsegaBindingSource.DataSource = typeof(PRT.zapis_opsega);
            // 
            // EvidencijaOpsegaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(395, 365);
            this.Controls.Add(this.dodajZapisButton);
            this.Controls.Add(this.obrisiZapisButton);
            this.Controls.Add(this.prikazOpsegaDataGridView);
            this.Controls.Add(this.moTrackerLabel);
            this.Name = "EvidencijaOpsegaForm";
            this.Text = "moTracker";
            this.Load += new System.EventHandler(this.EvidencijaOpsegaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prikazOpsegaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zapisopsegaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dodajZapisButton;
        private System.Windows.Forms.Button obrisiZapisButton;
        private System.Windows.Forms.DataGridView prikazOpsegaDataGridView;
        private System.Windows.Forms.Label moTrackerLabel;
        private System.Windows.Forms.BindingSource zapisopsegaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opsegDataGridViewTextBoxColumn;
    }
}