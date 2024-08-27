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
    public partial class ProveedorView : Form
    {
        ProveedorController controller;
        private bool isNuevo;
        public ProveedorView()
        {
            InitializeComponent();
            controller = new ProveedorController();
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
            tbxTelefono.Text = string.Empty;
            tbxDireccion.Text = string.Empty;
            tbxEmail.Text = string.Empty;
            tbxNombreContacto.Text = string.Empty;
        }

        private void HabilitarCampos(bool opcion)
        {
            tbxId.Enabled = opcion;
            tbxNombre.Enabled = opcion;
            tbxTelefono.Enabled = opcion;
            tbxDireccion.Enabled = opcion;
            tbxEmail.Enabled = opcion;
            tbxNombreContacto.Enabled = opcion;
        }

        /**
         * Método para actualizar el DataGridView
         **/
        private void CargarGridProveedor()
        {
            try
            {
                dgvProveedor.AllowUserToAddRows = false;
                dgvProveedor.DataSource = controller.GetListaProveedores();
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
                    string direccion = tbxDireccion.Text;
                    string telefono = tbxTelefono.Text;
                    string email = tbxEmail.Text;
                    string nombre_contacto = tbxNombreContacto.Text;

                    //MessageBox.Show(numero_consultorio.ToString());

                    var resultado = controller.AgregarProveedor(nombre, direccion, telefono, email, nombre_contacto);

                    if (resultado)
                    {
                        MessageBox.Show("Registro Creado con Éxito.");
                        CargarGridProveedor();
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
                string nombre = tbxNombre.Text.ToUpper();
                string direccion = tbxDireccion.Text;
                string telefono = tbxTelefono.Text;
                string email = tbxEmail.Text;
                string nombre_contacto = tbxNombreContacto.Text;

                if (controller.ModificarProveedor(id, nombre, direccion, telefono, email, nombre_contacto))
                {
                    MessageBox.Show("Proveedor actualizada!");
                    CargarGridProveedor();
                    HabilitarCampos(false);

                    btnNuevo.Enabled = true;
                    btnAgregar.Enabled = false;
                    btnModificar.Enabled = false;
                    btnEliminar.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Proveedor no pudo ser actualizada!");
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(tbxId.Text);

            try
            {
                DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas eliminar el Proveedor?", "Eliminar Proveedor", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    if (controller.EliminarProveedor(id))
                    {
                        MessageBox.Show("Consultorio eliminado!");
                        CargarGridProveedor();

                        btnNuevo.Enabled = true;
                        btnAgregar.Enabled = false;
                        btnModificar.Enabled = false;
                        btnEliminar.Enabled = false;

                        HabilitarCampos(false);
                    }
                    else
                    {
                        MessageBox.Show("Proveedor no pudo ser eliminado!");
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

        private void dgvProveedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            HabilitarCampos(true);
            isNuevo = false;

            if (e.RowIndex != -1)
            {
                tbxId.Text = dgvProveedor.Rows[e.RowIndex].Cells[0].Value.ToString();
                tbxNombre.Text = dgvProveedor.Rows[e.RowIndex].Cells[1].Value.ToString();
                tbxDireccion.Text = dgvProveedor.Rows[e.RowIndex].Cells[2].Value.ToString();
                tbxTelefono.Text = dgvProveedor.Rows[e.RowIndex].Cells[3].Value.ToString();
                tbxEmail.Text = dgvProveedor.Rows[e.RowIndex].Cells[4].Value.ToString();
                tbxNombreContacto.Text = dgvProveedor.Rows[e.RowIndex].Cells[5].Value.ToString();

                btnNuevo.Enabled = false;
                btnAgregar.Enabled = false;
                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;
            }
        }

        private void ProveedorView_Load(object sender, EventArgs e)
        {
            CargarGridProveedor();
        }
    }
}
