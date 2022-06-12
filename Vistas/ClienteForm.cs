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
    public partial class ClienteForm : Form
    {
        public ClienteForm()
        {
            InitializeComponent();
        }

        public void btnRegistrarCliente_Click(object sender, EventArgs e)
        {
            bool bVacio = false;
            foreach (var ctrl in Controls)
            {
                if (ctrl is TextBox)
                {
                    TextBox textBox = ctrl as TextBox;
                    if (textBox.Text == String.Empty)
                    {
                        bVacio = true;
                    }
                }
            }

            if (bVacio == true)
            {
                MessageBox.Show("No se llenaron todos los campos", "Advertencia: Datos No Válidos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string DNIAux = txtDNI.Text;
                Boolean unicidad = TrabajarBD.comprobarDNI(DNIAux);
                if (unicidad == true)
                {
                    Cliente unCliente = new Cliente();
                    unCliente.Apellido = txtApellido.Text;
                    unCliente.Correo = txtCorreo.Text;
                    unCliente.DNI = txtDNI.Text;
                    unCliente.Domicilio = txtDomicilio.Text;
                    unCliente.Nombre = txtNombre.Text;
                    unCliente.Telefono = txtTelefono.Text;
                    TrabajarBD.insert_Cliente(unCliente);

                    foreach (var ctrl in Controls)
                    {
                        if (ctrl is TextBox)
                        {
                            TextBox textBox = ctrl as TextBox;
                            textBox.Clear();
                        }
                    }
                    btnExito_Click(null, null);
                }
                else
                {
                    MessageBox.Show("No se ha agregado el cliente, ya que posee un DNI ya existente", "Carga Fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void btnExito_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cliente Agregado Satisfactoriamente", "Carga Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
