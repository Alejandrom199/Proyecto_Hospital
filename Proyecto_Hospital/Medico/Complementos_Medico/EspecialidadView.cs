using CapaNegocio.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Medico
{
    public partial class EspecialidadView : Form
    {
        EspecialidadController controller;
        private bool isNuevo;
        public EspecialidadView()
        {
            InitializeComponent();
            controller = new EspecialidadController();
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
        private void CargarGridEspecialidad()
        {
            try
            {
                dgvEspecialidad.AllowUserToAddRows = false;
                dgvEspecialidad.DataSource = controller.GetListaEspecialidades();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EspecialidadView_Load(object sender, EventArgs e)
        {
            CargarGridEspecialidad();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Dispose();
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

                    var resultado = controller.AgregarEspecializacion(nombre);

                    if (resultado)
                    {
                        MessageBox.Show("Registro Creado con Éxito.");
                        CargarGridEspecialidad();
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
                    MessageBox.Show("Rellene todos los datos");
                }

            }
        }

        private void dgvEspecialidad_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            HabilitarCampos(true);
            isNuevo = false;

            if (e.RowIndex != -1)
            {
                tbxId.Text = dgvEspecialidad.Rows[e.RowIndex].Cells[0].Value.ToString();
                tbxNombre.Text = dgvEspecialidad.Rows[e.RowIndex].Cells[1].Value.ToString();

                btnNuevo.Enabled = false;
                btnAgregar.Enabled = false;
                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (!isNuevo)
            {
                int id = Convert.ToInt32(tbxId.Text);
                string nombre = tbxNombre.Text;

                if (controller.ModificarEspecialidad(id, nombre))
                {
                    MessageBox.Show("Especialidad actualizada!");
                    CargarGridEspecialidad();
                    HabilitarCampos(false);

                    btnNuevo.Enabled = true;
                    btnAgregar.Enabled = false;
                    btnModificar.Enabled = false;
                    btnEliminar.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Especialidad no pudo ser actualizada!");
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(tbxId.Text);

            try
            {
                DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas eliminar la Especialidad?", "Eliminar Especialidad", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    if (controller.EliminarEspecialidad(id))
                    {
                        MessageBox.Show("Especialidad eliminada!");
                        CargarGridEspecialidad();

                        btnNuevo.Enabled = true;
                        btnAgregar.Enabled = false;
                        btnModificar.Enabled = false;
                        btnEliminar.Enabled = false;

                        HabilitarCampos(false);
                    }
                    else
                    {
                        MessageBox.Show("Especialidad no pudo ser eliminada!");
                    }
                }
                else if (resultado == DialogResult.No)
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar");
            }
        }
    }
}
