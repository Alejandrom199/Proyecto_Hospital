namespace CapaPresentacion
{
    partial class ListarPacienteView
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
            dgvPacientes = new DataGridView();
            label12 = new Label();
            label1 = new Label();
            cbxFiltro = new ComboBox();
            lblValor = new Label();
            btnBuscarPaciente = new Button();
            tbxValor = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvPacientes).BeginInit();
            SuspendLayout();
            // 
            // dgvPacientes
            // 
            dgvPacientes.BackgroundColor = SystemColors.InactiveCaption;
            dgvPacientes.BorderStyle = BorderStyle.Fixed3D;
            dgvPacientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPacientes.Location = new Point(12, 171);
            dgvPacientes.Name = "dgvPacientes";
            dgvPacientes.RowHeadersWidth = 62;
            dgvPacientes.Size = new Size(990, 414);
            dgvPacientes.TabIndex = 0;
            dgvPacientes.CellContentClick += dgvPacientes_CellContentClick;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = SystemColors.HotTrack;
            label12.Location = new Point(370, 30);
            label12.Name = "label12";
            label12.Size = new Size(283, 32);
            label12.TabIndex = 12;
            label12.Text = "LISTADO DE PACIENTES";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 125);
            label1.Name = "label1";
            label1.Size = new Size(93, 25);
            label1.TabIndex = 13;
            label1.Text = "Filtrar por:";
            // 
            // cbxFiltro
            // 
            cbxFiltro.FormattingEnabled = true;
            cbxFiltro.Items.AddRange(new object[] { "Id", "Nombre", "Apellido", "Cedula" });
            cbxFiltro.Location = new Point(110, 125);
            cbxFiltro.Name = "cbxFiltro";
            cbxFiltro.Size = new Size(227, 33);
            cbxFiltro.TabIndex = 14;
            cbxFiltro.SelectedIndexChanged += cbxFiltro_SelectedIndexChanged;
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Location = new Point(366, 125);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(56, 25);
            lblValor.TabIndex = 15;
            lblValor.Text = "Valor:";
            lblValor.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnBuscarPaciente
            // 
            btnBuscarPaciente.BackColor = SystemColors.Highlight;
            btnBuscarPaciente.Cursor = Cursors.Hand;
            btnBuscarPaciente.FlatStyle = FlatStyle.Flat;
            btnBuscarPaciente.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscarPaciente.ForeColor = SystemColors.ControlLightLight;
            btnBuscarPaciente.Location = new Point(679, 125);
            btnBuscarPaciente.Name = "btnBuscarPaciente";
            btnBuscarPaciente.Size = new Size(188, 34);
            btnBuscarPaciente.TabIndex = 17;
            btnBuscarPaciente.Text = "Buscar Paciente";
            btnBuscarPaciente.UseVisualStyleBackColor = false;
            btnBuscarPaciente.Click += btnBuscarPaciente_Click;
            // 
            // tbxValor
            // 
            tbxValor.Location = new Point(449, 125);
            tbxValor.Name = "tbxValor";
            tbxValor.Size = new Size(214, 31);
            tbxValor.TabIndex = 18;
            // 
            // ListarPacienteView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1014, 596);
            Controls.Add(tbxValor);
            Controls.Add(btnBuscarPaciente);
            Controls.Add(lblValor);
            Controls.Add(cbxFiltro);
            Controls.Add(label1);
            Controls.Add(label12);
            Controls.Add(dgvPacientes);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ListarPacienteView";
            Text = "PacienteView";
            Load += PacienteView_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPacientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPacientes;
        private Label label12;
        private Label label1;
        private ComboBox cbxFiltro;
        private Label lblValor;
        private Button btnBuscarPaciente;
        private TextBox tbxValor;
    }
}