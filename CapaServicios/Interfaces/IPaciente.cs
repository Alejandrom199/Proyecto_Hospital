using CapaDatos.Entidades;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaServicios.Interfaces
{
    public interface IPaciente : IGestionEntidades<Paciente>
    {
        Dictionary<string, object> buscar_por_ID(int id);

        DataTable filtrar_por_ID(int id);

        DataTable filtrar_por_nombre(string nombre);

        DataTable filtrar_por_apellido(string apellido);

        DataTable filtrar_por_cedula(string cedula);
    }
}
