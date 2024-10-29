using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Entidades
{
    public class Facturacion
    {
        private int id;
        private int paciente_id;
        private int medico_id;
        private string metodo_pago;
        private string observaciones;
        private decimal monto_total;
        private DateTime fecha_factura;

        // Constructor parametrizado
        public Facturacion(int id, int paciente_id, int medico_id, string metodo_pago, string observaciones)
        {
            this.id = id;
            this.paciente_id = paciente_id;
            this.medico_id = medico_id;
            this.metodo_pago = metodo_pago;
            this.observaciones = observaciones;
            this.monto_total = 0;
            this.fecha_factura = DateTime.Now;
        }

        // Constructor por defecto
        public Facturacion()
        {
            id = 0;
            paciente_id = 0;
            medico_id = 0;
            metodo_pago = string.Empty;
            observaciones = string.Empty;
            monto_total = 0;
            fecha_factura = DateTime.Now;
        }

        // Propiedades
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int PacienteId
        {
            get { return paciente_id; }
            set { paciente_id = value; }
        }

        public int MedicoId
        {
            get { return medico_id; }
            set { medico_id = value; }
        }

        public string MetodoPago
        {
            get { return metodo_pago; }
            set { metodo_pago = value; }
        }

        public string Observaciones
        {
            get { return observaciones; }
            set { observaciones = value; }
        }

        public decimal MontoTotal
        {
            get { return monto_total; }
            set { monto_total = value; }
        }

        public DateTime FechaFactura
        {
            get { return fecha_factura; }
            set { fecha_factura = value; }
        }
    }
}
