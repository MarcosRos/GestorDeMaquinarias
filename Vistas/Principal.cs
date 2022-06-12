using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClasesBase;
using System.Globalization;
using System.IO;

namespace Vistas
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btnRegistrarAlquiler_Click(object sender, EventArgs e)
        {

        }

        private void load_cmbClientes()
        {
            DataTable dt = TrabajarBD.list_clientes();
            cmbClientes.DataSource = dt;
            dt.Columns.Add("FullName",
            typeof(string), "Nombre + ' ' + Apellido + ' '+ DNI");
            cmbClientes.DisplayMember = "FullName";
            cmbClientes.ValueMember = "IdCliente";
            int i = (int)cmbClientes.SelectedValue;
            int antecedentes = TrabajarBD.count_of_Antecedentes(i);
            if (antecedentes == 0)
            {
                lblAntecedentes.ForeColor = System.Drawing.Color.Green;
            }
            else if (antecedentes == 1)
            {
                lblAntecedentes.ForeColor = System.Drawing.Color.Orange;
            }
            else
            {
                lblAntecedentes.ForeColor = System.Drawing.Color.Red;
            }
            lblAntecedentes.Text = "Este cliente tiene: " + TrabajarBD.count_of_Antecedentes(i).ToString() + " antecedente/s.";
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            load_cmbClientes();
            DataTable dtMaquinarias = TrabajarBD.list_maquinarias();
            cmbMaquinarias.DataSource = dtMaquinarias;
            dtMaquinarias.Columns.Add("MarcaModelo",
            typeof(string), "Marca + ' ' + Modelo");

            cmbMaquinarias.DisplayMember = "MarcaModelo";
            cmbMaquinarias.ValueMember = "IdMaquinaria";
            int j = (int)cmbMaquinarias.SelectedValue;
            Image imagen;
            foreach (DataRow row in dtMaquinarias.Rows) 
            {
                if (row["IdMaquinaria"].ToString() == j.ToString()) 
                {
                    //imagen=(Image)row["Imagen"];
                    //pbMaquinaria.Image = imagen;
                }
            }

        }

        private void btnMasInformacion_Click(object sender, EventArgs e)
        {
            int indice= (int)cmbClientes.SelectedValue;
            AntecedentesForm antForm = new AntecedentesForm(indice);
            antForm.Show();
        }

        private void cmbClientes_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int i = (int)cmbClientes.SelectedValue;
            int antecedentes = TrabajarBD.count_of_Antecedentes(i);
            if (antecedentes == 0)
            {
                lblAntecedentes.ForeColor = System.Drawing.Color.Green;
            }
            else if (antecedentes == 1)
            {
                lblAntecedentes.ForeColor = System.Drawing.Color.Orange;
            }
            else
            {
                lblAntecedentes.ForeColor = System.Drawing.Color.Red;
            }
            lblAntecedentes.Text = "Este cliente tiene: " + TrabajarBD.count_of_Antecedentes(i).ToString() + " antecedente/s.";
        }

        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {
            ClienteForm clienteForm = new ClienteForm();
            clienteForm.Show();
            clienteForm.btnRegistrarCliente.Click += button_clicked;
        }

        public void button_clicked(object sender, EventArgs e)
        {
            Console.WriteLine("Cargando Clientes");
            load_cmbClientes();
        }

       /* private void button3_Click(object sender, EventArgs e)
        {
            fileOpen = new OpenFileDialog();
            fileOpen.Title = "Open Image file";
            fileOpen.Filter = "JPG Files (*.jpg)| *.jpg";

            if (fileOpen.ShowDialog() == DialogResult.OK)
            {
                pbMaquinaria.Image = Image.FromStream(fileOpen.FileName);

                using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                {
                   using (Image original = Image.FromStream(fs))
                   {
            }
            fileOpen.Dispose();
        }*/
    }
}
