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

namespace CapaPresentacion.Medico
{
    public partial class ConsultorioView : Form
    {
        ConsultorioController controller;
        private bool isNuevo;
        public ConsultorioView()
        {
            InitializeComponent();
            controller = new ConsultorioController();
            btnNuevo.Enabled = true;
            btnAgregar.Enabled = false;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            HabilitarCampos(false);
        }

        private void SetearCampos()
        {
            tbxId.Text = string.Empty;
            tbxNumero.Text = string.Empty;
            tbxNombre.Text = string.Empty;
            tbxPiso.Text = string.Empty;
        }

        private void HabilitarCampos(bool opcion)
        {
            tbxId.Enabled = opcion;
            tbxNumero.Enabled = opcion;
            tbxNombre.Enabled = opcion;
            tbxPiso.Enabled = opcion;
        }

        /**
         * Método para actualizar el DataGridView
         **/
        private void CargarGridConsultorio()
        {
            try
            {
                dgvConsultorio.AllowUserToAddRows = false;
                dgvConsultorio.DataSource = controller.GetListaConsultorios();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
                    int numero = Convert.ToInt32(tbxNumero.Text);
                    string nombre = tbxNombre.Text.ToUpper();
                    int piso = Convert.ToInt32(tbxPiso.Text);

                    //MessageBox.Show(numero_consultorio.ToString());

                    var resultado = controller.AgregarConsultorio(numero, nombre, piso);

                    if (resultado)
                    {
                        MessageBox.Show("Registro Creado con Éxito.");
                        CargarGridConsultorio();
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
                    MessageBox.Show("Rellene todos los datos "+ex.Message);
                }

            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (!isNuevo)
            {
                int id = Convert.ToInt32(tbxId.Text);
                int numero = Convert.ToInt32(tbxNumero.Text);
                string nombre = tbxNombre.Text;
                int piso = Convert.ToInt32(tbxPiso.Text);

                if (controller.ModificarConsultorio(id, numero, nombre, piso))
                {
                    MessageBox.Show("Consultorio actualizada!");
                    CargarGridConsultorio();
                    HabilitarCampos(false);

                    btnNuevo.Enabled = true;
                    btnAgregar.Enabled = false;
                    btnModificar.Enabled = false;
                    btnEliminar.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Consultorio no pudo ser actualizada!");
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(tbxId.Text);

            try
            {
                DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas eliminar el Consultorio?", "Eliminar Consultorio", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    if (controller.EliminarConsultorio(id))
                    {
                        MessageBox.Show("Consultorio eliminado!");
                        CargarGridConsultorio();

                        btnNuevo.Enabled = true;
                        btnAgregar.Enabled = false;
                        btnModificar.Enabled = false;
                        btnEliminar.Enabled = false;

                        HabilitarCampos(false);
                    }
                    else
                    {
                        MessageBox.Show("Consultorio no pudo ser eliminado!");
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

        private void ConsultorioView_Load(object sender, EventArgs e)
        {
            CargarGridConsultorio();
        }



        private void dgvConsultorio_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            HabilitarCampos(true);
            isNuevo = false;

            if (e.RowIndex != -1)
            {
                tbxId.Text = dgvConsultorio.Rows[e.RowIndex].Cells[0].Value.ToString();
                tbxNumero.Text = dgvConsultorio.Rows[e.RowIndex].Cells[1].Value.ToString();
                tbxNombre.Text = dgvConsultorio.Rows[e.RowIndex].Cells[2].Value.ToString();
                tbxPiso.Text = dgvConsultorio.Rows[e.RowIndex].Cells[3].Value.ToString();

                btnNuevo.Enabled = false;
                btnAgregar.Enabled = false;
                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
