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
    public partial class ListarAlquileres : Form
    {
        public ListarAlquileres()
        {
            InitializeComponent();
        }

        private void ListarAlquileres_Load(object sender, EventArgs e)
        {
            loadDGV();
        }

        private void loadDGV() 
        {
            DataTable dt = TrabajarBD.list_alquileres();
            dgv_Alquileres.DataSource = dt;
        }
    }
}
