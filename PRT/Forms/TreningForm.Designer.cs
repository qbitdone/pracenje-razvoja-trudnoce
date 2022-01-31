
namespace PRT.Forms
{
    partial class TreningForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TreningForm));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.vrstaTreningaComboBox = new System.Windows.Forms.ComboBox();
            this.spremiButton = new System.Windows.Forms.Button();
            this.odustaniButton = new System.Windows.Forms.Button();
            this.moTrackerLabel = new System.Windows.Forms.Label();
            this.sazetakTextBox = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.datumDTP = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(26, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Vrsta Treninga";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(26, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Sažetak";
            // 
            // vrstaTreningaComboBox
            // 
            this.vrstaTreningaComboBox.FormattingEnabled = true;
            this.vrstaTreningaComboBox.Location = new System.Drawing.Point(117, 133);
            this.vrstaTreningaComboBox.Name = "vrstaTreningaComboBox";
            this.vrstaTreningaComboBox.Size = new System.Drawing.Size(179, 21);
            this.vrstaTreningaComboBox.TabIndex = 24;
            // 
            // spremiButton
            // 
            this.spremiButton.BackColor = System.Drawing.Color.White;
            this.spremiButton.Location = new System.Drawing.Point(193, 364);
            this.spremiButton.Name = "spremiButton";
            this.spremiButton.Size = new System.Drawing.Size(136, 54);
            this.spremiButton.TabIndex = 23;
            this.spremiButton.Text = "Spremi";
            this.spremiButton.UseVisualStyleBackColor = false;
            // 
            // odustaniButton
            // 
            this.odustaniButton.BackColor = System.Drawing.Color.White;
            this.odustaniButton.Location = new System.Drawing.Point(24, 364);
            this.odustaniButton.Name = "odustaniButton";
            this.odustaniButton.Size = new System.Drawing.Size(136, 54);
            this.odustaniButton.TabIndex = 22;
            this.odustaniButton.Text = "Odustani";
            this.odustaniButton.UseVisualStyleBackColor = false;
            this.odustaniButton.Click += new System.EventHandler(this.odustaniButton_Click);
            // 
            // moTrackerLabel
            // 
            this.moTrackerLabel.AutoSize = true;
            this.moTrackerLabel.BackColor = System.Drawing.Color.Transparent;
            this.moTrackerLabel.Font = new System.Drawing.Font("Segoe Print", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moTrackerLabel.Location = new System.Drawing.Point(98, 25);
            this.moTrackerLabel.Name = "moTrackerLabel";
            this.moTrackerLabel.Size = new System.Drawing.Size(173, 64);
            this.moTrackerLabel.TabIndex = 21;
            this.moTrackerLabel.Text = "Trening";
            // 
            // sazetakTextBox
            // 
            this.sazetakTextBox.Location = new System.Drawing.Point(117, 186);
            this.sazetakTextBox.Name = "sazetakTextBox";
            this.sazetakTextBox.Size = new System.Drawing.Size(179, 157);
            this.sazetakTextBox.TabIndex = 28;
            this.sazetakTextBox.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(26, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Datum Treninga";
            // 
            // datumDTP
            // 
            this.datumDTP.Location = new System.Drawing.Point(117, 160);
            this.datumDTP.Name = "datumDTP";
            this.datumDTP.Size = new System.Drawing.Size(179, 20);
            this.datumDTP.TabIndex = 29;
            // 
            // TreningForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(356, 430);
            this.Controls.Add(this.datumDTP);
            this.Controls.Add(this.sazetakTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vrstaTreningaComboBox);
            this.Controls.Add(this.spremiButton);
            this.Controls.Add(this.odustaniButton);
            this.Controls.Add(this.moTrackerLabel);
            this.Name = "TreningForm";
            this.Text = "moTracker";
            this.Load += new System.EventHandler(this.TreningForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox vrstaTreningaComboBox;
        private System.Windows.Forms.Button spremiButton;
        private System.Windows.Forms.Button odustaniButton;
        private System.Windows.Forms.Label moTrackerLabel;
        private System.Windows.Forms.RichTextBox sazetakTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker datumDTP;
    }
}