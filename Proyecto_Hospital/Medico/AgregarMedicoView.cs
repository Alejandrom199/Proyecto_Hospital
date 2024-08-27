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
            tbxEmail.Text = string.Empty;
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

        private void btnAgregarMedico_Click(object sender, EventArgs e)
        {
            if (tbxNombre.Text != "" && tbxApellidos.Text != "" && tbxCedula.Text != "" && dtpFechaNacimiento.Text != "" && cbxEspecialidad.Text != "" && tbxNumeroLicencia.Text != "" && cbxSexo.Text != "" && tbxTelefono.Text != "" && tbxEmail.Text != "" && cbxHorario.Text != "" && cbxConsultorio.Text != "")
            {
                try
                {
                    string nombre = tbxNombre.Text;
                    string apellido = tbxApellidos.Text;
                    string cedula = tbxCedula.Text;
                    DateTime fecha_nacimiento = dtpFechaNacimiento.Value;
                    int especialidad_id = controller.ObtenerIdEspecialidadParaMedico(cbxEspecialidad.Text);
                    string numeroLicencia = tbxNumeroLicencia.Text;
                    string sexo = cbxSexo.Text;
                    string telefono = tbxTelefono.Text;
                    string email = tbxEmail.Text;

                    string[] partesHorario = cbxHorario.Text.Split(" - ");
                    TimeSpan parteHorario1 = TimeSpan.Parse(partesHorario[0]);
                    TimeSpan parteHorario2 = TimeSpan.Parse(partesHorario[1]);
                    int horario_id = controller.ObtenerIdHorarioParaMedico(parteHorario1, parteHorario2);

                    int consultorio_id = controller.ObtenerIdConsultorioParaMedico(cbxConsultorio.Text);


                    var resultado = controller.AgregarMedico(nombre,apellido,cedula,fecha_nacimiento,especialidad_id,numeroLicencia,sexo,telefono,email,horario_id,consultorio_id);

                    if (resultado)
                    {
                        MessageBox.Show("Registro de Médico creado con Éxito.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Rellene todos los datos del Médico");
            }
        }
    }
}
