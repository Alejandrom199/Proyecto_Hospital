using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Entidades
{
    public class Facturacion
    {
        private int id_factura;
        private Paciente paciente;
        private Medico medico;
        private DateTime fecha_factura;
        private Medicamento[] detalle_medicamentos;
        private double monto_total;
        private string estado_pago;
        private string metodo_pago;
        private DateTime fecha_pago;
        private string observaciones;

        // Constructor parametrizado
        public Facturacion(int id_factura, Paciente paciente, Medico medico, DateTime fecha_factura, Medicamento[] detalle_medicamentos, double monto_total, string estado_pago, string metodo_pago, DateTime fecha_pago, string observaciones)
        {
            this.id_factura = id_factura;
            this.paciente = paciente;
            this.medico = medico;
            this.fecha_factura = fecha_factura;
            this.detalle_medicamentos = detalle_medicamentos;
            this.monto_total = monto_total;
            this.estado_pago = estado_pago;
            this.metodo_pago = metodo_pago;
            this.fecha_pago = fecha_pago;
            this.observaciones = observaciones;
        }

        // Constructor por defecto
        public Facturacion()
        {
            id_factura = 0;
            paciente = null;
            medico = null;
            fecha_factura = DateTime.MinValue;
            detalle_medicamentos = new Medicamento[0];
            monto_total = 0.0;
            estado_pago = string.Empty;
            metodo_pago = string.Empty;
            fecha_pago = DateTime.Now;
            observaciones = string.Empty;
        }

        // Propiedades
        public int IdFactura
        {
            get { return id_factura; }
            set { id_factura = value; }
        }

        public Paciente Paciente
        {
            get { return paciente; }
            set { paciente = value; }
        }

        public Medico Medico
        {
            get { return medico; }
            set { medico = value; }
        }

        public DateTime FechaFactura
        {
            get { return fecha_factura; }
            set { fecha_factura = value; }
        }

        public Medicamento[] DetalleMedicamentos
        {
            get { return detalle_medicamentos; }
            set { detalle_medicamentos = value; }
        }

        public double MontoTotal
        {
            get { return monto_total; }
            set { monto_total = value; }
        }

        public string EstadoPago
        {
            get { return estado_pago; }
            set { estado_pago = value; }
        }

        public string MetodoPago
        {
            get { return metodo_pago; }
            set { metodo_pago = value; }
        }

        public DateTime FechaPago
        {
            get { return fecha_pago; }
            set { fecha_pago = value; }
        }

        public string Observaciones
        {
            get { return observaciones; }
            set { observaciones = value; }
        }
    }
}
