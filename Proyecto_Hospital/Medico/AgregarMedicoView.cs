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
    public partial class AgregarMedicoView : Form
    {
        MedicoController controller;
        public AgregarMedicoView()
        {
            InitializeComponent();
            controller = new MedicoController();
        }

        private void setearCampos()
        {
            tbxNombre.Text = string.Empty;
            tbxApellidos.Text = string.Empty;
            tbxCedula.Text = string.Empty;
            cbxEspecialidad.Text = string.Empty;
            tbxNumeroLicencia.Text = string.Empty;
            cbxSexo.Text = string.Empty;
            tbxTelefono.Text = string.Empty;
            tbxEmail.Text = string .Empty;
            cbxHorario.Text = string.Empty;
            cbxConsultorio.Text = string.Empty;
        }

        private void btnConsultorio_Click(object sender, EventArgs e)
        {
            new ConsultorioView().Show();
        }

        private void btnHorario_Click_1(object sender, EventArgs e)
        {
            new HorarioView().Show();
        }

        private void btnEspecialidad_Click_1(object sender, EventArgs e)
        {
            new EspecialidadView().Show();
        }

        private void CargarDatosComboBoxEspecialidades()
        {
            Dictionary<int, string> especialidades = controller.ObtenerEspecialidadesParaMedico();

            foreach (KeyValuePair<int, string> especialidad in especialidades)
            {
                cbxEspecialidad.Items.Add(especialidad.Value);
            }

        }

        private void CargarDatosComboBoxConsultorios()
        {
            Dictionary<int, string> consultorios = controller.ObtenerConsultoriosParaMedico();

            foreach (KeyValuePair<int, string> consultario in consultorios)
            {
                cbxConsultorio.Items.Add(consultario.Value);
            }
        }

        private void CargarDatosComboBoxHorarios()
        {
            Dictionary<int, string> horarios = controller.ObtenerHorariosParaMedico();

            foreach (KeyValuePair<int, string> horario in horarios)
            {
                cbxHorario.Items.Add(horario.Value);
            }
        }

        private void AgregarMedicoView_Load(object sender, EventArgs e)
        {
            CargarDatosComboBoxEspecialidades();
            CargarDatosComboBoxConsultorios();
            CargarDatosComboBoxHorarios();
        }

        private void btnBorrarCampos_Click(object sender, EventArgs e)
        {
            setearCampos();
        }
    }
}
