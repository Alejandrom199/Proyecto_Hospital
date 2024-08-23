namespace CapaPresentacion.Medico
{
    partial class HorarioView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HorarioView));
            btnNuevo = new Button();
            label3 = new Label();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnAgregar = new Button();
            dgvEspecialidad = new DataGridView();
            tbxHoraInicio = new TextBox();
            tbxId = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnCerrar = new Button();
            tbxHoraFin = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            tbxFechaInicio = new TextBox();
            tbxFechaFin = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvEspecialidad).BeginInit();
            SuspendLayout();
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = SystemColors.Highlight;
            btnNuevo.FlatStyle = FlatStyle.Flat;
            btnNuevo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnNuevo.ForeColor = SystemColors.ControlLightLight;
            btnNuevo.Location = new Point(118, 404);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(112, 34);
            btnNuevo.TabIndex = 23;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(324, 13);
            label3.Name = "label3";
            label3.Size = new Size(97, 25);
            label3.TabIndex = 22;
            label3.Text = "HORARIO";
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = SystemColors.Highlight;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEliminar.ForeColor = SystemColors.ControlLightLight;
            btnEliminar.Location = new Point(524, 404);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(112, 34);
            btnEliminar.TabIndex = 21;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = SystemColors.Highlight;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnModificar.ForeColor = SystemColors.ControlLightLight;
            btnModificar.Location = new Point(387, 404);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(112, 34);
            btnModificar.TabIndex = 20;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = SystemColors.Highlight;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAgregar.ForeColor = SystemColors.ControlLightLight;
            btnAgregar.Location = new Point(252, 404);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(112, 34);
            btnAgregar.TabIndex = 19;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dgvEspecialidad
            // 
            dgvEspecialidad.BackgroundColor = SystemColors.ActiveCaption;
            dgvEspecialidad.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEspecialidad.Location = new Point(12, 147);
            dgvEspecialidad.Name = "dgvEspecialidad";
            dgvEspecialidad.RowHeadersWidth = 62;
            dgvEspecialidad.Size = new Size(776, 244);
            dgvEspecialidad.TabIndex = 18;
            dgvEspecialidad.CellClick += dgvEspecialidad_CellClick;
            // 
            // tbxHoraInicio
            // 
            tbxHoraInicio.Location = new Point(307, 60);
            tbxHoraInicio.Name = "tbxHoraInicio";
            tbxHoraInicio.Size = new Size(150, 31);
            tbxHoraInicio.TabIndex = 17;
            // 
            // tbxId
            // 
            tbxId.Location = new Point(80, 60);
            tbxId.Name = "tbxId";
            tbxId.ReadOnly = true;
            tbxId.Size = new Size(109, 31);
            tbxId.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(201, 60);
            label2.Name = "label2";
            label2.Size = new Size(101, 25);
            label2.TabIndex = 15;
            label2.Text = "Hora inicio:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 60);
            label1.Name = "label1";
            label1.Size = new Size(34, 25);
            label1.TabIndex = 14;
            label1.Text = "ID:";
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.Red;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrar.ForeColor = SystemColors.ControlLightLight;
            btnCerrar.Location = new Point(738, 16);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(50, 50);
            btnCerrar.TabIndex = 13;
            btnCerrar.Text = "X";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // tbxHoraFin
            // 
            tbxHoraFin.Location = new Point(557, 60);
            tbxHoraFin.Name = "tbxHoraFin";
            tbxHoraFin.Size = new Size(150, 31);
            tbxHoraFin.TabIndex = 25;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(468, 60);
            label4.Name = "label4";
            label4.Size = new Size(80, 25);
            label4.TabIndex = 24;
            label4.Text = "Hora fin:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(201, 105);
            label5.Name = "label5";
            label5.Size = new Size(88, 25);
            label5.TabIndex = 26;
            label5.Text = "Día inicio:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(468, 105);
            label6.Name = "label6";
            label6.Size = new Size(67, 25);
            label6.TabIndex = 27;
            label6.Text = "Día fin:";
            // 
            // tbxFechaInicio
            // 
            tbxFechaInicio.Location = new Point(307, 105);
            tbxFechaInicio.Name = "tbxFechaInicio";
            tbxFechaInicio.Size = new Size(150, 31);
            tbxFechaInicio.TabIndex = 28;
            // 
            // tbxFechaFin
            // 
            tbxFechaFin.Location = new Point(557, 105);
            tbxFechaFin.Name = "tbxFechaFin";
            tbxFechaFin.Size = new Size(150, 31);
            tbxFechaFin.TabIndex = 29;
            // 
            // HorarioView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(tbxFechaFin);
            Controls.Add(tbxFechaInicio);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(tbxHoraFin);
            Controls.Add(label4);
            Controls.Add(btnNuevo);
            Controls.Add(label3);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(dgvEspecialidad);
            Controls.Add(tbxHoraInicio);
            Controls.Add(tbxId);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCerrar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "HorarioView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HorarioView";
            Load += HorarioView_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEspecialidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNuevo;
        private Label label3;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnAgregar;
        private DataGridView dgvEspecialidad;
        private TextBox tbxHoraInicio;
        private TextBox tbxId;
        private Label label2;
        private Label label1;
        private Button btnCerrar;
        private TextBox tbxHoraFin;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox tbxFechaInicio;
        private TextBox tbxFechaFin;
    }
}