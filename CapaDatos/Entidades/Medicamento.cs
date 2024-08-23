using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Entidades
{
    public class Medicamento
    {
        private int id_medicamento;
        private string nombre_comercial;
        private string nombre_generico;
        private string presentacion;
        private string dosis;
        private DateTime fecha_expiracion;
        private string lote;
        private double precio;
        private string proveedor;
        private string indicaciones;

        // Constructor parametrizado
        public Medicamento(int id_medicamento, string nombre_comercial, string nombre_generico, string presentacion, string dosis, DateTime fecha_expiracion, string lote, double precio, string proveedor, string indicaciones)
        {
            this.id_medicamento = id_medicamento;
            this.nombre_comercial = nombre_comercial;
            this.nombre_generico = nombre_generico;
            this.presentacion = presentacion;
            this.dosis = dosis;
            this.fecha_expiracion = fecha_expiracion;
            this.lote = lote;
            this.precio = precio;
            this.proveedor = proveedor;
            this.indicaciones = indicaciones;
        }

        // Constructor por defecto
        public Medicamento()
        {
            id_medicamento = 0;
            nombre_comercial = string.Empty;
            nombre_generico = string.Empty;
            presentacion = string.Empty;
            dosis = string.Empty;
            fecha_expiracion = DateTime.Now;
            lote = string.Empty;
            precio = 0.0;
            proveedor = string.Empty;
            indicaciones = string.Empty;
        }

        // Propiedades
        public int IdMedicamento
        {
            get { return id_medicamento; }
            set { id_medicamento = value; }
        }

        public string NombreComercial
        {
            get { return nombre_comercial; }
            set { nombre_comercial = value; }
        }

        public string NombreGenerico
        {
            get { return nombre_generico; }
            set { nombre_generico = value; }
        }

        public string Presentacion
        {
            get { return presentacion; }
            set { presentacion = value; }
        }

        public string Dosis
        {
            get { return dosis; }
            set { dosis = value; }
        }

        public DateTime FechaExpiracion
        {
            get { return fecha_expiracion; }
            set { fecha_expiracion = value; }
        }

        public string Lote
        {
            get { return lote; }
            set { lote = value; }
        }

        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public string Proveedor
        {
            get { return proveedor; }
            set { proveedor = value; }
        }

        public string Indicaciones
        {
            get { return indicaciones; }
            set { indicaciones = value; }
        }
    }
}
