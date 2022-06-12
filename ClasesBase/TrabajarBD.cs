using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajarBD
    {
        public static void insert_Antecedente(Antecedente unAntecedente)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.GestionMaquinariasBDConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO TablaAntecedentes(ant_Titulo, ant_Descripcion, id_Cliente) values(@Titulo,@Descripcion,@IdCliente)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@Titulo", unAntecedente.Titulo);
            cmd.Parameters.AddWithValue("@Descripcion", unAntecedente.Descripcion);
            cmd.Parameters.AddWithValue("@IdCliente", 1);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }


        public static void insert_Cliente(Cliente unCliente)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.GestionMaquinariasBDConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO TablaClientes(cli_Nombre, cli_Apellido, cli_DNI,cli_Telefono, cli_Correo, cli_Direccion) values(@Nombre,@Apellido,@DNI,@Telefono,@Correo,@Direccion)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@Nombre", unCliente.Nombre);
            cmd.Parameters.AddWithValue("@Telefono", unCliente.Telefono);
            cmd.Parameters.AddWithValue("@Apellido", unCliente.Apellido);
            cmd.Parameters.AddWithValue("@DNI", unCliente.DNI);
            cmd.Parameters.AddWithValue("@Correo", unCliente.Correo);
            cmd.Parameters.AddWithValue("@Direccion", unCliente.Domicilio);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }


        public static DataTable list_clientes()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.GestionMaquinariasBDConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM ListarClientes";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }


        public static DataTable list_antecedentes(int id)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.GestionMaquinariasBDConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SP_ListAntecedentes";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@Cliente", id);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static DataTable buscarCli(int id)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.GestionMaquinariasBDConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM ListarClientes WHERE IdCliente=@ID";

            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@ID", id);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }


        public static Boolean comprobarDNI(string dni)
        {

            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.GestionMaquinariasBDConnectionString);
            cnn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT COUNT(*) FROM ListarClientes WHERE DNI = @DNI;";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@DNI", dni);
            Int32 valor = Convert.ToInt32(cmd.ExecuteScalar());
            if (valor != 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        public static int count_of_Antecedentes(int id)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.GestionMaquinariasBDConnectionString);

            cnn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SP_CountAntecedentes";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@ID", id);

            int count = (int)cmd.ExecuteScalar();
            return count;
        }


        public static DataTable list_maquinarias()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.GestionMaquinariasBDConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM vw_ListarMaquinarias WHERE Estado = 'Disponible'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }


        public static DataTable buscarMaq(int id)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.GestionMaquinariasBDConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM vw_ListarMaquinarias WHERE IdMaquinaria=@ID";

            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@ID", id);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
    }

}
