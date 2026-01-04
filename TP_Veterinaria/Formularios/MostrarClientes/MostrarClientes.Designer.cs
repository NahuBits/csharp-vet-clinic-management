namespace TP_Veterinaria
{
    partial class MostrarClientes
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbl_NombreEmpresa = new System.Windows.Forms.Label();
            this.button1_AgregarMascota = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView1.Location = new System.Drawing.Point(52, 209);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(675, 311);
            this.dataGridView1.TabIndex = 0;
            // 
            // lbl_NombreEmpresa
            // 
            this.lbl_NombreEmpresa.AutoSize = true;
            this.lbl_NombreEmpresa.BackColor = System.Drawing.Color.AliceBlue;
            this.lbl_NombreEmpresa.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NombreEmpresa.Location = new System.Drawing.Point(376, 570);
            this.lbl_NombreEmpresa.Name = "lbl_NombreEmpresa";
            this.lbl_NombreEmpresa.Size = new System.Drawing.Size(71, 16);
            this.lbl_NombreEmpresa.TabIndex = 11;
            this.lbl_NombreEmpresa.Text = "Creado por";
            // 
            // button1_AgregarMascota
            // 
            this.button1_AgregarMascota.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button1_AgregarMascota.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1_AgregarMascota.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1_AgregarMascota.Image = global::TP_Veterinaria.Properties.Resources.service_dog_2472749__1_;
            this.button1_AgregarMascota.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1_AgregarMascota.Location = new System.Drawing.Point(764, 209);
            this.button1_AgregarMascota.Name = "button1_AgregarMascota";
            this.button1_AgregarMascota.Size = new System.Drawing.Size(205, 187);
            this.button1_AgregarMascota.TabIndex = 26;
            this.button1_AgregarMascota.Text = "AGREGAR MASCOTA";
            this.button1_AgregarMascota.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1_AgregarMascota.UseVisualStyleBackColor = false;
            this.button1_AgregarMascota.Click += new System.EventHandler(this.button1_AgregarMascota_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(51, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(368, 24);
            this.label3.TabIndex = 27;
            this.label3.Text = "Seleccione un cliente y pulse el boton";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(764, 478);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 42);
            this.button1.TabIndex = 35;
            this.button1.Text = "REGRESAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(416, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 24);
            this.label2.TabIndex = 36;
            this.label2.Text = "Agregar Mascota";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.AliceBlue;
            this.label4.Font = new System.Drawing.Font("Imprint MT Shadow", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(664, 57);
            this.label4.TabIndex = 43;
            this.label4.Text = "CLIENTES DE NARICITAS";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.AliceBlue;
            this.pictureBox2.Image = global::TP_Veterinaria.Properties.Resources.veterinarian_13203862;
            this.pictureBox2.Location = new System.Drawing.Point(715, 66);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(91, 77);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 44;
            this.pictureBox2.TabStop = false;
            // 
            // MostrarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1023, 640);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button1_AgregarMascota);
            this.Controls.Add(this.lbl_NombreEmpresa);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "MostrarClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MostrarClientes";
            this.Load += new System.EventHandler(this.MostrarClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_NombreEmpresa;
        private System.Windows.Forms.Button button1_AgregarMascota;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}