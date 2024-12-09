using CapaDatos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaServicios.Interfaces
{
    public interface IFacturacion : IGestionEntidades<Facturacion>
    {
        Dictionary<int, string> ObtenerPacientesParaFacturacion();

        Dictionary<int, string> ObtenerMedicosParaFacturacion();

        Dictionary<int, string> ObtenerMedicamentosParaFacturacion();

        int ObtenerIdPacienteParaFacturacion(string nombre);

        int ObtenerIdMedicoParaFacturacion(string nombre);

        int ObtenerIdMedicamentoParaFacturacion(string nombre);

        string ObtenerPacienteMedianteIdFacturacion(int id);

        string ObtenerMedicoMedianteIdFacturacion(int id);

        string ObtenerMedicamentoMedianteIdFacturacion(int id);

        int ObtenerFacturaIdReciente();

        decimal ValorMontoTotal(int facturaId);
    }
}
