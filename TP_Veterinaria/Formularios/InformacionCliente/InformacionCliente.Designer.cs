namespace TP_Veterinaria
{
    partial class InformacionCliente
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
            this.lbl_NombreCliente = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_DNICliente = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_PesoPromedio = new System.Windows.Forms.Label();
            this.lbl_EdadMadurez = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_especieinfo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txb_Nombre_Mascota = new System.Windows.Forms.TextBox();
            this.txb_PesoMascota = new System.Windows.Forms.TextBox();
            this.txb_Edad_Mascota = new System.Windows.Forms.TextBox();
            this.button1_GuardarMascota = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1_ActualizarListaMascotas = new System.Windows.Forms.Button();
            this.cmb_especie = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_NombreEmpresa = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_NombreCliente
            // 
            this.lbl_NombreCliente.AutoSize = true;
            this.lbl_NombreCliente.BackColor = System.Drawing.Color.AliceBlue;
            this.lbl_NombreCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_NombreCliente.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NombreCliente.ForeColor = System.Drawing.Color.Red;
            this.lbl_NombreCliente.Location = new System.Drawing.Point(83, 81);
            this.lbl_NombreCliente.Name = "lbl_NombreCliente";
            this.lbl_NombreCliente.Size = new System.Drawing.Size(211, 19);
            this.lbl_NombreCliente.TabIndex = 22;
            this.lbl_NombreCliente.Text = "nombre agustin florentin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.AliceBlue;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 19);
            this.label2.TabIndex = 23;
            this.label2.Text = "Cliente:";
            // 
            // lbl_DNICliente
            // 
            this.lbl_DNICliente.AutoSize = true;
            this.lbl_DNICliente.BackColor = System.Drawing.Color.AliceBlue;
            this.lbl_DNICliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_DNICliente.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DNICliente.ForeColor = System.Drawing.Color.Red;
            this.lbl_DNICliente.Location = new System.Drawing.Point(83, 100);
            this.lbl_DNICliente.Name = "lbl_DNICliente";
            this.lbl_DNICliente.Size = new System.Drawing.Size(34, 19);
            this.lbl_DNICliente.TabIndex = 22;
            this.lbl_DNICliente.Text = "dni";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.AliceBlue;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "Especie:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.AliceBlue;
            this.groupBox1.Controls.Add(this.lbl_PesoPromedio);
            this.groupBox1.Controls.Add(this.lbl_EdadMadurez);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmb_especieinfo);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(17, 373);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 138);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion de la especie:";
            // 
            // lbl_PesoPromedio
            // 
            this.lbl_PesoPromedio.AutoSize = true;
            this.lbl_PesoPromedio.BackColor = System.Drawing.Color.AliceBlue;
            this.lbl_PesoPromedio.Location = new System.Drawing.Point(126, 110);
            this.lbl_PesoPromedio.Name = "lbl_PesoPromedio";
            this.lbl_PesoPromedio.Size = new System.Drawing.Size(38, 16);
            this.lbl_PesoPromedio.TabIndex = 1;
            this.lbl_PesoPromedio.Text = "peso";
            // 
            // lbl_EdadMadurez
            // 
            this.lbl_EdadMadurez.AutoSize = true;
            this.lbl_EdadMadurez.BackColor = System.Drawing.Color.AliceBlue;
            this.lbl_EdadMadurez.Location = new System.Drawing.Point(142, 74);
            this.lbl_EdadMadurez.Name = "lbl_EdadMadurez";
            this.lbl_EdadMadurez.Size = new System.Drawing.Size(39, 16);
            this.lbl_EdadMadurez.TabIndex = 1;
            this.lbl_EdadMadurez.Text = "edad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.AliceBlue;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Peso Promedio:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.AliceBlue;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Edad de Madurez:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.AliceBlue;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Especie:";
            // 
            // cmb_especieinfo
            // 
            this.cmb_especieinfo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cmb_especieinfo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_especieinfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_especieinfo.FormattingEnabled = true;
            this.cmb_especieinfo.Location = new System.Drawing.Point(79, 29);
            this.cmb_especieinfo.Name = "cmb_especieinfo";
            this.cmb_especieinfo.Size = new System.Drawing.Size(232, 24);
            this.cmb_especieinfo.TabIndex = 26;
            this.cmb_especieinfo.SelectedIndexChanged += new System.EventHandler(this.cmb_especie_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.AliceBlue;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 16);
            this.label7.TabIndex = 23;
            this.label7.Text = "Nombre:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.AliceBlue;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 16);
            this.label8.TabIndex = 23;
            this.label8.Text = "Peso:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.AliceBlue;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 143);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 16);
            this.label9.TabIndex = 23;
            this.label9.Text = "Edad:";
            // 
            // txb_Nombre_Mascota
            // 
            this.txb_Nombre_Mascota.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txb_Nombre_Mascota.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Nombre_Mascota.Location = new System.Drawing.Point(79, 54);
            this.txb_Nombre_Mascota.Name = "txb_Nombre_Mascota";
            this.txb_Nombre_Mascota.Size = new System.Drawing.Size(228, 26);
            this.txb_Nombre_Mascota.TabIndex = 27;
            // 
            // txb_PesoMascota
            // 
            this.txb_PesoMascota.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txb_PesoMascota.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_PesoMascota.Location = new System.Drawing.Point(79, 96);
            this.txb_PesoMascota.Name = "txb_PesoMascota";
            this.txb_PesoMascota.Size = new System.Drawing.Size(227, 26);
            this.txb_PesoMascota.TabIndex = 28;
            this.txb_PesoMascota.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_PesoMascota_KeyPress);
            // 
            // txb_Edad_Mascota
            // 
            this.txb_Edad_Mascota.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txb_Edad_Mascota.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Edad_Mascota.Location = new System.Drawing.Point(79, 137);
            this.txb_Edad_Mascota.Name = "txb_Edad_Mascota";
            this.txb_Edad_Mascota.Size = new System.Drawing.Size(227, 26);
            this.txb_Edad_Mascota.TabIndex = 28;
            this.txb_Edad_Mascota.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_Edad_Mascota_KeyPress);
            // 
            // button1_GuardarMascota
            // 
            this.button1_GuardarMascota.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button1_GuardarMascota.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1_GuardarMascota.Location = new System.Drawing.Point(15, 171);
            this.button1_GuardarMascota.Name = "button1_GuardarMascota";
            this.button1_GuardarMascota.Size = new System.Drawing.Size(292, 34);
            this.button1_GuardarMascota.TabIndex = 29;
            this.button1_GuardarMascota.Text = "GUARDAR";
            this.button1_GuardarMascota.UseVisualStyleBackColor = false;
            this.button1_GuardarMascota.Click += new System.EventHandler(this.button1_GuardarMascota_Click);
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
            this.dataGridView1.Location = new System.Drawing.Point(481, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(495, 405);
            this.dataGridView1.TabIndex = 30;
            // 
            // button1_ActualizarListaMascotas
            // 
            this.button1_ActualizarListaMascotas.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button1_ActualizarListaMascotas.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1_ActualizarListaMascotas.Location = new System.Drawing.Point(481, 470);
            this.button1_ActualizarListaMascotas.Name = "button1_ActualizarListaMascotas";
            this.button1_ActualizarListaMascotas.Size = new System.Drawing.Size(495, 41);
            this.button1_ActualizarListaMascotas.TabIndex = 29;
            this.button1_ActualizarListaMascotas.Text = "ACTUALIZAR LISTA";
            this.button1_ActualizarListaMascotas.UseVisualStyleBackColor = false;
            this.button1_ActualizarListaMascotas.Click += new System.EventHandler(this.button1_ActualizarListaMascotas_Click);
            // 
            // cmb_especie
            // 
            this.cmb_especie.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cmb_especie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_especie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_especie.FormattingEnabled = true;
            this.cmb_especie.Location = new System.Drawing.Point(79, 21);
            this.cmb_especie.Name = "cmb_especie";
            this.cmb_especie.Size = new System.Drawing.Size(232, 24);
            this.cmb_especie.TabIndex = 26;
            this.cmb_especie.SelectedIndexChanged += new System.EventHandler(this.cmb_especie_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.AliceBlue;
            this.groupBox2.Controls.Add(this.cmb_especie);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.button1_GuardarMascota);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txb_Nombre_Mascota);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txb_Edad_Mascota);
            this.groupBox2.Controls.Add(this.txb_PesoMascota);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(17, 134);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(331, 233);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Registrar Mascota:";
            // 
            // lbl_NombreEmpresa
            // 
            this.lbl_NombreEmpresa.AutoSize = true;
            this.lbl_NombreEmpresa.BackColor = System.Drawing.Color.AliceBlue;
            this.lbl_NombreEmpresa.Location = new System.Drawing.Point(351, 606);
            this.lbl_NombreEmpresa.Name = "lbl_NombreEmpresa";
            this.lbl_NombreEmpresa.Size = new System.Drawing.Size(62, 13);
            this.lbl_NombreEmpresa.TabIndex = 32;
            this.lbl_NombreEmpresa.Text = "Creado por ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(274, 541);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(399, 41);
            this.button1.TabIndex = 36;
            this.button1.Text = "CAMBIAR DE CLIENTE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.AliceBlue;
            this.label11.Font = new System.Drawing.Font("Imprint MT Shadow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(26, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(334, 32);
            this.label11.TabIndex = 49;
            this.label11.Text = "REGISTRAR MASCOTA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.AliceBlue;
            this.label1.Font = new System.Drawing.Font("Imprint MT Shadow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(533, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 32);
            this.label1.TabIndex = 49;
            this.label1.Text = "MASCOTAS REGISTRADAS";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.AliceBlue;
            this.pictureBox2.Image = global::TP_Veterinaria.Properties.Resources.veterinarian_13203862;
            this.pictureBox2.Location = new System.Drawing.Point(366, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(57, 54);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 50;
            this.pictureBox2.TabStop = false;
            // 
            // InformacionCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1023, 640);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_NombreEmpresa);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1_ActualizarListaMascotas);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_DNICliente);
            this.Controls.Add(this.lbl_NombreCliente);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "InformacionCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InformacionCliente";
            this.Load += new System.EventHandler(this.InformacionCliente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_NombreCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_DNICliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmb_especieinfo;
        private System.Windows.Forms.Label lbl_PesoPromedio;
        private System.Windows.Forms.Label lbl_EdadMadurez;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txb_Nombre_Mascota;
        private System.Windows.Forms.TextBox txb_PesoMascota;
        private System.Windows.Forms.TextBox txb_Edad_Mascota;
        private System.Windows.Forms.Button button1_GuardarMascota;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1_ActualizarListaMascotas;
        private System.Windows.Forms.ComboBox cmb_especie;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_NombreEmpresa;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}