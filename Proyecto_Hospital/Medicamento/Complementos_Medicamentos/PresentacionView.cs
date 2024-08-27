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

namespace CapaPresentacion.Medicamento.Complementos_Medicamentos
{
    public partial class PresentacionView : Form
    {
        PresentacionController controller;
        private bool isNuevo;
        public PresentacionView()
        {
            InitializeComponent();
            controller = new PresentacionController();
            btnNuevo.Enabled = true;
            btnAgregar.Enabled = false;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            HabilitarCampos(false);
        }
        private void SetearCampos()
        {
            tbxId.Text = string.Empty;
            tbxNombre.Text = string.Empty;
        }

        private void HabilitarCampos(bool opcion)
        {
            tbxId.Enabled = opcion;
            tbxNombre.Enabled = opcion;
        }

        /**
         * Método para actualizar el DataGridView
         **/
        private void CargarGridPresentacion()
        {
            try
            {
                dgvPresentacion.AllowUserToAddRows = false;
                dgvPresentacion.DataSource = controller.GetListaPresentaciones();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void PresentacionView_Load(object sender, EventArgs e)
        {
            CargarGridPresentacion();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            isNuevo = true;
            SetearCampos();

            btnNuevo.Enabled = false;
            btnAgregar.Enabled = true;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;

            HabilitarCampos(true);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (isNuevo)
            {
                try
                {
                    string nombre = tbxNombre.Text.ToUpper();


                    var resultado = controller.AgregarPresentacion(nombre);

                    if (resultado)
                    {
                        MessageBox.Show("Registro Creado con Éxito.");
                        CargarGridPresentacion();
                        HabilitarCampos(false);

                        btnNuevo.Enabled = true;
                        btnAgregar.Enabled = false;
                        btnModificar.Enabled = false;
                        btnEliminar.Enabled = false;
                    }
                    else { }

                    isNuevo = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Rellene todos los datos " + ex.Message);
                }

            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (!isNuevo)
            {
                int id = Convert.ToInt32(tbxId.Text);
                string nombre = tbxNombre.Text;

                if (controller.ModificarPresentacion(id, nombre))
                {
                    MessageBox.Show("Presentacion actualizada!");
                    CargarGridPresentacion();
                    HabilitarCampos(false);

                    btnNuevo.Enabled = true;
                    btnAgregar.Enabled = false;
                    btnModificar.Enabled = false;
                    btnEliminar.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Presentacion no pudo ser actualizada!");
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(tbxId.Text);

            try
            {
                DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas eliminar la Presentacion?", "Eliminar Presentacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    if (controller.EliminarPresentacion(id))
                    {
                        MessageBox.Show("Presentacion eliminado!");
                        CargarGridPresentacion();

                        btnNuevo.Enabled = true;
                        btnAgregar.Enabled = false;
                        btnModificar.Enabled = false;
                        btnEliminar.Enabled = false;

                        HabilitarCampos(false);
                    }
                    else
                    {
                        MessageBox.Show("Presentacion no pudo ser eliminado!");
                    }
                }
                else if (resultado == DialogResult.No)
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
        }

        private void dgvPresentacion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            HabilitarCampos(true);
            isNuevo = false;

            if (e.RowIndex != -1)
            {
                tbxId.Text = dgvPresentacion.Rows[e.RowIndex].Cells[0].Value.ToString();
                tbxNombre.Text = dgvPresentacion.Rows[e.RowIndex].Cells[1].Value.ToString();

                btnNuevo.Enabled = false;
                btnAgregar.Enabled = false;
                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;
            }
        }
    }
}
