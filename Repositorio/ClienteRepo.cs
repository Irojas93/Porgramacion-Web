using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Dominio;

namespace Repositorio
{
    public class ClienteRepo
    {
        ClienteDom clienteDom = new ClienteDom();


        string datosConexion = "Data Source = NACH; Initial Catalog = tallerMecanico2017; Integrated Security=true;";
        SqlConnection conexion = new SqlConnection();

        public void GuardarCliente(ClienteDom clienteDom)
        {
            conexion.ConnectionString = datosConexion;
            conexion.Open();

            string query = "insert into Clientes values('" + clienteDom.Nombre + "','" + clienteDom.Apellido + "','" + clienteDom.Direccion + "','" + clienteDom.Telefono + "')";
            SqlCommand cmd = new SqlCommand(query, conexion);
            cmd.ExecuteNonQuery();

            conexion.Close();
        }

        public DataTable ListCliente()
        {
            DataTable dt = new DataTable();

            conexion.ConnectionString = datosConexion;

            conexion.Open();

            string query = "select * from Clientes";

            SqlCommand cmd = new SqlCommand(query, conexion);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            conexion.Close();

            return dt;
        }

        public DataTable LlenarCampos(int clienteId)
        {
            DataTable dt = new DataTable();
            conexion.ConnectionString = datosConexion;

            conexion.Open();

            string query = "select * from Clientes where Clientes.clienteId = " + clienteId;

            SqlCommand cmd = new SqlCommand(query, conexion);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            conexion.Close();
            return dt;
        }

        public void Modificar(int clienteId, ClienteDom clienteDom)
        {

            conexion.ConnectionString = datosConexion;
            conexion.Open();

            string query = "UPDATE Clientes SET clienteNombre ='"+ clienteDom.Nombre +"',clienteApellido ='" + clienteDom.Apellido + "',clienteDireccion = '" + clienteDom.Direccion + "',clienteTelefono= '" + clienteDom.Telefono + "' where clienteId = "+ clienteId;
            SqlCommand cmd = new SqlCommand(query, conexion);
            cmd.ExecuteNonQuery();

            conexion.Close();

        }
    }
}
