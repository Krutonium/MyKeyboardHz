﻿
namespace MyKeyboardHz
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblResults = new System.Windows.Forms.Label();
            this.lblScanRate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Press Any Non-Enter Key to Measure";
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Location = new System.Drawing.Point(12, 39);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(59, 17);
            this.lblResults.TabIndex = 2;
            this.lblResults.Text = "Results:";
            // 
            // lblScanRate
            // 
            this.lblScanRate.AutoSize = true;
            this.lblScanRate.Location = new System.Drawing.Point(330, 9);
            this.lblScanRate.Name = "lblScanRate";
            this.lblScanRate.Size = new System.Drawing.Size(144, 17);
            this.lblScanRate.TabIndex = 3;
            this.lblScanRate.Text = "Estimated Scan Rate:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 450);
            this.Controls.Add(this.lblScanRate);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "My Keyboard Hz";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.Label lblScanRate;
    }
}

