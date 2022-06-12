namespace Vistas
{
    partial class Principal
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
            this.tabGeneral = new System.Windows.Forms.TabControl();
            this.tpAlquiler = new System.Windows.Forms.TabPage();
            this.pbMaquinaria = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRegistrarAlquiler = new System.Windows.Forms.Button();
            this.cmbMaquinarias = new System.Windows.Forms.ComboBox();
            this.lblMaquinaria = new System.Windows.Forms.Label();
            this.btnMasInformacion = new System.Windows.Forms.Button();
            this.lblAntecedentes = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAlqFechaFin = new System.Windows.Forms.Label();
            this.cmbClientes = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRegistrarCliente = new System.Windows.Forms.Button();
            this.lblCliente = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.tpReserva = new System.Windows.Forms.TabPage();
            this.btnRegistrarReserva = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.fileOpen = new System.Windows.Forms.OpenFileDialog();
            this.tabGeneral.SuspendLayout();
            this.tpAlquiler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMaquinaria)).BeginInit();
            this.tpReserva.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabGeneral
            // 
            this.tabGeneral.Controls.Add(this.tpAlquiler);
            this.tabGeneral.Controls.Add(this.tpReserva);
            this.tabGeneral.Location = new System.Drawing.Point(12, 12);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.SelectedIndex = 0;
            this.tabGeneral.Size = new System.Drawing.Size(573, 319);
            this.tabGeneral.TabIndex = 1;
            // 
            // tpAlquiler
            // 
            this.tpAlquiler.Controls.Add(this.pbMaquinaria);
            this.tpAlquiler.Controls.Add(this.label3);
            this.tpAlquiler.Controls.Add(this.btnRegistrarAlquiler);
            this.tpAlquiler.Controls.Add(this.cmbMaquinarias);
            this.tpAlquiler.Controls.Add(this.lblMaquinaria);
            this.tpAlquiler.Controls.Add(this.btnMasInformacion);
            this.tpAlquiler.Controls.Add(this.lblAntecedentes);
            this.tpAlquiler.Controls.Add(this.label1);
            this.tpAlquiler.Controls.Add(this.lblAlqFechaFin);
            this.tpAlquiler.Controls.Add(this.cmbClientes);
            this.tpAlquiler.Controls.Add(this.label2);
            this.tpAlquiler.Controls.Add(this.btnRegistrarCliente);
            this.tpAlquiler.Controls.Add(this.lblCliente);
            this.tpAlquiler.Controls.Add(this.dateTimePicker2);
            this.tpAlquiler.Location = new System.Drawing.Point(4, 22);
            this.tpAlquiler.Name = "tpAlquiler";
            this.tpAlquiler.Padding = new System.Windows.Forms.Padding(3);
            this.tpAlquiler.Size = new System.Drawing.Size(565, 293);
            this.tpAlquiler.TabIndex = 0;
            this.tpAlquiler.Text = "Alquiler";
            this.tpAlquiler.UseVisualStyleBackColor = true;
            // 
            // pbMaquinaria
            // 
            this.pbMaquinaria.Location = new System.Drawing.Point(422, 110);
            this.pbMaquinaria.Name = "pbMaquinaria";
            this.pbMaquinaria.Size = new System.Drawing.Size(137, 87);
            this.pbMaquinaria.TabIndex = 19;
            this.pbMaquinaria.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(206, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "...";
            // 
            // btnRegistrarAlquiler
            // 
            this.btnRegistrarAlquiler.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnRegistrarAlquiler.Location = new System.Drawing.Point(3, 254);
            this.btnRegistrarAlquiler.Name = "btnRegistrarAlquiler";
            this.btnRegistrarAlquiler.Size = new System.Drawing.Size(559, 36);
            this.btnRegistrarAlquiler.TabIndex = 17;
            this.btnRegistrarAlquiler.Text = "Registrar Alquiler";
            this.btnRegistrarAlquiler.UseVisualStyleBackColor = true;
            // 
            // cmbMaquinarias
            // 
            this.cmbMaquinarias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaquinarias.FormattingEnabled = true;
            this.cmbMaquinarias.Location = new System.Drawing.Point(209, 110);
            this.cmbMaquinarias.Name = "cmbMaquinarias";
            this.cmbMaquinarias.Size = new System.Drawing.Size(207, 21);
            this.cmbMaquinarias.TabIndex = 16;
            // 
            // lblMaquinaria
            // 
            this.lblMaquinaria.AutoSize = true;
            this.lblMaquinaria.Location = new System.Drawing.Point(38, 113);
            this.lblMaquinaria.Name = "lblMaquinaria";
            this.lblMaquinaria.Size = new System.Drawing.Size(108, 13);
            this.lblMaquinaria.TabIndex = 15;
            this.lblMaquinaria.Text = "Maquinaria a Alquilar:";
            // 
            // btnMasInformacion
            // 
            this.btnMasInformacion.Location = new System.Drawing.Point(422, 73);
            this.btnMasInformacion.Name = "btnMasInformacion";
            this.btnMasInformacion.Size = new System.Drawing.Size(105, 23);
            this.btnMasInformacion.TabIndex = 14;
            this.btnMasInformacion.Text = "Mas Informacion";
            this.btnMasInformacion.UseVisualStyleBackColor = true;
            this.btnMasInformacion.Click += new System.EventHandler(this.btnMasInformacion_Click);
            // 
            // lblAntecedentes
            // 
            this.lblAntecedentes.AutoSize = true;
            this.lblAntecedentes.Location = new System.Drawing.Point(206, 78);
            this.lblAntecedentes.Name = "lblAntecedentes";
            this.lblAntecedentes.Size = new System.Drawing.Size(16, 13);
            this.lblAntecedentes.TabIndex = 13;
            this.lblAntecedentes.Text = "...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Antecedentes:";
            // 
            // lblAlqFechaFin
            // 
            this.lblAlqFechaFin.AutoSize = true;
            this.lblAlqFechaFin.Location = new System.Drawing.Point(38, 183);
            this.lblAlqFechaFin.Name = "lblAlqFechaFin";
            this.lblAlqFechaFin.Size = new System.Drawing.Size(94, 13);
            this.lblAlqFechaFin.TabIndex = 9;
            this.lblAlqFechaFin.Text = "Fecha Fin Alquiler:";
            // 
            // cmbClientes
            // 
            this.cmbClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClientes.FormattingEnabled = true;
            this.cmbClientes.Location = new System.Drawing.Point(209, 40);
            this.cmbClientes.Name = "cmbClientes";
            this.cmbClientes.Size = new System.Drawing.Size(207, 21);
            this.cmbClientes.TabIndex = 8;
            this.cmbClientes.SelectionChangeCommitted += new System.EventHandler(this.cmbClientes_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Precio Alquiler:";
            // 
            // btnRegistrarCliente
            // 
            this.btnRegistrarCliente.Location = new System.Drawing.Point(422, 38);
            this.btnRegistrarCliente.Name = "btnRegistrarCliente";
            this.btnRegistrarCliente.Size = new System.Drawing.Size(105, 23);
            this.btnRegistrarCliente.TabIndex = 6;
            this.btnRegistrarCliente.Text = "Registrar";
            this.btnRegistrarCliente.UseVisualStyleBackColor = true;
            this.btnRegistrarCliente.Click += new System.EventHandler(this.btnRegistrarCliente_Click);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(38, 43);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(42, 13);
            this.lblCliente.TabIndex = 3;
            this.lblCliente.Text = "Cliente:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(209, 177);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(207, 20);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // tpReserva
            // 
            this.tpReserva.Controls.Add(this.btnRegistrarReserva);
            this.tpReserva.Controls.Add(this.label11);
            this.tpReserva.Controls.Add(this.comboBox2);
            this.tpReserva.Controls.Add(this.label4);
            this.tpReserva.Controls.Add(this.button1);
            this.tpReserva.Controls.Add(this.label5);
            this.tpReserva.Controls.Add(this.label6);
            this.tpReserva.Controls.Add(this.label7);
            this.tpReserva.Controls.Add(this.comboBox3);
            this.tpReserva.Controls.Add(this.label8);
            this.tpReserva.Controls.Add(this.label9);
            this.tpReserva.Controls.Add(this.button2);
            this.tpReserva.Controls.Add(this.label10);
            this.tpReserva.Controls.Add(this.dateTimePicker3);
            this.tpReserva.Controls.Add(this.dateTimePicker4);
            this.tpReserva.Location = new System.Drawing.Point(4, 22);
            this.tpReserva.Name = "tpReserva";
            this.tpReserva.Padding = new System.Windows.Forms.Padding(3);
            this.tpReserva.Size = new System.Drawing.Size(565, 293);
            this.tpReserva.TabIndex = 1;
            this.tpReserva.Text = "Reserva";
            this.tpReserva.UseVisualStyleBackColor = true;
            // 
            // btnRegistrarReserva
            // 
            this.btnRegistrarReserva.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnRegistrarReserva.Location = new System.Drawing.Point(3, 254);
            this.btnRegistrarReserva.Name = "btnRegistrarReserva";
            this.btnRegistrarReserva.Size = new System.Drawing.Size(559, 36);
            this.btnRegistrarReserva.TabIndex = 31;
            this.btnRegistrarReserva.Text = "Registrar Reserva";
            this.btnRegistrarReserva.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(206, 148);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(16, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "...";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(209, 110);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(207, 21);
            this.comboBox2.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Maquinaria a Reservar:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(422, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "Mas Informacion";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(206, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "...";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Antecedentes:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Fecha Fin Reserva:";
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(209, 40);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(207, 21);
            this.comboBox3.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Precio Reserva:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(38, 183);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Fecha Reserva:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(422, 38);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "Registrar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(38, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Cliente:";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(209, 212);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(207, 20);
            this.dateTimePicker3.TabIndex = 18;
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.Location = new System.Drawing.Point(209, 177);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(207, 20);
            this.dateTimePicker4.TabIndex = 17;
            // 
            // fileOpen
            // 
            this.fileOpen.FileName = "fileOpen";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 343);
            this.Controls.Add(this.tabGeneral);
            this.Name = "Principal";
            this.Text = "Realizar Alquiler";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.tabGeneral.ResumeLayout(false);
            this.tpAlquiler.ResumeLayout(false);
            this.tpAlquiler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMaquinaria)).EndInit();
            this.tpReserva.ResumeLayout(false);
            this.tpReserva.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabGeneral;
        private System.Windows.Forms.TabPage tpAlquiler;
        private System.Windows.Forms.TabPage tpReserva;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button btnRegistrarCliente;
        private System.Windows.Forms.ComboBox cmbClientes;
        private System.Windows.Forms.Label lblAlqFechaFin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAntecedentes;
        private System.Windows.Forms.Button btnMasInformacion;
        private System.Windows.Forms.Button btnRegistrarAlquiler;
        private System.Windows.Forms.ComboBox cmbMaquinarias;
        private System.Windows.Forms.Label lblMaquinaria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRegistrarReserva;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.PictureBox pbMaquinaria;
        private System.Windows.Forms.OpenFileDialog fileOpen;
    }
}