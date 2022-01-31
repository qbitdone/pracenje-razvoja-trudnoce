
namespace PRT.Forms
{
    partial class OpsegForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OpsegForm));
            this.label1 = new System.Windows.Forms.Label();
            this.opsegTextBox = new System.Windows.Forms.TextBox();
            this.spremiButton = new System.Windows.Forms.Button();
            this.odustaniButton = new System.Windows.Forms.Button();
            this.moTrackerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(108, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Unesite opseg u centimetrima";
            // 
            // opsegTextBox
            // 
            this.opsegTextBox.Location = new System.Drawing.Point(115, 128);
            this.opsegTextBox.Name = "opsegTextBox";
            this.opsegTextBox.Size = new System.Drawing.Size(127, 20);
            this.opsegTextBox.TabIndex = 13;
            // 
            // spremiButton
            // 
            this.spremiButton.BackColor = System.Drawing.Color.White;
            this.spremiButton.Location = new System.Drawing.Point(195, 182);
            this.spremiButton.Name = "spremiButton";
            this.spremiButton.Size = new System.Drawing.Size(136, 54);
            this.spremiButton.TabIndex = 12;
            this.spremiButton.Text = "Spremi";
            this.spremiButton.UseVisualStyleBackColor = false;
            this.spremiButton.Click += new System.EventHandler(this.spremiButton_Click);
            // 
            // odustaniButton
            // 
            this.odustaniButton.BackColor = System.Drawing.Color.White;
            this.odustaniButton.Location = new System.Drawing.Point(26, 182);
            this.odustaniButton.Name = "odustaniButton";
            this.odustaniButton.Size = new System.Drawing.Size(136, 54);
            this.odustaniButton.TabIndex = 11;
            this.odustaniButton.Text = "Odustani";
            this.odustaniButton.UseVisualStyleBackColor = false;
            this.odustaniButton.Click += new System.EventHandler(this.odustaniButton_Click);
            // 
            // moTrackerLabel
            // 
            this.moTrackerLabel.AutoSize = true;
            this.moTrackerLabel.BackColor = System.Drawing.Color.Transparent;
            this.moTrackerLabel.Font = new System.Drawing.Font("Segoe Print", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moTrackerLabel.Location = new System.Drawing.Point(104, 19);
            this.moTrackerLabel.Name = "moTrackerLabel";
            this.moTrackerLabel.Size = new System.Drawing.Size(138, 64);
            this.moTrackerLabel.TabIndex = 10;
            this.moTrackerLabel.Text = "Opseg";
            // 
            // OpsegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(356, 255);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.opsegTextBox);
            this.Controls.Add(this.spremiButton);
            this.Controls.Add(this.odustaniButton);
            this.Controls.Add(this.moTrackerLabel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "OpsegForm";
            this.Text = "moTracker";
            this.Load += new System.EventHandler(this.OpsegForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox opsegTextBox;
        private System.Windows.Forms.Button spremiButton;
        private System.Windows.Forms.Button odustaniButton;
        private System.Windows.Forms.Label moTrackerLabel;
    }
}