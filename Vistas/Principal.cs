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

        private void load_cmbClientes()
        {
            DataTable dt = TrabajarBD.list_clientes();
            cmbClientes.DataSource = dt;
            dt.Columns.Add("FullName",
            typeof(string), "Nombre + ' ' + Apellido + ' '+ DNI");
            if (dt.Rows.Count != 0)
            {
                btnRegistrarAlquiler.Enabled = true;
                cmbClientes.Enabled = true;
                lblClientesSinResult.Text = "";
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
            else { 
                btnRegistrarAlquiler.Enabled=false;
                cmbClientes.Enabled = false;
                lblClientesSinResult.Text = "No hay ningun cliente registrado";
                lblClientesSinResult.ForeColor = System.Drawing.Color.Red;


                MessageBox.Show("No Hay clientes, primero cargue alguno", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void load_cmbClientesReserva()
        {
            DataTable dt = TrabajarBD.list_clientes();
            cmbClienteReserva.DataSource = dt;
            dt.Columns.Add("FullName",
            typeof(string), "Nombre + ' ' + Apellido + ' '+ DNI");

            if (dt.Rows.Count != 0)
            {
                btnRegistrarAlquiler.Enabled = true;
                cmbClienteReserva.Enabled = true;
                lblClientesSinResult.Text = "";
                cmbClienteReserva.DisplayMember = "FullName";
                cmbClienteReserva.ValueMember = "IdCliente";
                int i = (int)cmbClienteReserva.SelectedValue;
                int antecedentes = TrabajarBD.count_of_Antecedentes(i);
                if (antecedentes == 0)
                {
                    lblAntecedentesReservaResultado.ForeColor = System.Drawing.Color.Green;
                }
                else if (antecedentes == 1)
                {
                    lblAntecedentesReservaResultado.ForeColor = System.Drawing.Color.Orange;
                }
                else
                {
                    lblAntecedentesReservaResultado.ForeColor = System.Drawing.Color.Red;
                }
                lblAntecedentesReservaResultado.Text = "Este cliente tiene: " + TrabajarBD.count_of_Antecedentes(i).ToString() + " antecedente/s.";
            }
            else {
                btnRegistrarReserva.Enabled = false;
                cmbClienteReserva.Enabled = false;
                lblClientesSinResult.Text = "No hay ningun cliente registrado";
                lblClientesSinResult.ForeColor = System.Drawing.Color.Red;


                //MessageBox.Show("No Hay clientes, primero cargue alguno", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void load_cmbMaquinariaReserva()
        {
            DataTable dtMaquinarias = TrabajarBD.list_maquinarias();
            cmbMaquinariasReserva.DataSource = dtMaquinarias;
            dtMaquinarias.Columns.Add("MarcaModelo",
            typeof(string), "Marca + ' ' + Modelo");
            if (dtMaquinarias.Rows.Count != 0)
            {
                cmbMaquinariasReserva.Enabled = true;
                cmbMaquinariasReserva.DisplayMember = "MarcaModelo";
                cmbMaquinariasReserva.ValueMember = "IdMaquinaria";
                int j = (int)cmbMaquinariasReserva.SelectedValue;

                //int j = (int)cmbMaquinarias.SelectedValue;
                DataTable dtPrecio = TrabajarBD.buscarMaq(j);
                decimal precio = (from DataRow dr in dtPrecio.Rows
                                  where (int)dr["IdMaquinaria"] == j
                                  select (decimal)dr["PrecioAlquiler"]).FirstOrDefault();
                lblPrecioReservaResultado.Text = precio + "$ por/día.";

                foreach (DataRow row in dtMaquinarias.Rows)
                {
                    if (row["IdMaquinaria"].ToString() == j.ToString())
                    {
                        //imagen=(Image)row["Imagen"];
                        //pbMaquinaria.Image = imagen;
                    }
                }
            }
            else
            {
                cmbMaquinariasReserva.Enabled = false;
            }
        }


        private void load_cmbMaquinaria()
        {
            DataTable dtMaquinarias = TrabajarBD.list_maquinarias();
            cmbMaquinarias.DataSource = dtMaquinarias;
            dtMaquinarias.Columns.Add("MarcaModelo",
            typeof(string), "Marca + ' ' + Modelo");

            if (dtMaquinarias.Rows.Count != 0)
            {
                cmbMaquinarias.Enabled = true;
                lblMaquinariaDisponible.Text = "";
                cmbMaquinarias.DisplayMember = "MarcaModelo";
                cmbMaquinarias.ValueMember = "IdMaquinaria";
                int j = (int)cmbMaquinarias.SelectedValue;

                //int j = (int)cmbMaquinarias.SelectedValue;
                DataTable dtPrecio = TrabajarBD.buscarMaq(j);
                decimal precio = (from DataRow dr in dtPrecio.Rows
                                  where (int)dr["IdMaquinaria"] == j
                                  select (decimal)dr["PrecioAlquiler"]).FirstOrDefault();
                lblPrecioAlquilerResultado.Text = precio + "$ por/día.";
            }
            else
            {
                cmbMaquinarias.Enabled = false;
                lblMaquinariaDisponible.Text = "No hay maquinarias disponibles en el momento";
                lblMaquinariaDisponible.ForeColor = System.Drawing.Color.Red;
                btnRegistrarAlquiler.Enabled = false;
            }
            }

        private void Principal_Load(object sender, EventArgs e)
        {
            dtpFinAlquiler.MinDate = DateTime.Today.AddDays(1);
            dtpInicioreserva.MinDate = DateTime.Today.AddDays(1);
            dtpFinReserva.MinDate = DateTime.Today.AddDays(2);
            load_cmbClientes();
            load_cmbClientesReserva();
            load_cmbMaquinariaReserva();
            load_cmbMaquinaria(); 
            calcularPrecioAlquiler();
            calcularPrecioReserva();
            

            /*foreach (DataRow row in dtMaquinarias.Rows) 
            {
                if (row["IdMaquinaria"].ToString() == j.ToString()) 
                {
                    //imagen=(Image)row["Imagen"];
                    //pbMaquinaria.Image = imagen;
                }
            }*/

        }

        private void btnMasInformacion_Click(object sender, EventArgs e)
        {
            int indice= (int)cmbClientes.SelectedValue;
            ListarAntecedentesForm antForm = new ListarAntecedentesForm(indice);
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
            load_cmbClientesReserva();
        }

        private void btnRegistrarAlquiler_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Quieres registrar este Alquiler?", "Mensaje de Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int clienteID = (int)cmbClientes.SelectedValue;
                int maquinariaID = (int)cmbMaquinarias.SelectedValue;
                DateTime fechaInicio = DateTime.Now;
                DateTime fechaFin = dtpFinAlquiler.Value;
                int j = (int)cmbMaquinarias.SelectedValue;
                DataTable dtPrecio = TrabajarBD.buscarMaq(j);
                decimal precio = (from DataRow dr in dtPrecio.Rows
                                  where (int)dr["IdMaquinaria"] == j
                                  select (decimal)dr["PrecioAlquiler"]).FirstOrDefault();
                int dias = (dtpFinAlquiler.Value - DateTime.Today).Days;
                precio = precio * dias;

                Alquiler unAlquiler = new Alquiler();
                unAlquiler.FechaInicio = fechaInicio;
                unAlquiler.FechaEntrega = fechaFin;
                unAlquiler.idCliente = clienteID;
                unAlquiler.idMaquinaria = maquinariaID;
                unAlquiler.PrecioAlquiler = precio;

                TrabajarBD.insert_Alquiler(unAlquiler);
                TrabajarBD.modificar_estado_Maquinaria(maquinariaID);

                dtpFinAlquiler.Value = DateTime.Today.AddDays(1);
                load_cmbClientes();
                load_cmbMaquinaria();
                MessageBox.Show("Alquiler registrado exitosamente", "Operacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cmbMaquinarias_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int j = (int)cmbMaquinarias.SelectedValue;
            DataTable dtPrecio = TrabajarBD.buscarMaq(j);
            decimal precio = (from DataRow dr in dtPrecio.Rows
                      where (int)dr["IdMaquinaria"] == j
                      select (decimal)dr["PrecioAlquiler"]).FirstOrDefault();
            lblPrecioAlquilerResultado.Text = precio + "$ por/día.";
            calcularPrecioAlquiler();
        }

        private void cmbClienteReserva_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int i = (int)cmbClienteReserva.SelectedValue;
            int antecedentes = TrabajarBD.count_of_Antecedentes(i);
            if (antecedentes == 0)
            {
                lblAntecedentesReservaResultado.ForeColor = System.Drawing.Color.Green;
            }
            else if (antecedentes == 1)
            {
                lblAntecedentesReservaResultado.ForeColor = System.Drawing.Color.Orange;
            }
            else
            {
                lblAntecedentesReservaResultado.ForeColor = System.Drawing.Color.Red;
            }
            lblAntecedentesReservaResultado.Text = "Este cliente tiene: " + TrabajarBD.count_of_Antecedentes(i).ToString() + " antecedente/s.";
        }

        private void cmbMaquinariasReserva_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int j = (int)cmbMaquinariasReserva.SelectedValue;
            DataTable dtPrecio = TrabajarBD.buscarMaq(j);
            decimal precio = (from DataRow dr in dtPrecio.Rows
                              where (int)dr["IdMaquinaria"] == j
                              select (decimal)dr["PrecioAlquiler"]).FirstOrDefault();
            lblPrecioReservaResultado.Text = precio + "$ por/día.";
            calcularPrecioReserva();
        }

        private void añadirMaquinariaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MaquinariaForm maquinariaForm = new MaquinariaForm();
            maquinariaForm.Show();
        }

        private void modificarMaquinariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModificarMaquinariaForm modificarMaquinarias = new ModificarMaquinariaForm();
            modificarMaquinarias.Show();
        }

        private void generarNuevoRolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RolesForm rolesForm = new RolesForm();
            rolesForm.Show();
        }

        private void registrarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmpleadoForm empleadoForm = new EmpleadoForm();
            empleadoForm.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            /*ModificarEmpleadoForm empleadoModificar = new ModificarEmpleadoForm();
            empleadoModificar.Show();*/
        }

        private void registrarContactoDeEmergenciaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormContactos formContactos = new FormContactos();
            formContactos.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FormModificarContactos modifCont = new FormModificarContactos();
            modifCont.Show();
        }

        private void agregarAntecedenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AntecedentesForm antForm = new AntecedentesForm();
            antForm.Show();
        }

        private void eliminarAntecedenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionarAntecedente gestAnt = new GestionarAntecedente();
            gestAnt.Show();
        }

        private void registrarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClienteForm cliForm = new ClienteForm();
            cliForm.Show();
        }

        private void modificarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClienteModificar cliMod = new ClienteModificar();
            cliMod.Show();
        }

        private void cancelarReservaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModificarReservas modRes = new ModificarReservas();
            modRes.Show();
        }

        private void generarReciboToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReciboForm recForm = new ReciboForm();
            recForm.Show();
        }

        private void listarAlquileresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListarAlquileres la = new ListarAlquileres();
            la.Show();
        }

        private void verInformeDeSeguimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LineaMaquinariaNoDevueltaForm linea = new LineaMaquinariaNoDevueltaForm();
            linea.Show();
        }

        private void generarInformeMaquinariaNoDevueltaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListarMaquinariasNoDevueltas maq = new ListarMaquinariasNoDevueltas();
            maq.Show();
        }

        private void verInformeDeAlquilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListarInformeAlquileres al = new ListarInformeAlquileres();
            al.Show();
        }

        private void generarInformeDeAlquileresToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void btnMasInformacionReserva_Click(object sender, EventArgs e)
        {
            int indice = (int)cmbClienteReserva.SelectedValue;
            ListarAntecedentesForm antForm = new ListarAntecedentesForm(indice);
            antForm.Show();
        }

        private void btnRegistrarClienteReserva_Click(object sender, EventArgs e)
        {
            ClienteForm clienteForm = new ClienteForm();
            clienteForm.Show();
            clienteForm.btnRegistrarCliente.Click += button_clicked;
        }

        private void dtpInicioreserva_ValueChanged(object sender, EventArgs e)
        {
            dtpFinReserva.MinDate = dtpInicioreserva.Value.AddDays(1);
            int dias= (dtpFinReserva.Value - dtpInicioreserva.Value).Days;
            calcularPrecioReserva();
        }

        private void dtpFinReserva_ValueChanged(object sender, EventArgs e)
        {
            calcularPrecioReserva();
        }

        private void calcularPrecioReserva()
        {
           // load_cmbMaquinariaReserva();
            if (cmbMaquinarias.SelectedValue != null)
            {
                int j = (int)cmbMaquinariasReserva.SelectedValue;
                DataTable dtPrecio = TrabajarBD.buscarMaq(j);
                decimal precio = (from DataRow dr in dtPrecio.Rows
                                  where (int)dr["IdMaquinaria"] == j
                                  select (decimal)dr["PrecioAlquiler"]).FirstOrDefault();
                int dias = (dtpFinReserva.Value - dtpInicioreserva.Value).Days;
                precio = precio * dias;
                lblPrecioFinalReserva.Text = precio.ToString() + " $";
            }
        }

        private void calcularPrecioAlquiler()
        {
            //load_cmbMaquinaria();
            if (cmbMaquinarias.SelectedValue != null)
            {
                int j = (int)cmbMaquinarias.SelectedValue;
                DataTable dtPrecio = TrabajarBD.buscarMaq(j);
                decimal precio = (from DataRow dr in dtPrecio.Rows
                                  where (int)dr["IdMaquinaria"] == j
                                  select (decimal)dr["PrecioAlquiler"]).FirstOrDefault();
                int dias = (dtpFinAlquiler.Value - DateTime.Today).Days;
                precio = precio * dias;
                lblPrecioFinalAlquiler.Text = precio.ToString() + " $";
            }
        }

        private void dtpFinAlquiler_ValueChanged(object sender, EventArgs e)
        {
            calcularPrecioAlquiler();
        }






    }
}
