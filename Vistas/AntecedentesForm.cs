using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClasesBase;

namespace Vistas
{
    public partial class AntecedentesForm : Form
    {
        int indice;

        public AntecedentesForm()
        {
            InitializeComponent();
        }

        public AntecedentesForm(int indice)
        {
            InitializeComponent();
            this.indice = indice;

        }

        private void AntecedentesForm_Load(object sender, EventArgs e)
        {
            lblNombre.Text = "...";
            Console.WriteLine("Indice: "+this.indice);
            DataTable dt = TrabajarBD.buscarCli(this.indice);

            string nombre = (from DataRow dr in dt.Rows
                             where (int)dr["IdCliente"] == this.indice
                             select (string)dr["Nombre"]).FirstOrDefault();

            string apellido = (from DataRow dr in dt.Rows
                               where (int)dr["IdCliente"] == this.indice
                               select (string)dr["Apellido"]).FirstOrDefault();
            string DNI = (from DataRow dr in dt.Rows
                          where (int)dr["IdCliente"] == this.indice
                          select (string)dr["DNI"]).FirstOrDefault();

            lblNombre.Text = "Nombre: "+ nombre;
            lblApellido.Text = "Apellido: " + apellido;
            lblDNI.Text = "DNI: " + DNI;
            Console.WriteLine("Nombre: " + nombre); 
            Console.WriteLine("Apellido: " + apellido);
            Console.WriteLine("DNI: " + DNI);

            DataTable tablaAntecedentes= TrabajarBD.list_antecedentes(this.indice);
            tablaAntecedentes.Columns.Remove("Cliente");
            dgvAntecedentes.DataSource = tablaAntecedentes;

        }
    }
}
