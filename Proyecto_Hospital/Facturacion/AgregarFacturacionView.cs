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

namespace CapaPresentacion.Facturacion
{
    public partial class AgregarFacturacionView : Form
    {
        FacturacionController controller;
        FacturaMedicamentoController controller2;
        private int facturaIdGenerada;



        public AgregarFacturacionView()
        {
            InitializeComponent();
            controller = new FacturacionController();
            controller2 = new FacturaMedicamentoController();

            HabilitarOpcionesFactura(false);
            lblNoFactura.Text = "n/a";
            btnAgregarFacturacion.Enabled = false;
            btnGetMonto.Enabled = false;

        }

        private void HabilitarOpcionesFactura(bool opcion)
        {
            cbxPaciente.Enabled = opcion;
            cbxMedico.Enabled = opcion;
            cbxMetodoPago.Enabled = opcion;
            rtbObservaciones.Enabled = opcion;
            btnAnadirMedicamentosFactura.Enabled = opcion;
            btnBorrarCampos.Enabled = opcion;
        }

        private void borrarCampos()
        {
            cbxPaciente.Text = string.Empty;
            cbxMedico.Text = string.Empty;
            cbxMetodoPago.Text = string.Empty;
            rtbObservaciones.Text = string.Empty;
        }
        private void CargarDatosComboBoxPacientes()
        {
            Dictionary<int, string> pacientes = controller.ObtenerPacientesParaFacturacion();

            foreach (KeyValuePair<int, string> paciente in pacientes)
            {
                cbxPaciente.Items.Add(paciente.Value);
            }

        }

        private void CargarDatosComboBoxMedicos()
        {
            Dictionary<int, string> medicos = controller.ObtenerMedicosParaFacturacion();

            foreach (KeyValuePair<int, string> medico in medicos)
            {
                cbxMedico.Items.Add(medico.Value);
            }

        }

        private void btnAnadirMedicamentosFactura_Click(object sender, EventArgs e)
        {

            if (cbxPaciente.Text != "" && cbxMedico.Text != "" && cbxMetodoPago.Text != "" && rtbObservaciones.Text != "")
            {

                try
                {
                    btnGetMonto.Enabled = true;
                    new AnadirMedicamentosAFacturaView(facturaIdGenerada).Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Para poder acceder a añadir Medicamentos, debe llenar todos los campos anteriores");
            }

        }

        private void btnGenerarFactura_Click(object sender, EventArgs e)
        {
            var resultado = controller.AgregarFacturacion();


            if (resultado)
            {
                facturaIdGenerada = controller.ObtenerIdFacturaReciente();
                btnGenerarFactura.Enabled = false;
                HabilitarOpcionesFactura(true);
                lblNoFactura.Text = facturaIdGenerada.ToString();
            }
        }

        private void btnAgregarFacturacion_Click(object sender, EventArgs e)
        {
            if (cbxPaciente.Text != "" && cbxMedico.Text != "" && cbxMetodoPago.Text != "" && rtbObservaciones.Text != "")
            {
                try
                {
                    int paciente_id = controller.ObtenerIdPacienteParaFacturacion(cbxPaciente.Text);
                    int medico_id = controller.ObtenerIdMedicoParaFacturacion(cbxMedico.Text);
                    string metodo_pago = cbxMetodoPago.Text;
                    string observaciones = rtbObservaciones.Text;
                    decimal montoTotal = Convert.ToDecimal(tbxMontoTotal.Text);
                    MessageBox.Show(montoTotal.ToString());

                    var resultado = controller.ModificarFactura(facturaIdGenerada, paciente_id, medico_id, metodo_pago, observaciones, montoTotal);
                    //controller.ObtenerMontoTotal(facturaIdGenerada);

                    if (resultado)
                    {
                        MessageBox.Show("Registro de Factura creado con Éxito.");
                        borrarCampos();
                        HabilitarOpcionesFactura(false);
                        btnAgregarFacturacion.Enabled = false;
                        btnGenerarFactura.Enabled = true;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Para poder acceder a añadir Medicamentos, debe llenar todos los campos anteriores");
            }
        }

        public void HabilitarButtonCrearFactura()
        {
            btnAgregarFacturacion.Enabled = true;

        }

        private void btnBorrarCampos_Click(object sender, EventArgs e)
        {
            borrarCampos();
        }

        private void btnGetMonto_Click(object sender, EventArgs e)
        {
            tbxMontoTotal.Text = controller2.GetValorMontoTotal(facturaIdGenerada).ToString();

            if (tbxMontoTotal.Text != "0")
            {
                btnAgregarFacturacion.Enabled = true;
            }
            
        }

        private void AgregarFacturacionView_Load_1(object sender, EventArgs e)
        {
            CargarDatosComboBoxMedicos();
            CargarDatosComboBoxPacientes();
        }
    }
}
