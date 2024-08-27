namespace CapaPresentacion.Medico
{
    partial class AgregarMedicoView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarMedicoView));
            btnBorrarCampos = new Button();
            btnAgregarMedico = new Button();
            cbxEspecialidad = new ComboBox();
            tbxTelefono = new TextBox();
            tbxCedula = new TextBox();
            tbxApellidos = new TextBox();
            tbxNombre = new TextBox();
            label12 = new Label();
            label8 = new Label();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label9 = new Label();
            tbxNumeroLicencia = new TextBox();
            label6 = new Label();
            label10 = new Label();
            tbxEmail = new TextBox();
            cbxHorario = new ComboBox();
            cbxConsultorio = new ComboBox();
            btnConsultorio = new Button();
            btnHorario = new Button();
            btnEspecialidad = new Button();
            cbxSexo = new ComboBox();
            dtpFechaNacimiento = new DateTimePicker();
            label13 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnBorrarCampos
            // 
            btnBorrarCampos.BackColor = SystemColors.Highlight;
            btnBorrarCampos.FlatStyle = FlatStyle.Flat;
            btnBorrarCampos.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBorrarCampos.ForeColor = SystemColors.ControlLightLight;
            btnBorrarCampos.Location = new Point(344, 550);
            btnBorrarCampos.Name = "btnBorrarCampos";
            btnBorrarCampos.Size = new Size(182, 40);
            btnBorrarCampos.TabIndex = 40;
            btnBorrarCampos.Text = "Borrar Campos";
            btnBorrarCampos.UseVisualStyleBackColor = false;
            btnBorrarCampos.Click += btnBorrarCampos_Click;
            // 
            // btnAgregarMedico
            // 
            btnAgregarMedico.BackColor = SystemColors.Highlight;
            btnAgregarMedico.FlatStyle = FlatStyle.Flat;
            btnAgregarMedico.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAgregarMedico.ForeColor = SystemColors.ControlLightLight;
            btnAgregarMedico.Location = new Point(135, 550);
            btnAgregarMedico.Name = "btnAgregarMedico";
            btnAgregarMedico.Size = new Size(190, 40);
            btnAgregarMedico.TabIndex = 39;
            btnAgregarMedico.Text = "Agregar Medico";
            btnAgregarMedico.UseVisualStyleBackColor = false;
            btnAgregarMedico.Click += btnAgregarMedico_Click;
            // 
            // cbxEspecialidad
            // 
            cbxEspecialidad.FormattingEnabled = true;
            cbxEspecialidad.Location = new Point(312, 220);
            cbxEspecialidad.Name = "cbxEspecialidad";
            cbxEspecialidad.RightToLeft = RightToLeft.No;
            cbxEspecialidad.Size = new Size(237, 33);
            cbxEspecialidad.TabIndex = 37;
            // 
            // tbxTelefono
            // 
            tbxTelefono.Cursor = Cursors.IBeam;
            tbxTelefono.Location = new Point(312, 340);
            tbxTelefono.Name = "tbxTelefono";
            tbxTelefono.Size = new Size(277, 31);
            tbxTelefono.TabIndex = 36;
            // 
            // tbxCedula
            // 
            tbxCedula.Location = new Point(312, 140);
            tbxCedula.Name = "tbxCedula";
            tbxCedula.Size = new Size(277, 31);
            tbxCedula.TabIndex = 33;
            // 
            // tbxApellidos
            // 
            tbxApellidos.Location = new Point(312, 100);
            tbxApellidos.Name = "tbxApellidos";
            tbxApellidos.Size = new Size(277, 31);
            tbxApellidos.TabIndex = 32;
            // 
            // tbxNombre
            // 
            tbxNombre.ForeColor = SystemColors.WindowText;
            tbxNombre.Location = new Point(312, 60);
            tbxNombre.Name = "tbxNombre";
            tbxNombre.Size = new Size(277, 31);
            tbxNombre.TabIndex = 31;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = SystemColors.HotTrack;
            label12.Location = new Point(206, 10);
            label12.Name = "label12";
            label12.Size = new Size(242, 32);
            label12.TabIndex = 30;
            label12.Text = "AGREGAR MEDICOS";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(70, 380);
            label8.Name = "label8";
            label8.Size = new Size(58, 25);
            label8.TabIndex = 29;
            label8.Text = "Email:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(70, 340);
            label7.Name = "label7";
            label7.Size = new Size(83, 25);
            label7.TabIndex = 28;
            label7.Text = "Telefono:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(70, 300);
            label5.Name = "label5";
            label5.Size = new Size(54, 25);
            label5.TabIndex = 26;
            label5.Text = "Sexo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(70, 220);
            label4.Name = "label4";
            label4.Size = new Size(113, 25);
            label4.TabIndex = 25;
            label4.Text = "Especialidad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(70, 140);
            label3.Name = "label3";
            label3.Size = new Size(70, 25);
            label3.TabIndex = 24;
            label3.Text = "Cédula:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 100);
            label2.Name = "label2";
            label2.Size = new Size(90, 25);
            label2.TabIndex = 23;
            label2.Text = "Apellidos:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 60);
            label1.Name = "label1";
            label1.Size = new Size(87, 25);
            label1.TabIndex = 22;
            label1.Text = "Nombre: ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(663, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(353, 596);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 41;
            pictureBox1.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(70, 260);
            label9.Name = "label9";
            label9.Size = new Size(167, 25);
            label9.TabIndex = 42;
            label9.Text = "Número de licencia:";
            // 
            // tbxNumeroLicencia
            // 
            tbxNumeroLicencia.Location = new Point(312, 260);
            tbxNumeroLicencia.Name = "tbxNumeroLicencia";
            tbxNumeroLicencia.Size = new Size(277, 31);
            tbxNumeroLicencia.TabIndex = 34;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(70, 420);
            label6.Name = "label6";
            label6.Size = new Size(173, 25);
            label6.TabIndex = 27;
            label6.Text = "Horario de atención:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(70, 460);
            label10.Name = "label10";
            label10.Size = new Size(108, 25);
            label10.TabIndex = 43;
            label10.Text = "Consultorio:";
            // 
            // tbxEmail
            // 
            tbxEmail.Cursor = Cursors.IBeam;
            tbxEmail.Location = new Point(267, 380);
            tbxEmail.Name = "tbxEmail";
            tbxEmail.Size = new Size(322, 31);
            tbxEmail.TabIndex = 44;
            // 
            // cbxHorario
            // 
            cbxHorario.FormattingEnabled = true;
            cbxHorario.Location = new Point(267, 420);
            cbxHorario.Name = "cbxHorario";
            cbxHorario.Size = new Size(282, 33);
            cbxHorario.TabIndex = 46;
            // 
            // cbxConsultorio
            // 
            cbxConsultorio.FormattingEnabled = true;
            cbxConsultorio.Location = new Point(267, 460);
            cbxConsultorio.Name = "cbxConsultorio";
            cbxConsultorio.Size = new Size(282, 33);
            cbxConsultorio.TabIndex = 47;
            // 
            // btnConsultorio
            // 
            btnConsultorio.BackColor = SystemColors.Highlight;
            btnConsultorio.Cursor = Cursors.Hand;
            btnConsultorio.FlatStyle = FlatStyle.Flat;
            btnConsultorio.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            btnConsultorio.ForeColor = SystemColors.ControlLightLight;
            btnConsultorio.Location = new Point(555, 460);
            btnConsultorio.Name = "btnConsultorio";
            btnConsultorio.Size = new Size(34, 34);
            btnConsultorio.TabIndex = 49;
            btnConsultorio.Text = "+";
            btnConsultorio.TextAlign = ContentAlignment.TopCenter;
            btnConsultorio.UseVisualStyleBackColor = false;
            btnConsultorio.Click += btnConsultorio_Click;
            // 
            // btnHorario
            // 
            btnHorario.BackColor = SystemColors.Highlight;
            btnHorario.Cursor = Cursors.Hand;
            btnHorario.FlatStyle = FlatStyle.Flat;
            btnHorario.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            btnHorario.ForeColor = SystemColors.ControlLightLight;
            btnHorario.Location = new Point(555, 420);
            btnHorario.Name = "btnHorario";
            btnHorario.Size = new Size(34, 34);
            btnHorario.TabIndex = 50;
            btnHorario.Text = "+";
            btnHorario.TextAlign = ContentAlignment.TopCenter;
            btnHorario.UseVisualStyleBackColor = false;
            btnHorario.Click += btnHorario_Click_1;
            // 
            // btnEspecialidad
            // 
            btnEspecialidad.BackColor = SystemColors.Highlight;
            btnEspecialidad.Cursor = Cursors.Hand;
            btnEspecialidad.FlatStyle = FlatStyle.Flat;
            btnEspecialidad.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            btnEspecialidad.ForeColor = SystemColors.ControlLightLight;
            btnEspecialidad.Location = new Point(555, 220);
            btnEspecialidad.Name = "btnEspecialidad";
            btnEspecialidad.Size = new Size(34, 34);
            btnEspecialidad.TabIndex = 51;
            btnEspecialidad.Text = "+";
            btnEspecialidad.TextAlign = ContentAlignment.TopCenter;
            btnEspecialidad.UseVisualStyleBackColor = false;
            btnEspecialidad.Click += btnEspecialidad_Click_1;
            // 
            // cbxSexo
            // 
            cbxSexo.FormattingEnabled = true;
            cbxSexo.Items.AddRange(new object[] { "MASCULINO", "FEMENINO" });
            cbxSexo.Location = new Point(312, 301);
            cbxSexo.Name = "cbxSexo";
            cbxSexo.Size = new Size(277, 33);
            cbxSexo.TabIndex = 52;
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Location = new Point(267, 180);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(322, 31);
            dtpFechaNacimiento.TabIndex = 86;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(70, 180);
            label13.Name = "label13";
            label13.Size = new Size(181, 25);
            label13.TabIndex = 85;
            label13.Text = "Fecha de Nacimiento:";
            // 
            // AgregarMedicoView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1014, 596);
            Controls.Add(dtpFechaNacimiento);
            Controls.Add(label13);
            Controls.Add(cbxSexo);
            Controls.Add(btnEspecialidad);
            Controls.Add(btnHorario);
            Controls.Add(btnConsultorio);
            Controls.Add(cbxConsultorio);
            Controls.Add(cbxHorario);
            Controls.Add(tbxEmail);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(pictureBox1);
            Controls.Add(btnBorrarCampos);
            Controls.Add(btnAgregarMedico);
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
            Name = "AgregarMedicoView";
            Text = "AgregarMedicoView";
            Load += AgregarMedicoView_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBorrarCampos;
        private Button btnAgregarMedico;
        private ComboBox cbxEspecialidad;
        private TextBox tbxTelefono;
        private TextBox tbxCedula;
        private TextBox tbxApellidos;
        private TextBox tbxNombre;
        private Label label12;
        private Label label8;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label9;
        private TextBox tbxNumeroLicencia;
        private Label label6;
        private Label label10;
        private TextBox tbxEmail;
        private ComboBox cbxHorario;
        private ComboBox cbxConsultorio;
        private Button btnConsultorio;
        private Button btnHorario;
        private Button btnEspecialidad;
        private ComboBox cbxSexo;
        private DateTimePicker dtpFechaNacimiento;
        private Label label13;
    }
}