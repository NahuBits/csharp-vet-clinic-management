namespace TP_Veterinaria
{
    partial class Veterinaria
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
            this.panelUp = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panelUp.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelUp
            // 
            this.panelUp.BackColor = System.Drawing.SystemColors.ControlText;
            this.panelUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelUp.Controls.Add(this.button1);
            this.panelUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUp.Location = new System.Drawing.Point(0, 0);
            this.panelUp.Name = "panelUp";
            this.panelUp.Size = new System.Drawing.Size(1023, 33);
            this.panelUp.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::TP_Veterinaria.Properties.Resources.Close;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(989, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 33);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Veterinaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 659);
            this.Controls.Add(this.panelUp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "Veterinaria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Veterinaria";
            this.Load += new System.EventHandler(this.Veterinaria_Load);
            this.panelUp.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUp;
        private System.Windows.Forms.Button button1;
    }
}