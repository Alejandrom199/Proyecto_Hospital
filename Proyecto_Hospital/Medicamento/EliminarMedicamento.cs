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
    public partial class EliminarMedicamento : Form
    {
        private MedicamentoController controller;
        private bool estaEncontrado = false;
        public EliminarMedicamento()
        {
            InitializeComponent();
            controller = new MedicamentoController();

            btnEliminarMedicamento.Enabled = false;
            habilitarCampos(false);
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

        private void btnEliminarMedicamento_Click(object sender, EventArgs e)
        {
            if (estaEncontrado)
            {
                int id = Int32.Parse(tbxId.Text);

                try
                {
                    DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas eliminar el Medicamento?", "Eliminar Medicamento", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resultado == DialogResult.Yes)
                    {
                        if (controller.EliminarMedicamento(id))
                        {
                            MessageBox.Show("Eliminación de Medicamento realizada con Éxito.");
                        }
                        else
                        {
                            MessageBox.Show("Registro no pudo ser eliminado!");
                        }
                    }
                    else if (resultado == DialogResult.No)
                    {

                    }


                }
                catch (Exception ex) { }
            }
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

                    btnEliminarMedicamento.Enabled = true;
                    estaEncontrado = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ID no registrado como Medicamento");
                    estaEncontrado = false;
                    btnEliminarMedicamento.Enabled = false;
                }
            }
        }
    }
}
