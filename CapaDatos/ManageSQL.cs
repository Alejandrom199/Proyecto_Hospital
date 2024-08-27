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

        public int EjecutarSPSelectInt(string storedProcedureName, SqlParameter[] parameters)
        {
            int resultado = 0;

            var command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = storedProcedureName;

            if (parameters != null)
            {
                command.Parameters.AddRange(parameters);
            }

            command.Connection = conn.AbrirConexion();

            try
            {
                // Ejecuta el comando y obtiene el valor como entero
                var result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int parsedResult))
                {
                    resultado = parsedResult;
                }
            }
            finally
            {
                conn.CerrarConexion();
            }

            return resultado;
        }

        public string EjecutarSPSelectString(string storedProcedureName, SqlParameter[] parameters)
        {
            string resultado = "";

            var command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = storedProcedureName;

            if (parameters != null)
            {
                command.Parameters.AddRange(parameters);
            }

            command.Connection = conn.AbrirConexion();

            try
            {
                // Ejecuta el comando y obtiene el valor como entero
                var result = command.ExecuteScalar();
                if (result != null)
                {
                    resultado = result.ToString();
                }
            }
            finally
            {
                conn.CerrarConexion();
            }

            return resultado;
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

        public Dictionary<string, object> EjecutarSPSelectMedico(string storedProcedureName, SqlParameter[] parameters)
        {
            var medicoDict = new Dictionary<string, object>();
            var command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = storedProcedureName;

            if (parameters != null)
            {
                command.Parameters.AddRange(parameters);
            }

            command.Connection = conn.AbrirConexion();
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                medicoDict["Nombre"] = reader["nombre"];
                medicoDict["Apellido"] = reader["apellido"];
                medicoDict["Cedula"] = reader["cedula"];
                medicoDict["FechaNacimiento"] = reader["fecha_nacimiento"];
                medicoDict["EspecialidadId"] = reader["especialidad_id"];
                medicoDict["NumeroLicencia"] = reader["numero_licencia"];
                medicoDict["Sexo"] = reader["sexo"];
                medicoDict["Telefono"] = reader["telefono"];
                medicoDict["Email"] = reader["email"];
                medicoDict["HorarioAtencionId"] = reader["horario_atencion_id"];
                medicoDict["ConsultorioId"] = reader["consultorio_id"];
                medicoDict["FechaContratacion"] = reader["fecha_contratacion"];
            }

            reader.Close();
            conn.CerrarConexion();
            return medicoDict;
        }

        public Dictionary<int, string> EjecutarSPSelectIntToStringUnCampo(string storedProcedureName, string campo, SqlParameter[] parameters)
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
                int key = Convert.ToInt32(reader["id"]);
                string value = reader[campo].ToString();

                campoDict[key] = value;
            }

            reader.Close();
            conn.CerrarConexion();
            return campoDict;
        }

        public Dictionary<int, string> EjecutarSPSelectIntToStringDosCampos(string storedProcedureName, string campo1, string campo2, SqlParameter[] parameters)
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
                int key = Convert.ToInt32(reader["id"]);
                string value = reader[campo1].ToString() + " - " + reader[campo2].ToString();

                campoDict[key] = value;
            }

            reader.Close();
            conn.CerrarConexion();
            return campoDict;
        }
    }
}
