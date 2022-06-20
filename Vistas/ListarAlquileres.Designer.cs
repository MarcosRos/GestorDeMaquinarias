namespace Vistas
{
    partial class ListarAlquileres
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
            this.dgv_Alquileres = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRecargar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Alquileres)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Alquileres
            // 
            this.dgv_Alquileres.AllowUserToAddRows = false;
            this.dgv_Alquileres.AllowUserToDeleteRows = false;
            this.dgv_Alquileres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Alquileres.Location = new System.Drawing.Point(12, 50);
            this.dgv_Alquileres.Name = "dgv_Alquileres";
            this.dgv_Alquileres.ReadOnly = true;
            this.dgv_Alquileres.Size = new System.Drawing.Size(590, 279);
            this.dgv_Alquileres.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Alquileres Realizados:";
            // 
            // btnRecargar
            // 
            this.btnRecargar.Location = new System.Drawing.Point(500, 8);
            this.btnRecargar.Name = "btnRecargar";
            this.btnRecargar.Size = new System.Drawing.Size(102, 32);
            this.btnRecargar.TabIndex = 2;
            this.btnRecargar.Text = "Recargar";
            this.btnRecargar.UseVisualStyleBackColor = true;
            // 
            // ListarAlquileres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 341);
            this.Controls.Add(this.btnRecargar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_Alquileres);
            this.Name = "ListarAlquileres";
            this.Text = "ListarAlquileres";
            this.Load += new System.EventHandler(this.ListarAlquileres_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Alquileres)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Alquileres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRecargar;
    }
}