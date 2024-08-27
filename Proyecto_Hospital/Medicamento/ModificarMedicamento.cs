using CapaNegocio.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Medicamento
{
    public partial class ModificarMedicamento : Form
    {
        private MedicamentoController controller;
        private bool estaEncontrado = false;
        public ModificarMedicamento()
        {
            InitializeComponent();
            controller = new MedicamentoController();
        }
        private void habilitarCampos(bool opcion)
        {
            tbxNombreComercial.Enabled = opcion;
            tbxNombreGenerico.Enabled = opcion;
            cbxPresentacion.Enabled = opcion;
            tbxDosis.Enabled = opcion;
            dtpFechaExpiracion.Enabled = opcion;
            tbxLote.Enabled = opcion;
            nudPrecio.Enabled = opcion;
            cbxProveedor.Enabled = opcion;
            rtbIndicaciones.Enabled = opcion;
        }

        private void setearCampos()
        {
            tbxNombreComercial.Text = string.Empty;
            tbxNombreGenerico.Text = string.Empty;
            cbxPresentacion.Text = string.Empty;
            tbxDosis.Text = string.Empty;
            dtpFechaExpiracion.Value = DateTime.Now;
            tbxLote.Text = string.Empty;
            nudPrecio.Text = string.Empty;
            cbxProveedor.Text = string.Empty;
            rtbIndicaciones.Text = string.Empty;
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!tbxId.Text.Equals(""))
            {
                int idMedicamento = Convert.ToInt32(tbxId.Text);
                Dictionary<string, object> medicamentoInfo = controller.GetMedicamentoPorId(idMedicamento);
                try
                {
                    tbxNombreComercial.Text = medicamentoInfo["NombreComercial"].ToString();
                    tbxNombreGenerico.Text = medicamentoInfo["NombreGenerico"].ToString();
                    cbxPresentacion.Text = controller.ObtenerNombrePresentacionMedianteIdMedico(idMedicamento);
                    tbxDosis.Text = medicamentoInfo["Dosis"].ToString();
                    dtpFechaExpiracion.Text = medicamentoInfo["FechaExpiracion"].ToString();
                    tbxLote.Text = medicamentoInfo["Lote"].ToString();
                    nudPrecio.Text = medicamentoInfo["Precio"].ToString();
                    cbxProveedor.Text = controller.ObtenerNombreProveedorMedianteIdMedico(idMedicamento);
                    rtbIndicaciones.Text = medicamentoInfo["Indicaciones"].ToString();


                    habilitarCampos(true);
                    estaEncontrado = true;
                    tbxId.ReadOnly = true;
                    btnBuscar.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ID no registrado como Medicamento");
                    setearCampos();
                    habilitarCampos(false);
                    estaEncontrado = false;
                }
            }
        }

        private void ModificarMedicamento_Load(object sender, EventArgs e)
        {
            habilitarCampos(false);
            CargarDatosComboBoxPresentaciones();
            CargarDatosComboBoxProveedores();
        }

        private void CargarDatosComboBoxPresentaciones()
        {
            Dictionary<int, string> presentaciones = controller.ObtenerPresentacionesParaMedicamento();

            foreach (KeyValuePair<int, string> presentacion in presentaciones)
            {
                cbxPresentacion.Items.Add(presentacion.Value);
            }

        }

        private void CargarDatosComboBoxProveedores()
        {
            Dictionary<int, string> proveedores = controller.ObtenerProveedoresParaMedicamento();

            foreach (KeyValuePair<int, string> proveedor in proveedores)
            {
                cbxProveedor.Items.Add(proveedor.Value);
            }
        }

        private void btnModificarMedicamento_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(tbxId.Text);
                string nombre_comercial = tbxNombreComercial.Text;
                string nombre_generico = tbxNombreGenerico.Text;
                int presentacion_id = controller.ObtenerIdPresentacionParaMedicamento(cbxPresentacion.Text);
                string dosis = tbxDosis.Text;
                DateTime fecha_expiracion = dtpFechaExpiracion.Value;
                string lote = tbxLote.Text;
                decimal precio = nudPrecio.Value;
                int proveedor_id = controller.ObtenerIdProveedorParaMedicamento(cbxProveedor.Text);
                string indicaciones = rtbIndicaciones.Text;

                var resultado = controller.ModificarMedicamento(id, nombre_comercial, nombre_generico, presentacion_id, dosis, fecha_expiracion, lote, precio, proveedor_id, indicaciones);

                if (resultado)
                {
                    MessageBox.Show("Modificación de Medicamento realizada con Éxito.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBorrarCampos_Click(object sender, EventArgs e)
        {
            setearCampos();
            habilitarCampos(false);
            tbxId.ReadOnly = false;
            btnBuscar.Enabled = true;
        }
    }
}
