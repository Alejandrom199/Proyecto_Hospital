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

namespace CapaPresentacion.Medico.Complementos_Medico
{
    public partial class ModificarMedicoView : Form
    {
        private MedicoController controller;
        private bool estaEncontrado = false;
        public ModificarMedicoView()
        {
            InitializeComponent();
            controller = new MedicoController();
        }

        private void habilitarCampos(bool opcion)
        {
            tbxNombre.Enabled = opcion;
            tbxApellidos.Enabled = opcion;
            tbxCedula.Enabled = opcion;
            dtpFechaNacimiento.Enabled = opcion;
            cbxEspecialidad.Enabled = opcion;
            tbxNumeroLicencia.Enabled = opcion;
            cbxSexo.Enabled = opcion;
            tbxTelefono.Enabled = opcion;
            tbxEmail.Enabled = opcion;
            cbxHorario.Enabled = opcion;
            cbxConsultorio.Enabled = opcion;
            btnModificarMedico.Enabled = opcion;
            btnBorrarCampos.Enabled = opcion;
        }

        private void setearCampos()
        {
            tbxNombre.Text = string.Empty;
            tbxApellidos.Text = string.Empty;
            tbxCedula.Text = string.Empty;
            dtpFechaNacimiento.Value = DateTime.Now;
            cbxEspecialidad.Text = string.Empty;
            tbxNumeroLicencia.Text = string.Empty;
            cbxSexo.Text = string.Empty;
            tbxTelefono.Text = string.Empty;
            tbxEmail.Text = string.Empty;
            cbxHorario.Text = string.Empty;
            cbxConsultorio.Text = string.Empty;
        }
        private void ModificarMedicoView_Load(object sender, EventArgs e)
        {
            habilitarCampos(false);
            CargarDatosComboBoxConsultorios();
            CargarDatosComboBoxEspecialidades();
            CargarDatosComboBoxHorarios();
        }

        private void btnModificarMedico_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(tbxId.Text);
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


                var resultado = controller.ModificarMedico(id, nombre, apellido, cedula, fecha_nacimiento, especialidad_id, numeroLicencia, sexo, telefono, email, horario_id, consultorio_id);

                if (resultado)
                {
                    MessageBox.Show("Modificación de Médico realizada con Éxito.");
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            if (!tbxId.Text.Equals(""))
            {
                int idMedico = Convert.ToInt32(tbxId.Text);
                Dictionary<string, object> medicoInfo = controller.GetMedicoPorId(idMedico);
                try
                {

                    tbxNombre.Text = medicoInfo["Nombre"].ToString();
                    tbxApellidos.Text = medicoInfo["Apellido"].ToString();
                    tbxCedula.Text = medicoInfo["Cedula"].ToString();
                    dtpFechaNacimiento.Value = Convert.ToDateTime(medicoInfo["FechaNacimiento"]);
                    //idEspecialidad = Convert.ToInt32(medicoInfo["EspecialidadId"].ToString()); //Me recibe un numero

                    cbxEspecialidad.Text = controller.ObtenerNombreEspecialidadMedianteIdMedico(idMedico);
                    tbxNumeroLicencia.Text = medicoInfo["NumeroLicencia"].ToString();
                    cbxSexo.Text = medicoInfo["Sexo"].ToString();
                    tbxTelefono.Text = medicoInfo["Telefono"].ToString();
                    tbxEmail.Text = medicoInfo["Email"].ToString();
                    cbxHorario.Text = controller.ObtenerHorarioMedianteIdMedico(idMedico);
                    cbxConsultorio.Text = controller.ObtenerNombreConsultorioMedianteIdMedico(idMedico);

                    habilitarCampos(true);
                    estaEncontrado = true;
                    tbxId.ReadOnly = true;
                    btnBuscar.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ID no registrado como Paciente");
                    setearCampos();
                    habilitarCampos(false);
                    estaEncontrado = false;
                }
            }
        }
    }
}
