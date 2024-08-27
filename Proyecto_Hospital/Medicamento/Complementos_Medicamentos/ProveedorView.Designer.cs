namespace CapaPresentacion.Medicamento.Complementos_Medicamentos
{
    partial class ProveedorView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProveedorView));
            tbxNombreContacto = new TextBox();
            tbxEmail = new TextBox();
            label6 = new Label();
            label5 = new Label();
            tbxDireccion = new TextBox();
            label4 = new Label();
            btnNuevo = new Button();
            label3 = new Label();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnAgregar = new Button();
            dgvProveedor = new DataGridView();
            tbxNombre = new TextBox();
            tbxId = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnCerrar = new Button();
            tbxTelefono = new TextBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProveedor).BeginInit();
            SuspendLayout();
            // 
            // tbxNombreContacto
            // 
            tbxNombreContacto.Location = new Point(534, 140);
            tbxNombreContacto.Name = "tbxNombreContacto";
            tbxNombreContacto.Size = new Size(226, 31);
            tbxNombreContacto.TabIndex = 46;
            // 
            // tbxEmail
            // 
            tbxEmail.Location = new Point(108, 140);
            tbxEmail.Name = "tbxEmail";
            tbxEmail.Size = new Size(235, 31);
            tbxEmail.TabIndex = 45;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(347, 140);
            label6.Name = "label6";
            label6.Size = new Size(181, 25);
            label6.TabIndex = 44;
            label6.Text = "Nombre de contacto:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(44, 140);
            label5.Name = "label5";
            label5.Size = new Size(58, 25);
            label5.TabIndex = 43;
            label5.Text = "Email:";
            // 
            // tbxDireccion
            // 
            tbxDireccion.Location = new Point(133, 100);
            tbxDireccion.Name = "tbxDireccion";
            tbxDireccion.Size = new Size(627, 31);
            tbxDireccion.TabIndex = 42;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 100);
            label4.Name = "label4";
            label4.Size = new Size(89, 25);
            label4.TabIndex = 41;
            label4.Text = "Dirección:";
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
            btnNuevo.TabIndex = 40;
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
            label3.Size = new Size(120, 25);
            label3.TabIndex = 39;
            label3.Text = "PROVEEDOR";
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
            btnEliminar.TabIndex = 38;
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
            btnModificar.TabIndex = 37;
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
            btnAgregar.TabIndex = 36;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dgvProveedor
            // 
            dgvProveedor.BackgroundColor = SystemColors.ActiveCaption;
            dgvProveedor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProveedor.Location = new Point(12, 179);
            dgvProveedor.Name = "dgvProveedor";
            dgvProveedor.RowHeadersWidth = 62;
            dgvProveedor.Size = new Size(776, 214);
            dgvProveedor.TabIndex = 35;
            dgvProveedor.CellClick += dgvProveedor_CellClick;
            // 
            // tbxNombre
            // 
            tbxNombre.Location = new Point(252, 60);
            tbxNombre.Name = "tbxNombre";
            tbxNombre.Size = new Size(198, 31);
            tbxNombre.TabIndex = 34;
            // 
            // tbxId
            // 
            tbxId.Location = new Point(80, 60);
            tbxId.Name = "tbxId";
            tbxId.ReadOnly = true;
            tbxId.Size = new Size(80, 31);
            tbxId.TabIndex = 33;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(169, 60);
            label2.Name = "label2";
            label2.Size = new Size(82, 25);
            label2.TabIndex = 32;
            label2.Text = "Nombre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 60);
            label1.Name = "label1";
            label1.Size = new Size(34, 25);
            label1.TabIndex = 31;
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
            btnCerrar.TabIndex = 30;
            btnCerrar.Text = "X";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // tbxTelefono
            // 
            tbxTelefono.Location = new Point(545, 60);
            tbxTelefono.Name = "tbxTelefono";
            tbxTelefono.Size = new Size(215, 31);
            tbxTelefono.TabIndex = 48;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(456, 60);
            label7.Name = "label7";
            label7.Size = new Size(83, 25);
            label7.TabIndex = 47;
            label7.Text = "Telefono:";
            // 
            // ProveedorView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(tbxTelefono);
            Controls.Add(label7);
            Controls.Add(tbxNombreContacto);
            Controls.Add(tbxEmail);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(tbxDireccion);
            Controls.Add(label4);
            Controls.Add(btnNuevo);
            Controls.Add(label3);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(dgvProveedor);
            Controls.Add(tbxNombre);
            Controls.Add(tbxId);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCerrar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProveedorView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProveedorView";
            Load += ProveedorView_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProveedor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbxNombreContacto;
        private TextBox tbxEmail;
        private Label label6;
        private Label label5;
        private TextBox tbxDireccion;
        private Label label4;
        private Button btnNuevo;
        private Label label3;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnAgregar;
        private DataGridView dgvProveedor;
        private TextBox tbxNombre;
        private TextBox tbxId;
        private Label label2;
        private Label label1;
        private Button btnCerrar;
        private TextBox tbxTelefono;
        private Label label7;
    }
}