using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Entidades
{
    public class FacturaMedicamento
    {
        private int factura_id;
        private int medicamento_id;
        private int cantidad;
        private decimal precio_unitario;

        public FacturaMedicamento(int factura_id, int medicamento_id, int cantidad, decimal precio_unitario)
        {
            this.factura_id = factura_id;
            this.medicamento_id = medicamento_id;
            this.cantidad = cantidad;
            this.precio_unitario = precio_unitario;
        }

        public FacturaMedicamento()
        {
            factura_id = 0;
            medicamento_id = 0;
            cantidad = 0;
            precio_unitario = 0;
        }

        public int FacturaId
        {
            get { return factura_id; }
            set { factura_id = value; }
        }

        public int MedicamentoId
        {
            get { return medicamento_id; }
            set { medicamento_id = value; }
        }

        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        public decimal PrecioUnitario
        {
            get { return precio_unitario; }
            set { precio_unitario = value; }
        }
    }
}
