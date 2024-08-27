namespace CapaPresentacion.Medicamento.Complementos_Medicamentos
{
    partial class PresentacionView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PresentacionView));
            btnNuevo = new Button();
            label3 = new Label();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnAgregar = new Button();
            dgvPresentacion = new DataGridView();
            tbxId = new TextBox();
            label1 = new Label();
            btnCerrar = new Button();
            label2 = new Label();
            tbxNombre = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvPresentacion).BeginInit();
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
            btnNuevo.TabIndex = 38;
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
            label3.Size = new Size(147, 25);
            label3.TabIndex = 37;
            label3.Text = "PRESENTACIÓN";
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
            btnEliminar.TabIndex = 36;
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
            btnModificar.TabIndex = 35;
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
            btnAgregar.TabIndex = 34;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dgvPresentacion
            // 
            dgvPresentacion.BackgroundColor = SystemColors.ActiveCaption;
            dgvPresentacion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPresentacion.Location = new Point(12, 115);
            dgvPresentacion.Name = "dgvPresentacion";
            dgvPresentacion.RowHeadersWidth = 62;
            dgvPresentacion.Size = new Size(776, 276);
            dgvPresentacion.TabIndex = 33;
            dgvPresentacion.CellClick += dgvPresentacion_CellClick;
            // 
            // tbxId
            // 
            tbxId.Location = new Point(80, 60);
            tbxId.Name = "tbxId";
            tbxId.ReadOnly = true;
            tbxId.Size = new Size(80, 31);
            tbxId.TabIndex = 31;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 60);
            label1.Name = "label1";
            label1.Size = new Size(34, 25);
            label1.TabIndex = 29;
            label1.Text = "ID:";
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.Red;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrar.ForeColor = SystemColors.ControlLightLight;
            btnCerrar.Location = new Point(743, 16);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(40, 40);
            btnCerrar.TabIndex = 28;
            btnCerrar.Text = "X";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(164, 60);
            label2.Name = "label2";
            label2.Size = new Size(82, 25);
            label2.TabIndex = 30;
            label2.Text = "Nombre:";
            // 
            // tbxNombre
            // 
            tbxNombre.Location = new Point(252, 60);
            tbxNombre.Name = "tbxNombre";
            tbxNombre.Size = new Size(150, 31);
            tbxNombre.TabIndex = 32;
            // 
            // PresentacionView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(btnNuevo);
            Controls.Add(label3);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(dgvPresentacion);
            Controls.Add(tbxNombre);
            Controls.Add(tbxId);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCerrar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PresentacionView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PresentacionView";
            Load += PresentacionView_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPresentacion).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbxNumero;
        private Label label5;
        private TextBox tbxPiso;
        private Label label4;
        private Button btnNuevo;
        private Label label3;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnAgregar;
        private DataGridView dgvPresentacion;
        private TextBox tbxId;
        private Label label1;
        private Button btnCerrar;
        private Label label2;
        private TextBox tbxNombre;
    }
}