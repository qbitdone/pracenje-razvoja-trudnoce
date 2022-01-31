
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EvidencijaTezineForm));
            this.moTrackerLabel = new System.Windows.Forms.Label();
            this.prikazTezineDataGridView = new System.Windows.Forms.DataGridView();
            this.obrisiZapisButton = new System.Windows.Forms.Button();
            this.dodajZapisButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.prikazTezineDataGridView)).BeginInit();
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
            this.prikazTezineDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prikazTezineDataGridView.Location = new System.Drawing.Point(43, 104);
            this.prikazTezineDataGridView.Name = "prikazTezineDataGridView";
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
            // EvidencijaTezineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(395, 365);
            this.Controls.Add(this.dodajZapisButton);
            this.Controls.Add(this.obrisiZapisButton);
            this.Controls.Add(this.prikazTezineDataGridView);
            this.Controls.Add(this.moTrackerLabel);
            this.Name = "EvidencijaTezineForm";
            this.Text = "moTracker";
            this.Load += new System.EventHandler(this.EvidencijaTezineForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prikazTezineDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label moTrackerLabel;
        private System.Windows.Forms.DataGridView prikazTezineDataGridView;
        private System.Windows.Forms.Button obrisiZapisButton;
        private System.Windows.Forms.Button dodajZapisButton;
    }
}