
namespace PRT.Forms
{
    partial class ZapisDnevnikaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZapisDnevnikaForm));
            this.spremiButton = new System.Windows.Forms.Button();
            this.odustaniButton = new System.Windows.Forms.Button();
            this.naslovTextBox = new System.Windows.Forms.TextBox();
            this.sadrzajTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.moTrackerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // spremiButton
            // 
            this.spremiButton.BackColor = System.Drawing.Color.White;
            this.spremiButton.Location = new System.Drawing.Point(219, 311);
            this.spremiButton.Name = "spremiButton";
            this.spremiButton.Size = new System.Drawing.Size(136, 54);
            this.spremiButton.TabIndex = 19;
            this.spremiButton.Text = "Spremi";
            this.spremiButton.UseVisualStyleBackColor = false;
            // 
            // odustaniButton
            // 
            this.odustaniButton.BackColor = System.Drawing.Color.White;
            this.odustaniButton.Location = new System.Drawing.Point(50, 311);
            this.odustaniButton.Name = "odustaniButton";
            this.odustaniButton.Size = new System.Drawing.Size(136, 54);
            this.odustaniButton.TabIndex = 18;
            this.odustaniButton.Text = "Odustani";
            this.odustaniButton.UseVisualStyleBackColor = false;
            this.odustaniButton.Click += new System.EventHandler(this.odustaniButton_Click);
            // 
            // naslovTextBox
            // 
            this.naslovTextBox.Location = new System.Drawing.Point(112, 102);
            this.naslovTextBox.Name = "naslovTextBox";
            this.naslovTextBox.Size = new System.Drawing.Size(208, 20);
            this.naslovTextBox.TabIndex = 20;
            // 
            // sadrzajTextBox
            // 
            this.sadrzajTextBox.Location = new System.Drawing.Point(112, 151);
            this.sadrzajTextBox.Name = "sadrzajTextBox";
            this.sadrzajTextBox.Size = new System.Drawing.Size(208, 126);
            this.sadrzajTextBox.TabIndex = 21;
            this.sadrzajTextBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(66, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Naslov";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(64, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Sadržaj";
            // 
            // moTrackerLabel
            // 
            this.moTrackerLabel.AutoSize = true;
            this.moTrackerLabel.BackColor = System.Drawing.Color.Transparent;
            this.moTrackerLabel.Font = new System.Drawing.Font("Segoe Print", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moTrackerLabel.Location = new System.Drawing.Point(56, 9);
            this.moTrackerLabel.Name = "moTrackerLabel";
            this.moTrackerLabel.Size = new System.Drawing.Size(317, 64);
            this.moTrackerLabel.TabIndex = 23;
            this.moTrackerLabel.Text = "Zapis Dnevnika";
            // 
            // ZapisDnevnikaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(416, 389);
            this.Controls.Add(this.moTrackerLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sadrzajTextBox);
            this.Controls.Add(this.naslovTextBox);
            this.Controls.Add(this.spremiButton);
            this.Controls.Add(this.odustaniButton);
            this.Name = "ZapisDnevnikaForm";
            this.Text = "moTracker";
            this.Load += new System.EventHandler(this.ZapisDnevnikaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button spremiButton;
        private System.Windows.Forms.Button odustaniButton;
        private System.Windows.Forms.TextBox naslovTextBox;
        private System.Windows.Forms.RichTextBox sadrzajTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label moTrackerLabel;
    }
}