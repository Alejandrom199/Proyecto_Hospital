using CapaDatos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaServicios.Interfaces
{
    public interface IMedicamento : IGestionEntidades<Medicamento>
    {
        Dictionary<string, object> buscar_por_ID(int id);
        Dictionary<int, string> ObtenerPresentacionesParaMedicamento();

        Dictionary<int, string> ObtenerProveedoresParaMedicamento();

        int ObtenerIdPresentacionParaMedicamento(string nombre);

        int ObtenerIdProveedorParaMedicamento(string nombre);

        string ObtenerPresentacionMedianteIdMedicamento(int id);

        string ObtenerProveedorMedianteIdMedicamento(int id);
    }
}
