using CapaPresentacion.Medico;
using CapaPresentacion.Medico.Complementos_Medico;
using CapaPresentacion.Paciente;
using CapaPresentacion.Medicamento;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class MenuView : Form
    {
        // Variables para almacenar la posición del ratón
        private bool arrastrando = false;
        private Point posicionOriginal;
        private const int Margen = 500;
        public MenuView()
        {
            InitializeComponent();
        }

        private void MostrarFormEnPanel(Form formHijo)
        {
            // Cerrar cualquier formulario previamente cargado
            if (pnlViews.Controls.Count > 0)
                pnlViews.Controls.RemoveAt(0);

            formHijo.TopLevel = false; // No debe ser un formulario de nivel superior
            formHijo.FormBorderStyle = FormBorderStyle.None; // Sin bordes
            formHijo.Dock = DockStyle.Fill; // Ajustar al tamaño del panel
            pnlViews.Controls.Add(formHijo); // Agregar al panel
            pnlViews.Tag = formHijo;
            formHijo.Show();
        }

        private void QuitarBotonesSubMenu(string entidad)
        {
            flpMenu.Controls.RemoveByKey("btnAgregar" + entidad);
            flpMenu.Controls.RemoveByKey("btnEliminar" + entidad);
            flpMenu.Controls.RemoveByKey("btnListar" + entidad);
            flpMenu.Controls.RemoveByKey("btnModificar" + entidad);
        }

        /**
         * Botones Principales
         */
        Button btnAgregarPaciente = new Button();
        Button btnEliminarPaciente = new Button();
        Button btnListarPaciente = new Button();
        Button btnModificarPaciente = new Button();

        Button btnAgregarMedico = new Button();
        Button btnEliminarMedico = new Button();
        Button btnListarMedico = new Button();
        Button btnModificarMedico = new Button();

        Button btnAgregarMedicamentos = new Button();
        Button btnEliminarMedicamentos = new Button();
        Button btnListarMedicamentos = new Button();
        Button btnModificarMedicamentos = new Button();

        Button btnAgregarFacturacion = new Button();
        Button btnEliminarFacturacion = new Button();
        Button btnListarFacturacion = new Button();
        Button btnModificarFacturacion = new Button();


        private void btnPacientes_Click(object sender, EventArgs e)
        {
            // Busca la posición del botón "Paciente" en el FlowLayoutPanel
            int pacienteIndex = flpMenu.Controls.IndexOf((Button)sender);

            // Verifica si los botones ya han sido agregados
            if (flpMenu.Controls.ContainsKey("btnAgregarPaciente"))
            {
                // Eliminar los botones si ya existen
                QuitarBotonesSubMenu("Paciente");
            }
            else
            {
                // Crear y agregar los botones si no existen
                btnAgregarPaciente.Name = "btnAgregarPaciente";
                btnAgregarPaciente.Text = "Agregar Paciente";
                btnAgregarPaciente.Width = 236;
                btnAgregarPaciente.Height = 50;
                btnAgregarPaciente.BackColor = Color.LightSkyBlue; //LightSkyBlue
                btnAgregarPaciente.FlatStyle = FlatStyle.Flat;
                btnAgregarPaciente.ForeColor = SystemColors.HotTrack;
                btnAgregarPaciente.Click += btnAgregarPaciente_Click;

                btnListarPaciente.Name = "btnListarPaciente";
                btnListarPaciente.Text = "Listar Paciente";
                btnListarPaciente.Width = 236;
                btnListarPaciente.Height = 50;
                btnListarPaciente.BackColor = Color.LightSkyBlue;
                btnListarPaciente.FlatStyle = FlatStyle.Flat;
                btnListarPaciente.ForeColor = SystemColors.HotTrack;
                btnListarPaciente.Click += btnListarPaciente_Click;

                btnModificarPaciente.Name = "btnModificarPaciente";
                btnModificarPaciente.Text = "Modificar Paciente";
                btnModificarPaciente.Width = 236;
                btnModificarPaciente.Height = 50;
                btnModificarPaciente.BackColor = Color.LightSkyBlue;
                btnModificarPaciente.FlatStyle = FlatStyle.Flat;
                btnModificarPaciente.ForeColor = SystemColors.HotTrack;
                btnModificarPaciente.Click += btnModificarPaciente_Click;

                btnEliminarPaciente.Name = "btnEliminarPaciente";
                btnEliminarPaciente.Text = "Eliminar Paciente";
                btnEliminarPaciente.Width = 236;
                btnEliminarPaciente.Height = 50;
                btnEliminarPaciente.BackColor = Color.LightSkyBlue;
                btnEliminarPaciente.FlatStyle = FlatStyle.Flat;
                btnEliminarPaciente.ForeColor = SystemColors.HotTrack;
                btnEliminarPaciente.Click += btnEliminarPaciente_Click;


                flpMenu.Controls.Add(btnAgregarPaciente);
                flpMenu.Controls.SetChildIndex(btnAgregarPaciente, pacienteIndex + 1);

                flpMenu.Controls.Add(btnListarPaciente);
                flpMenu.Controls.SetChildIndex(btnListarPaciente, pacienteIndex + 2);

                flpMenu.Controls.Add(btnModificarPaciente);
                flpMenu.Controls.SetChildIndex(btnModificarPaciente, pacienteIndex + 3);

                flpMenu.Controls.Add(btnEliminarPaciente);
                flpMenu.Controls.SetChildIndex(btnEliminarPaciente, pacienteIndex + 4);

                QuitarBotonesSubMenu("Medico");
                QuitarBotonesSubMenu("Medicamentos");
                QuitarBotonesSubMenu("Facturacion");
            }
        }

        private void btnAgregarPaciente_Click(object sender, EventArgs e)
        {
            MostrarFormEnPanel(new AgregarPacienteView());
        }

        private void btnEliminarPaciente_Click(object sender, EventArgs e)
        {
            MostrarFormEnPanel(new EliminarPacienteView());
        }

        private void btnListarPaciente_Click(object sender, EventArgs e)
        {
            MostrarFormEnPanel(new ListarPacienteView());
        }

        private void btnModificarPaciente_Click(object sender, EventArgs e)
        {
            MostrarFormEnPanel(new ModificarPacienteView());
        }

        /**
         * Botones para Medico
         */
        private void btnMedicos_Click(object sender, EventArgs e)
        {
            int medicoIndex = flpMenu.Controls.IndexOf((Button)sender);

            if (flpMenu.Controls.ContainsKey("btnAgregarMedico"))
            {
                QuitarBotonesSubMenu("Medico");
            }
            else
            {

                btnAgregarMedico.Name = "btnAgregarMedico";
                btnAgregarMedico.Text = "Agregar Medico";
                btnAgregarMedico.Width = 236;
                btnAgregarMedico.Height = 50;
                btnAgregarMedico.BackColor = Color.LightSkyBlue;
                btnAgregarMedico.FlatStyle = FlatStyle.Flat;
                btnAgregarMedico.ForeColor = SystemColors.HotTrack;
                btnAgregarMedico.Click += btnAgregarMedico_Click;


                btnEliminarMedico.Name = "btnEliminarMedico";
                btnEliminarMedico.Text = "Eliminar Medico";
                btnEliminarMedico.Width = 236;
                btnEliminarMedico.Height = 50;
                btnEliminarMedico.BackColor = Color.LightSkyBlue;
                btnEliminarMedico.FlatStyle = FlatStyle.Flat;
                btnEliminarMedico.ForeColor = SystemColors.HotTrack;
                btnEliminarMedico.Click += btnEliminarMedico_Click;


                btnListarMedico.Name = "btnListarMedico";
                btnListarMedico.Text = "Listar Medico";
                btnListarMedico.Width = 236;
                btnListarMedico.Height = 50;
                btnListarMedico.BackColor = Color.LightSkyBlue;
                btnListarMedico.FlatStyle = FlatStyle.Flat;
                btnListarMedico.ForeColor = SystemColors.HotTrack;
                btnListarMedico.Click += btnListarMedico_Click;


                btnModificarMedico.Name = "btnModificarMedico";
                btnModificarMedico.Text = "Modificar Medico";
                btnModificarMedico.Width = 236;
                btnModificarMedico.Height = 50;
                btnModificarMedico.BackColor = Color.LightSkyBlue;
                btnModificarMedico.FlatStyle = FlatStyle.Flat;
                btnModificarMedico.ForeColor = SystemColors.HotTrack;
                btnModificarMedico.Click += btnModificarMedico_Click;

                flpMenu.Controls.Add(btnAgregarMedico);
                flpMenu.Controls.SetChildIndex(btnAgregarMedico, medicoIndex + 1);

                flpMenu.Controls.Add(btnListarMedico);
                flpMenu.Controls.SetChildIndex(btnListarMedico, medicoIndex + 2);

                flpMenu.Controls.Add(btnModificarMedico);
                flpMenu.Controls.SetChildIndex(btnModificarMedico, medicoIndex + 3);

                flpMenu.Controls.Add(btnEliminarMedico);
                flpMenu.Controls.SetChildIndex(btnEliminarMedico, medicoIndex + 4);

                QuitarBotonesSubMenu("Paciente");
                QuitarBotonesSubMenu("Medicamentos");
                QuitarBotonesSubMenu("Facturacion");
            }
        }

        private void btnAgregarMedico_Click(object sender, EventArgs e)
        {
            MostrarFormEnPanel(new AgregarMedicoView());
        }

        private void btnEliminarMedico_Click(object sender, EventArgs e)
        {
            MostrarFormEnPanel(new EliminarMedicoView());
        }

        private void btnListarMedico_Click(object sender, EventArgs e)
        {
            MostrarFormEnPanel(new ListarMedicoView());
        }

        private void btnModificarMedico_Click(object sender, EventArgs e)
        {
            MostrarFormEnPanel(new ModificarMedicoView());
        }


        private void btnMedicamentos_Click(object sender, EventArgs e)
        {
            int medicamentosIndex = flpMenu.Controls.IndexOf((Button)sender);

            if (flpMenu.Controls.ContainsKey("btnAgregarMedicamentos"))
            {
                QuitarBotonesSubMenu("Medicamentos");
            }
            else
            {

                btnAgregarMedicamentos.Name = "btnAgregarMedicamentos";
                btnAgregarMedicamentos.Text = "Agregar Medicamentos";
                btnAgregarMedicamentos.Width = 236;
                btnAgregarMedicamentos.Height = 50;
                btnAgregarMedicamentos.BackColor = Color.LightSkyBlue;
                btnAgregarMedicamentos.FlatStyle = FlatStyle.Flat;
                btnAgregarMedicamentos.ForeColor = SystemColors.HotTrack;
                btnAgregarMedicamentos.Click += btnAgregarMedicamentos_Click;


                btnEliminarMedicamentos.Name = "btnEliminarMedicamentos";
                btnEliminarMedicamentos.Text = "Eliminar Medicamentos";
                btnEliminarMedicamentos.Width = 236;
                btnEliminarMedicamentos.Height = 50;
                btnEliminarMedicamentos.BackColor = Color.LightSkyBlue;
                btnEliminarMedicamentos.FlatStyle = FlatStyle.Flat;
                btnEliminarMedicamentos.ForeColor = SystemColors.HotTrack;
                btnEliminarMedicamentos.Click += btnEliminarMedicamentos_Click;


                btnListarMedicamentos.Name = "btnListarMedicamentos";
                btnListarMedicamentos.Text = "Listar Medicamentos";
                btnListarMedicamentos.Width = 236;
                btnListarMedicamentos.Height = 50;
                btnListarMedicamentos.BackColor = Color.LightSkyBlue;
                btnListarMedicamentos.FlatStyle = FlatStyle.Flat;
                btnListarMedicamentos.ForeColor = SystemColors.HotTrack;
                btnListarMedicamentos.Click += btnListarMedicamentos_Click;


                btnModificarMedicamentos.Name = "btnModificarMedicamentos";
                btnModificarMedicamentos.Text = "Modificar Medicamentos";
                btnModificarMedicamentos.Width = 236;
                btnModificarMedicamentos.Height = 50;
                btnModificarMedicamentos.BackColor = Color.LightSkyBlue;
                btnModificarMedicamentos.FlatStyle = FlatStyle.Flat;
                btnModificarMedicamentos.ForeColor = SystemColors.HotTrack;
                btnModificarMedicamentos.Click += btnModificarMedicamentos_Click;

                flpMenu.Controls.Add(btnAgregarMedicamentos);
                flpMenu.Controls.SetChildIndex(btnAgregarMedicamentos, medicamentosIndex + 1);

                flpMenu.Controls.Add(btnListarMedicamentos);
                flpMenu.Controls.SetChildIndex(btnListarMedicamentos, medicamentosIndex + 2);

                flpMenu.Controls.Add(btnModificarMedicamentos);
                flpMenu.Controls.SetChildIndex(btnModificarMedicamentos, medicamentosIndex + 3);

                flpMenu.Controls.Add(btnEliminarMedicamentos);
                flpMenu.Controls.SetChildIndex(btnEliminarMedicamentos, medicamentosIndex + 4);

                QuitarBotonesSubMenu("Paciente");
                QuitarBotonesSubMenu("Medico");
                QuitarBotonesSubMenu("Facturacion");
            }
        }

        private void btnAgregarMedicamentos_Click(object sender, EventArgs e)
        {
            MostrarFormEnPanel(new AgregarMedicamento());
        }

        private void btnEliminarMedicamentos_Click(object sender, EventArgs e)
        {
        }

        private void btnListarMedicamentos_Click(object sender, EventArgs e)
        {
            MostrarFormEnPanel(new ListarMedicamentoView());
        }

        private void btnModificarMedicamentos_Click(object sender, EventArgs e)
        {
        }

        private void btnFacturacion_Click(object sender, EventArgs e)
        {
            int facturacionIndex = flpMenu.Controls.IndexOf((Button)sender);

            if (flpMenu.Controls.ContainsKey("btnAgregarFacturacion"))
            {
                QuitarBotonesSubMenu("Facturacion");
            }
            else
            {

                btnAgregarFacturacion.Name = "btnAgregarFacturacion";
                btnAgregarFacturacion.Text = "Agregar Facturacion";
                btnAgregarFacturacion.Width = 236;
                btnAgregarFacturacion.Height = 50;
                btnAgregarFacturacion.BackColor = Color.LightSkyBlue;
                btnAgregarFacturacion.FlatStyle = FlatStyle.Flat;
                btnAgregarFacturacion.ForeColor = SystemColors.HotTrack;
                btnAgregarFacturacion.Click += btnAgregarFacturacion_Click;


                btnEliminarFacturacion.Name = "btnEliminarFacturacion";
                btnEliminarFacturacion.Text = "Eliminar Facturacion";
                btnEliminarFacturacion.Width = 236;
                btnEliminarFacturacion.Height = 50;
                btnEliminarFacturacion.BackColor = Color.LightSkyBlue;
                btnEliminarFacturacion.FlatStyle = FlatStyle.Flat;
                btnEliminarFacturacion.ForeColor = SystemColors.HotTrack;
                btnEliminarFacturacion.Click += btnEliminarFacturacion_Click;


                btnListarFacturacion.Name = "btnListarFacturacion";
                btnListarFacturacion.Text = "Listar Facturacion";
                btnListarFacturacion.Width = 236;
                btnListarFacturacion.Height = 50;
                btnListarFacturacion.BackColor = Color.LightSkyBlue;
                btnListarFacturacion.FlatStyle = FlatStyle.Flat;
                btnListarFacturacion.ForeColor = SystemColors.HotTrack;
                btnListarFacturacion.Click += btnListarFacturacion_Click;


                btnModificarFacturacion.Name = "btnModificarFacturacion";
                btnModificarFacturacion.Text = "Modificar Facturacion";
                btnModificarFacturacion.Width = 236;
                btnModificarFacturacion.Height = 50;
                btnModificarFacturacion.BackColor = Color.LightSkyBlue;
                btnModificarFacturacion.FlatStyle = FlatStyle.Flat;
                btnModificarFacturacion.ForeColor = SystemColors.HotTrack;
                btnModificarFacturacion.Click += btnModificarFacturacion_Click;

                flpMenu.Controls.Add(btnAgregarFacturacion);
                flpMenu.Controls.SetChildIndex(btnAgregarFacturacion, facturacionIndex + 1);

                flpMenu.Controls.Add(btnListarFacturacion);
                flpMenu.Controls.SetChildIndex(btnListarFacturacion, facturacionIndex + 2);

                flpMenu.Controls.Add(btnModificarFacturacion);
                flpMenu.Controls.SetChildIndex(btnModificarFacturacion, facturacionIndex + 3);

                flpMenu.Controls.Add(btnEliminarFacturacion);
                flpMenu.Controls.SetChildIndex(btnEliminarFacturacion, facturacionIndex + 4);

                QuitarBotonesSubMenu("Paciente");
                QuitarBotonesSubMenu("Medico");
                QuitarBotonesSubMenu("Medicamentos");
            }
        }

        private void btnAgregarFacturacion_Click(object sender, EventArgs e)
        {
        }

        private void btnEliminarFacturacion_Click(object sender, EventArgs e)
        {
        }

        private void btnListarFacturacion_Click(object sender, EventArgs e)
        {
            FacturacionView facturacionView = new FacturacionView();
            MostrarFormEnPanel(facturacionView);
        }

        private void btnModificarFacturacion_Click(object sender, EventArgs e)
        {
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas cerrar el sistema?", "Cerrar sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (resultado == DialogResult.No)
            {

            }
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pnlBar_MouseDown(object sender, MouseEventArgs e)
        {
            // Iniciar el movimiento si se hace clic en el panel
            if (e.Button == MouseButtons.Left)
            {
                arrastrando = true;
                // Guarda la posición original del ratón
                posicionOriginal = e.Location;
            }
        }

        private void pnlBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (arrastrando)
            {
                // Obtenemos el tamaño del escritorio
                Rectangle pantalla = Screen.PrimaryScreen.WorkingArea;

                // Calculamos la nueva posición de la ventana
                Point nuevaPosicion = new Point(
                    this.Left + e.X - posicionOriginal.X,
                    this.Top + e.Y - posicionOriginal.Y
                );

                // Asegúramos de que la ventana no se mueva fuera de los límites de la pantalla
                nuevaPosicion.X = Math.Max(pantalla.Left - Margen, Math.Min(pantalla.Right + Margen - Width, nuevaPosicion.X));
                nuevaPosicion.Y = Math.Max(pantalla.Top - Margen, Math.Min(pantalla.Bottom + Margen - Height, nuevaPosicion.Y));

                this.Location = nuevaPosicion;
            }
        }

        private void pnlBar_MouseUp(object sender, MouseEventArgs e)
        {
            // Detener el movimiento
            arrastrando = false;
        }

    }
}
