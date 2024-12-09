using CapaDatos.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaServicios.Interfaces
{
    public interface IFacturaMedicamento : IGestionEntidades<FacturaMedicamento>
    {
        int ObtenerIdMedicamentoParaFacturaMedicamento(string nombre);

        decimal ObtenerPrecioMedianteMedicamento(string nombre);

        DataTable listarConId(int factura_id);

        decimal ValorMontoTotal(int facturaId);

    }
}
