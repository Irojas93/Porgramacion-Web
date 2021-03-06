﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Dominio;

namespace Repositorio
{
    public class TurnoRepo
    {
        //Prueba github
        //Segundo comentario
        TurnoDom turnoDom = new TurnoDom();


        string datosConexion = "Data Source = NACH; Initial Catalog = tallerMecanico2017; Integrated Security=true;";
        SqlConnection conexion = new SqlConnection();

        public void GuardarCliente(TurnoDom turnoDom)
        {
            conexion.ConnectionString = datosConexion;
            conexion.Open();

            string query = "insert into Turnos values('" + turnoDom.TurnoFechaDeRegistro + "','" + turnoDom.TurnoFecha + "','" + turnoDom.Motivo + "','" + turnoDom.Descripcion + "','" + turnoDom.ClienteId + "')";
            SqlCommand cmd = new SqlCommand(query, conexion);
            cmd.ExecuteNonQuery();

            conexion.Close();
        }

        public DataTable RecuperarTurno(int turnoId)
        {
            DataTable dt = new DataTable();

            conexion.ConnectionString = datosConexion;

            conexion.Open();

            string query = "select * from Turnos join Clientes on Clientes.clienteId = Turnos.clienteId where Turnos.turnoId = "+ turnoId;

            SqlCommand cmd = new SqlCommand(query, conexion);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            conexion.Close();

            return dt;
        }

        public void ModificarTurno(int turnoId,TurnoDom turnoDom)
        {

            conexion.ConnectionString = datosConexion;
            conexion.Open();

            string query = "UPDATE Turnos SET turnoFecha ='" + turnoDom.TurnoFecha + "',turnoMotivo ='" + turnoDom.Motivo + "',turnoDescripcion = '" + turnoDom.Descripcion + "',clienteId= '" + turnoDom.ClienteId + "' where turnoId = " + turnoId;
            SqlCommand cmd = new SqlCommand(query, conexion);
            cmd.ExecuteNonQuery();

            conexion.Close();

        }

        public DataTable listTurnos()
        {
            DataTable dt = new DataTable();

            conexion.ConnectionString = datosConexion;

            conexion.Open();

            string query = "select * from Turnos join Clientes on Clientes.clienteId = Turnos.clienteId";

            SqlCommand cmd = new SqlCommand(query, conexion);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            conexion.Close();

            return dt;
        }
    }
}
