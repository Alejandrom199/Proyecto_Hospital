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
    public partial class HorarioView : Form
    {
        HorarioController controller;
        private bool isNuevo;
        public HorarioView()
        {
            InitializeComponent();
            controller = new HorarioController();
        }
        private void SetearCampos()
        {
            tbxId.Text = string.Empty;
            tbxHoraInicio.Text = string.Empty;
            tbxHoraFin.Text = string.Empty;
            tbxFechaInicio.Text = string.Empty;
            tbxFechaFin.Text = string.Empty;
        }

        private void HabilitarCampos(bool opcion)
        {
            tbxId.Enabled = opcion;
            tbxHoraInicio.Enabled = opcion;
            tbxHoraFin.Enabled = opcion;
            tbxFechaInicio.Enabled = opcion;
            tbxFechaFin.Enabled = opcion;
        }

        /**
         * Método para actualizar el DataGridView
         **/
        private void CargarGridHorario()
        {
            try
            {
                dgvEspecialidad.AllowUserToAddRows = false;
                dgvEspecialidad.DataSource = controller.GetListaHorarios();
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
                    TimeSpan horaInicio = TimeSpan.Parse(tbxHoraInicio.Text);
                    TimeSpan horaFin = TimeSpan.Parse(tbxHoraFin.Text);
                    string diaInicio = tbxFechaInicio.Text;
                    string diaFin = tbxFechaFin.Text;

                    var resultado = controller.AgregarHorario(horaInicio, horaFin, diaInicio, diaFin);

                    if (resultado)
                    {
                        MessageBox.Show("Registro Creado con Éxito.");
                        CargarGridHorario();
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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (!isNuevo)
            {
                try
                {
                    int id = Convert.ToInt32(tbxId.Text);
                    TimeSpan horaInicio = TimeSpan.Parse(tbxHoraInicio.Text);
                    TimeSpan horaFin = TimeSpan.Parse(tbxHoraFin.Text);
                    string diaInicio = tbxFechaInicio.Text;
                    string diaFin = tbxFechaFin.Text;

                    if (controller.ModificarHorario(id, horaInicio, horaFin, diaInicio, diaFin))
                    {
                        MessageBox.Show("Especialidad actualizada!");
                        CargarGridHorario();
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
                catch (Exception ex)
                {
                    MessageBox.Show("Formato de Hora no válido, usar formato '00:00'.");
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(tbxId.Text);

            try
            {
                DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas eliminar el Horario?", "Eliminar Horario", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    if (controller.EliminarHorario(id))
                    {
                        MessageBox.Show("Horario eliminada!");
                        CargarGridHorario();

                        btnNuevo.Enabled = true;
                        btnAgregar.Enabled = false;
                        btnModificar.Enabled = false;
                        btnEliminar.Enabled = false;

                        HabilitarCampos(false);
                    }
                    else
                    {
                        MessageBox.Show("Horario no pudo ser eliminada!");
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void HorarioView_Load(object sender, EventArgs e)
        {
            CargarGridHorario();
        }

        private void dgvEspecialidad_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            HabilitarCampos(true);
            isNuevo = false;

            if (e.RowIndex != -1)
            {
                tbxId.Text = dgvEspecialidad.Rows[e.RowIndex].Cells[0].Value.ToString();
                tbxHoraInicio.Text = dgvEspecialidad.Rows[e.RowIndex].Cells[1].Value.ToString();
                tbxHoraFin.Text = dgvEspecialidad.Rows[e.RowIndex].Cells[2].Value.ToString();
                tbxFechaInicio.Text = dgvEspecialidad.Rows[e.RowIndex].Cells[3].Value.ToString();
                tbxFechaFin.Text = dgvEspecialidad.Rows[e.RowIndex].Cells[4].Value.ToString();

                btnNuevo.Enabled = false;
                btnAgregar.Enabled = false;
                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;
            }
        }
    }
}
