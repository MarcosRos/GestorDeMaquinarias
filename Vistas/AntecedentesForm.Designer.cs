namespace Vistas
{
    partial class AntecedentesForm
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
            this.dgvAntecedentes = new System.Windows.Forms.DataGridView();
            this.lblAntecedentes = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAntecedentes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAntecedentes
            // 
            this.dgvAntecedentes.AllowUserToAddRows = false;
            this.dgvAntecedentes.AllowUserToDeleteRows = false;
            this.dgvAntecedentes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAntecedentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAntecedentes.Location = new System.Drawing.Point(12, 76);
            this.dgvAntecedentes.Name = "dgvAntecedentes";
            this.dgvAntecedentes.ReadOnly = true;
            this.dgvAntecedentes.Size = new System.Drawing.Size(340, 156);
            this.dgvAntecedentes.TabIndex = 0;
            // 
            // lblAntecedentes
            // 
            this.lblAntecedentes.AutoSize = true;
            this.lblAntecedentes.Location = new System.Drawing.Point(13, 13);
            this.lblAntecedentes.Name = "lblAntecedentes";
            this.lblAntecedentes.Size = new System.Drawing.Size(131, 13);
            this.lblAntecedentes.TabIndex = 1;
            this.lblAntecedentes.Text = "Antecedentes del Cliente: ";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(151, 13);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(16, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "...";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(151, 33);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(16, 13);
            this.lblApellido.TabIndex = 3;
            this.lblApellido.Text = "...";
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(151, 53);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(16, 13);
            this.lblDNI.TabIndex = 4;
            this.lblDNI.Text = "...";
            // 
            // AntecedentesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 244);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblAntecedentes);
            this.Controls.Add(this.dgvAntecedentes);
            this.Name = "AntecedentesForm";
            this.Text = "Antecedentes Del Cliente";
            this.Load += new System.EventHandler(this.AntecedentesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAntecedentes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAntecedentes;
        private System.Windows.Forms.Label lblAntecedentes;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblDNI;
    }
}

