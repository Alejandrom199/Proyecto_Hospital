﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CapaPersistencia
{
    public class ConnectionDB
    {

        private SqlConnection cadena_conexion = new SqlConnection("Data Source=ALEJANDRO-PC;Initial Catalog=Proyecto_Hospital;Persist Security Info=True;User ID=sa;Password=sa");
        public SqlConnection AbrirConexion()
        {
            try
            {
                if (cadena_conexion != null && cadena_conexion.State == System.Data.ConnectionState.Closed)
                {
                    cadena_conexion.Open();
                }
                return cadena_conexion;
            }
            catch (Exception ex)
            {
                throw new Exception("Error de conexion" + ex.Message);
            }

        }

        public SqlConnection CerrarConexion()
        {
            try
            {
                if (cadena_conexion != null && cadena_conexion.State == System.Data.ConnectionState.Open)
                {
                    cadena_conexion.Close();
                }
                return cadena_conexion;
            }
            catch (Exception ex)
            {
                throw new Exception("Error de conexion" + ex.Message);
            }

        }

        public SqlConnection Cadena_Conexion
        {
            get { return cadena_conexion; }
        }
    }
}
