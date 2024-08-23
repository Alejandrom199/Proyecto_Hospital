using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Entidades;
using System.Reflection.PortableExecutable;

namespace CapaPersistencia
{
    public class ManageSQL
    {
        private ConnectionDB conn = new ConnectionDB();
        public bool EjecutarSPSql(string storedProcedureName, SqlParameter[] parameters)
        {
            var command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = storedProcedureName;

            if (parameters != null)
            {
                command.Parameters.AddRange(parameters);
            }

            command.Connection = conn.AbrirConexion();
            var resultado = command.ExecuteNonQuery();
            conn.CerrarConexion();

            if (resultado > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public object EjecutarSPSelectScalar(string storedProcedureName, SqlParameter[] parameters)
        {
            var command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = storedProcedureName;

            if (parameters != null)
            {
                command.Parameters.AddRange(parameters);
            }

            command.Connection = conn.AbrirConexion();

            // Utiliza ExecuteScalar para obtener un solo valor
            object result = command.ExecuteScalar();

            conn.CerrarConexion();

            return result;
        }

        public DataTable EjecutarSPSelect(string storedProcedureName, SqlParameter[] parameters)
        {
            var command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = storedProcedureName;

            if (parameters != null)
            {
                command.Parameters.AddRange(parameters);
            }

            command.Connection = conn.AbrirConexion();
            SqlDataReader reader = command.ExecuteReader();
            using (var tabla = new DataTable())
            {
                tabla.Load(reader);
                reader.DisposeAsync();
                conn.CerrarConexion();
                return tabla;
            }
        }

        public Dictionary<string, object> EjecutarSPSelectPaciente(string storedProcedureName, SqlParameter[] parameters)
        {
            var pacienteDict = new Dictionary<string, object>();
            var command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = storedProcedureName;

            if (parameters != null)
            {
                command.Parameters.AddRange(parameters);
            }

            command.Connection = conn.AbrirConexion();
            SqlDataReader reader = command.ExecuteReader();
            //Paciente paciente = null;

            if (reader.Read())
            {
                pacienteDict["Nombre"] = reader["nombre"];
                pacienteDict["Apellido"] = reader["apellido"];
                pacienteDict["Cedula"] = reader["cedula"];
                pacienteDict["FechaNacimiento"] = reader["fecha_nacimiento"];
                pacienteDict["Sexo"] = reader["sexo"];
                pacienteDict["Direccion"] = reader["direccion"];
                pacienteDict["Telefono"] = reader["telefono"];
                pacienteDict["Email"] = reader["email"];
                pacienteDict["FechaRegistro"] = reader["fecha_registro"];
                pacienteDict["HistorialMedico"] = reader["historial_medico"];
            }

            reader.Close();
            conn.CerrarConexion();
            return pacienteDict;
        }

        public Dictionary<int, string> EjecutarSPSelectUnCampo(string storedProcedureName, string campo,SqlParameter[] parameters)
        {
            var campoDict = new Dictionary<int, string>();
            var command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = storedProcedureName;

            if (parameters != null)
            {
                command.Parameters.AddRange(parameters);
            }

            command.Connection = conn.AbrirConexion();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int id = Convert.ToInt32(reader["id"]);
                string nombre = reader[campo].ToString();

                campoDict[id] = nombre;
            }

            reader.Close();
            conn.CerrarConexion();
            return campoDict;
        }

        public Dictionary<int, string> EjecutarSPSelectDosCampos(string storedProcedureName, string campo1, string campo2, SqlParameter[] parameters)
        {
            var campoDict = new Dictionary<int, string>();
            var command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = storedProcedureName;

            if (parameters != null)
            {
                command.Parameters.AddRange(parameters);
            }

            command.Connection = conn.AbrirConexion();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int id = Convert.ToInt32(reader["id"]);
                string nombre = reader[campo1].ToString() + " - " + reader[campo2].ToString() ;

                campoDict[id] = nombre;
            }

            reader.Close();
            conn.CerrarConexion();
            return campoDict;
        }
    }
}
