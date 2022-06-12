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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.lblCliente = new System.Windows.Forms.Label();
            this.txtClienteSeleccionado = new System.Windows.Forms.TextBox();
            this.btnSeleccionarCliente = new System.Windows.Forms.Button();
            this.lblAlqFechaInicio = new System.Windows.Forms.Label();
            this.tabGeneral.SuspendLayout();
            this.tpAlquiler.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabGeneral
            // 
            this.tabGeneral.Controls.Add(this.tpAlquiler);
            this.tabGeneral.Controls.Add(this.tabPage2);
            this.tabGeneral.Location = new System.Drawing.Point(12, 12);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.SelectedIndex = 0;
            this.tabGeneral.Size = new System.Drawing.Size(630, 266);
            this.tabGeneral.TabIndex = 1;
            // 
            // tpAlquiler
            // 
            this.tpAlquiler.Controls.Add(this.lblAlqFechaInicio);
            this.tpAlquiler.Controls.Add(this.btnSeleccionarCliente);
            this.tpAlquiler.Controls.Add(this.txtClienteSeleccionado);
            this.tpAlquiler.Controls.Add(this.lblCliente);
            this.tpAlquiler.Controls.Add(this.dateTimePicker2);
            this.tpAlquiler.Controls.Add(this.dateTimePicker1);
            this.tpAlquiler.Location = new System.Drawing.Point(4, 22);
            this.tpAlquiler.Name = "tpAlquiler";
            this.tpAlquiler.Padding = new System.Windows.Forms.Padding(3);
            this.tpAlquiler.Size = new System.Drawing.Size(622, 240);
            this.tpAlquiler.TabIndex = 0;
            this.tpAlquiler.Text = "Alquiler";
            this.tpAlquiler.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(622, 240);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(357, 94);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(357, 169);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(57, 43);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(92, 13);
            this.lblCliente.TabIndex = 3;
            this.lblCliente.Text = "Persona a Alquilar";
            // 
            // txtClienteSeleccionado
            // 
            this.txtClienteSeleccionado.Location = new System.Drawing.Point(357, 40);
            this.txtClienteSeleccionado.Name = "txtClienteSeleccionado";
            this.txtClienteSeleccionado.ReadOnly = true;
            this.txtClienteSeleccionado.Size = new System.Drawing.Size(155, 20);
            this.txtClienteSeleccionado.TabIndex = 5;
            // 
            // btnSeleccionarCliente
            // 
            this.btnSeleccionarCliente.Location = new System.Drawing.Point(530, 38);
            this.btnSeleccionarCliente.Name = "btnSeleccionarCliente";
            this.btnSeleccionarCliente.Size = new System.Drawing.Size(27, 23);
            this.btnSeleccionarCliente.TabIndex = 6;
            this.btnSeleccionarCliente.Text = "...";
            this.btnSeleccionarCliente.UseVisualStyleBackColor = true;
            // 
            // lblAlqFechaInicio
            // 
            this.lblAlqFechaInicio.AutoSize = true;
            this.lblAlqFechaInicio.Location = new System.Drawing.Point(57, 100);
            this.lblAlqFechaInicio.Name = "lblAlqFechaInicio";
            this.lblAlqFechaInicio.Size = new System.Drawing.Size(35, 13);
            this.lblAlqFechaInicio.TabIndex = 7;
            this.lblAlqFechaInicio.Text = "label1";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 331);
            this.Controls.Add(this.tabGeneral);
            this.Name = "Principal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.tabGeneral.ResumeLayout(false);
            this.tpAlquiler.ResumeLayout(false);
            this.tpAlquiler.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabGeneral;
        private System.Windows.Forms.TabPage tpAlquiler;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtClienteSeleccionado;
        private System.Windows.Forms.Button btnSeleccionarCliente;
        private System.Windows.Forms.Label lblAlqFechaInicio;
    }
}