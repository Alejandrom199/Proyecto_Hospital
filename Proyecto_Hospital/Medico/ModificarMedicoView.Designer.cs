namespace CapaPresentacion.Medico.Complementos_Medico
{
    partial class ModificarMedicoView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarMedicoView));
            cbxSexo = new ComboBox();
            cbxConsultorio = new ComboBox();
            cbxHorario = new ComboBox();
            tbxEmail = new TextBox();
            label10 = new Label();
            label9 = new Label();
            pictureBox1 = new PictureBox();
            btnBorrarCampos = new Button();
            btnModificarMedico = new Button();
            cbxEspecialidad = new ComboBox();
            tbxTelefono = new TextBox();
            tbxNumeroLicencia = new TextBox();
            tbxCedula = new TextBox();
            tbxApellidos = new TextBox();
            tbxNombre = new TextBox();
            label12 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnBuscar = new Button();
            tbxId = new TextBox();
            label11 = new Label();
            dtpFechaNacimiento = new DateTimePicker();
            label13 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // cbxSexo
            // 
            cbxSexo.FormattingEnabled = true;
            cbxSexo.Items.AddRange(new object[] { "MASCULINO", "FEMENINO" });
            cbxSexo.Location = new Point(312, 341);
            cbxSexo.Name = "cbxSexo";
            cbxSexo.Size = new Size(277, 33);
            cbxSexo.TabIndex = 79;
            // 
            // cbxConsultorio
            // 
            cbxConsultorio.FormattingEnabled = true;
            cbxConsultorio.Location = new Point(267, 500);
            cbxConsultorio.Name = "cbxConsultorio";
            cbxConsultorio.Size = new Size(322, 33);
            cbxConsultorio.TabIndex = 75;
            // 
            // cbxHorario
            // 
            cbxHorario.FormattingEnabled = true;
            cbxHorario.Location = new Point(267, 460);
            cbxHorario.Name = "cbxHorario";
            cbxHorario.Size = new Size(322, 33);
            cbxHorario.TabIndex = 74;
            // 
            // tbxEmail
            // 
            tbxEmail.Cursor = Cursors.IBeam;
            tbxEmail.Location = new Point(267, 420);
            tbxEmail.Name = "tbxEmail";
            tbxEmail.Size = new Size(322, 31);
            tbxEmail.TabIndex = 73;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(70, 500);
            label10.Name = "label10";
            label10.Size = new Size(108, 25);
            label10.TabIndex = 72;
            label10.Text = "Consultorio:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(70, 300);
            label9.Name = "label9";
            label9.Size = new Size(167, 25);
            label9.TabIndex = 71;
            label9.Text = "Número de licencia:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(663, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(353, 596);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 70;
            pictureBox1.TabStop = false;
            // 
            // btnBorrarCampos
            // 
            btnBorrarCampos.BackColor = SystemColors.Highlight;
            btnBorrarCampos.FlatStyle = FlatStyle.Flat;
            btnBorrarCampos.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBorrarCampos.ForeColor = SystemColors.ControlLightLight;
            btnBorrarCampos.Location = new Point(312, 550);
            btnBorrarCampos.Name = "btnBorrarCampos";
            btnBorrarCampos.Size = new Size(239, 40);
            btnBorrarCampos.TabIndex = 69;
            btnBorrarCampos.Text = "Modificar otro Médico";
            btnBorrarCampos.UseVisualStyleBackColor = false;
            btnBorrarCampos.Click += btnBorrarCampos_Click;
            // 
            // btnModificarMedico
            // 
            btnModificarMedico.BackColor = SystemColors.Highlight;
            btnModificarMedico.FlatStyle = FlatStyle.Flat;
            btnModificarMedico.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnModificarMedico.ForeColor = SystemColors.ControlLightLight;
            btnModificarMedico.Location = new Point(103, 550);
            btnModificarMedico.Name = "btnModificarMedico";
            btnModificarMedico.Size = new Size(190, 40);
            btnModificarMedico.TabIndex = 68;
            btnModificarMedico.Text = "Modificar Medico";
            btnModificarMedico.UseVisualStyleBackColor = false;
            btnModificarMedico.Click += btnModificarMedico_Click;
            // 
            // cbxEspecialidad
            // 
            cbxEspecialidad.FormattingEnabled = true;
            cbxEspecialidad.Location = new Point(312, 260);
            cbxEspecialidad.Name = "cbxEspecialidad";
            cbxEspecialidad.RightToLeft = RightToLeft.No;
            cbxEspecialidad.Size = new Size(277, 33);
            cbxEspecialidad.TabIndex = 67;
            // 
            // tbxTelefono
            // 
            tbxTelefono.Cursor = Cursors.IBeam;
            tbxTelefono.Location = new Point(312, 380);
            tbxTelefono.Name = "tbxTelefono";
            tbxTelefono.Size = new Size(277, 31);
            tbxTelefono.TabIndex = 66;
            // 
            // tbxNumeroLicencia
            // 
            tbxNumeroLicencia.Location = new Point(312, 300);
            tbxNumeroLicencia.Name = "tbxNumeroLicencia";
            tbxNumeroLicencia.Size = new Size(277, 31);
            tbxNumeroLicencia.TabIndex = 65;
            // 
            // tbxCedula
            // 
            tbxCedula.Location = new Point(312, 180);
            tbxCedula.Name = "tbxCedula";
            tbxCedula.Size = new Size(277, 31);
            tbxCedula.TabIndex = 64;
            // 
            // tbxApellidos
            // 
            tbxApellidos.Location = new Point(312, 140);
            tbxApellidos.Name = "tbxApellidos";
            tbxApellidos.Size = new Size(277, 31);
            tbxApellidos.TabIndex = 63;
            // 
            // tbxNombre
            // 
            tbxNombre.ForeColor = SystemColors.WindowText;
            tbxNombre.Location = new Point(312, 100);
            tbxNombre.Name = "tbxNombre";
            tbxNombre.Size = new Size(277, 31);
            tbxNombre.TabIndex = 62;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = SystemColors.HotTrack;
            label12.Location = new Point(206, 10);
            label12.Name = "label12";
            label12.Size = new Size(256, 32);
            label12.TabIndex = 61;
            label12.Text = "MODFICAR MEDICOS";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(70, 420);
            label8.Name = "label8";
            label8.Size = new Size(58, 25);
            label8.TabIndex = 60;
            label8.Text = "Email:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(70, 380);
            label7.Name = "label7";
            label7.Size = new Size(83, 25);
            label7.TabIndex = 59;
            label7.Text = "Telefono:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(70, 460);
            label6.Name = "label6";
            label6.Size = new Size(173, 25);
            label6.TabIndex = 58;
            label6.Text = "Horario de atención:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(70, 340);
            label5.Name = "label5";
            label5.Size = new Size(54, 25);
            label5.TabIndex = 57;
            label5.Text = "Sexo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(70, 260);
            label4.Name = "label4";
            label4.Size = new Size(113, 25);
            label4.TabIndex = 56;
            label4.Text = "Especialidad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(70, 180);
            label3.Name = "label3";
            label3.Size = new Size(70, 25);
            label3.TabIndex = 55;
            label3.Text = "Cédula:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 140);
            label2.Name = "label2";
            label2.Size = new Size(90, 25);
            label2.TabIndex = 54;
            label2.Text = "Apellidos:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 100);
            label1.Name = "label1";
            label1.Size = new Size(87, 25);
            label1.TabIndex = 53;
            label1.Text = "Nombre: ";
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = SystemColors.Highlight;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = SystemColors.ControlLightLight;
            btnBuscar.Location = new Point(477, 60);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(112, 34);
            btnBuscar.TabIndex = 82;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // tbxId
            // 
            tbxId.Location = new Point(312, 60);
            tbxId.Name = "tbxId";
            tbxId.Size = new Size(150, 31);
            tbxId.TabIndex = 81;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(70, 60);
            label11.Name = "label11";
            label11.Size = new Size(34, 25);
            label11.TabIndex = 80;
            label11.Text = "ID:";
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Location = new Point(267, 220);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(322, 31);
            dtpFechaNacimiento.TabIndex = 84;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(70, 220);
            label13.Name = "label13";
            label13.Size = new Size(181, 25);
            label13.TabIndex = 83;
            label13.Text = "Fecha de Nacimiento:";
            // 
            // ModificarMedicoView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1014, 596);
            Controls.Add(dtpFechaNacimiento);
            Controls.Add(label13);
            Controls.Add(btnBuscar);
            Controls.Add(tbxId);
            Controls.Add(label11);
            Controls.Add(cbxSexo);
            Controls.Add(cbxConsultorio);
            Controls.Add(cbxHorario);
            Controls.Add(tbxEmail);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(pictureBox1);
            Controls.Add(btnBorrarCampos);
            Controls.Add(btnModificarMedico);
            Controls.Add(cbxEspecialidad);
            Controls.Add(tbxTelefono);
            Controls.Add(tbxNumeroLicencia);
            Controls.Add(tbxCedula);
            Controls.Add(tbxApellidos);
            Controls.Add(tbxNombre);
            Controls.Add(label12);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ModificarMedicoView";
            Text = "ModificarMedicoView";
            Load += ModificarMedicoView_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbxSexo;
        private ComboBox cbxConsultorio;
        private ComboBox cbxHorario;
        private TextBox tbxEmail;
        private Label label10;
        private Label label9;
        private PictureBox pictureBox1;
        private Button btnBorrarCampos;
        private Button btnModificarMedico;
        private ComboBox cbxEspecialidad;
        private TextBox tbxTelefono;
        private TextBox tbxNumeroLicencia;
        private TextBox tbxCedula;
        private TextBox tbxApellidos;
        private TextBox tbxNombre;
        private Label label12;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnBuscar;
        private TextBox tbxId;
        private Label label11;
        private DateTimePicker dtpFechaNacimiento;
        private Label label13;
    }
}