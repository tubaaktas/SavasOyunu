
namespace Savas.Dekstop
{
    partial class AnaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaForm));
            this.BilgiPanel = new System.Windows.Forms.Panel();
            this.SureLabel = new System.Windows.Forms.Label();
            this.BilgiLabel = new System.Windows.Forms.Label();
            this.SavasAlaniPanel = new System.Windows.Forms.Panel();
            this.UcaksavarPanel = new System.Windows.Forms.Panel();
            this.BilgiPanel.SuspendLayout();
            this.SavasAlaniPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BilgiPanel
            // 
            this.BilgiPanel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BilgiPanel.Controls.Add(this.SureLabel);
            this.BilgiPanel.Controls.Add(this.BilgiLabel);
            this.BilgiPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.BilgiPanel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.BilgiPanel.Location = new System.Drawing.Point(0, 0);
            this.BilgiPanel.Name = "BilgiPanel";
            this.BilgiPanel.Size = new System.Drawing.Size(852, 93);
            this.BilgiPanel.TabIndex = 0;
            // 
            // SureLabel
            // 
            this.SureLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SureLabel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.SureLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SureLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SureLabel.Location = new System.Drawing.Point(658, 18);
            this.SureLabel.Name = "SureLabel";
            this.SureLabel.Size = new System.Drawing.Size(133, 38);
            this.SureLabel.TabIndex = 1;
            this.SureLabel.Text = "0:00";
            this.SureLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BilgiLabel
            // 
            this.BilgiLabel.AutoSize = true;
            this.BilgiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BilgiLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BilgiLabel.Location = new System.Drawing.Point(12, 9);
            this.BilgiLabel.Name = "BilgiLabel";
            this.BilgiLabel.Size = new System.Drawing.Size(518, 80);
            this.BilgiLabel.TabIndex = 0;
            this.BilgiLabel.Text = "Oyunu başlatmak için ENTER tuşuna basınız.\r\nUçaksavarı hareket ettirmek için SAĞ-" +
    "SOL tuşlarına basınız.\r\nAteş etmek için BOŞLUK tuşuna basınız.\r\n \r\n";
            // 
            // SavasAlaniPanel
            // 
            this.SavasAlaniPanel.BackColor = System.Drawing.Color.RoyalBlue;
            this.SavasAlaniPanel.Controls.Add(this.UcaksavarPanel);
            this.SavasAlaniPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SavasAlaniPanel.Location = new System.Drawing.Point(0, 93);
            this.SavasAlaniPanel.Name = "SavasAlaniPanel";
            this.SavasAlaniPanel.Size = new System.Drawing.Size(852, 485);
            this.SavasAlaniPanel.TabIndex = 1;
            // 
            // UcaksavarPanel
            // 
            this.UcaksavarPanel.BackColor = System.Drawing.Color.MidnightBlue;
            this.UcaksavarPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.UcaksavarPanel.Location = new System.Drawing.Point(0, 415);
            this.UcaksavarPanel.Name = "UcaksavarPanel";
            this.UcaksavarPanel.Size = new System.Drawing.Size(852, 70);
            this.UcaksavarPanel.TabIndex = 0;
            
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 578);
            this.Controls.Add(this.SavasAlaniPanel);
            this.Controls.Add(this.BilgiPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AnaForm";
            this.Text = "Savaş Oyunu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AnaForm_KeyDown);
            this.BilgiPanel.ResumeLayout(false);
            this.BilgiPanel.PerformLayout();
            this.SavasAlaniPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BilgiPanel;
        private System.Windows.Forms.Label SureLabel;
        private System.Windows.Forms.Label BilgiLabel;
        private System.Windows.Forms.Panel UcaksavarPanel;
        private System.Windows.Forms.Panel SavasAlaniPanel;
    }
}

