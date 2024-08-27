namespace CapaPresentacion
{
    partial class MenuView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuView));
            btnMedicamentos = new Button();
            btnFacturacion = new Button();
            btnPacientes = new Button();
            btnMedicos = new Button();
            pnlBar = new Panel();
            pictureBox1 = new PictureBox();
            btnMinimizar = new Button();
            btnCerrar = new Button();
            flpMenu = new FlowLayoutPanel();
            pnlViews = new Panel();
            pnlBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flpMenu.SuspendLayout();
            SuspendLayout();
            // 
            // btnMedicamentos
            // 
            btnMedicamentos.BackColor = SystemColors.MenuHighlight;
            btnMedicamentos.Cursor = Cursors.Hand;
            btnMedicamentos.FlatStyle = FlatStyle.Flat;
            btnMedicamentos.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnMedicamentos.ForeColor = SystemColors.ControlLightLight;
            btnMedicamentos.ImeMode = ImeMode.NoControl;
            btnMedicamentos.Location = new Point(3, 115);
            btnMedicamentos.Name = "btnMedicamentos";
            btnMedicamentos.Size = new Size(236, 50);
            btnMedicamentos.TabIndex = 6;
            btnMedicamentos.Text = "Medicamentos";
            btnMedicamentos.UseVisualStyleBackColor = false;
            btnMedicamentos.Click += btnMedicamentos_Click;
            // 
            // btnFacturacion
            // 
            btnFacturacion.BackColor = SystemColors.MenuHighlight;
            btnFacturacion.Cursor = Cursors.Hand;
            btnFacturacion.FlatStyle = FlatStyle.Flat;
            btnFacturacion.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnFacturacion.ForeColor = SystemColors.ControlLightLight;
            btnFacturacion.ImeMode = ImeMode.NoControl;
            btnFacturacion.Location = new Point(3, 171);
            btnFacturacion.Name = "btnFacturacion";
            btnFacturacion.Size = new Size(236, 50);
            btnFacturacion.TabIndex = 7;
            btnFacturacion.Text = "Facturacion";
            btnFacturacion.UseVisualStyleBackColor = false;
            btnFacturacion.Click += btnFacturacion_Click;
            // 
            // btnPacientes
            // 
            btnPacientes.BackColor = SystemColors.MenuHighlight;
            btnPacientes.Cursor = Cursors.Hand;
            btnPacientes.FlatStyle = FlatStyle.Flat;
            btnPacientes.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnPacientes.ForeColor = SystemColors.ControlLightLight;
            btnPacientes.ImeMode = ImeMode.NoControl;
            btnPacientes.Location = new Point(3, 3);
            btnPacientes.Name = "btnPacientes";
            btnPacientes.Size = new Size(236, 50);
            btnPacientes.TabIndex = 4;
            btnPacientes.Text = "Pacientes";
            btnPacientes.UseVisualStyleBackColor = false;
            btnPacientes.Click += btnPacientes_Click;
            // 
            // btnMedicos
            // 
            btnMedicos.BackColor = SystemColors.MenuHighlight;
            btnMedicos.Cursor = Cursors.Hand;
            btnMedicos.FlatStyle = FlatStyle.Flat;
            btnMedicos.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnMedicos.ForeColor = SystemColors.ControlLightLight;
            btnMedicos.ImeMode = ImeMode.NoControl;
            btnMedicos.Location = new Point(3, 59);
            btnMedicos.Name = "btnMedicos";
            btnMedicos.Size = new Size(236, 50);
            btnMedicos.TabIndex = 5;
            btnMedicos.Text = "Medicos";
            btnMedicos.UseVisualStyleBackColor = false;
            btnMedicos.Click += btnMedicos_Click;
            // 
            // pnlBar
            // 
            pnlBar.BackColor = SystemColors.ControlLightLight;
            pnlBar.Controls.Add(pictureBox1);
            pnlBar.Controls.Add(btnMinimizar);
            pnlBar.Controls.Add(btnCerrar);
            pnlBar.Dock = DockStyle.Top;
            pnlBar.Location = new Point(0, 0);
            pnlBar.Name = "pnlBar";
            pnlBar.Size = new Size(1280, 80);
            pnlBar.TabIndex = 8;
            pnlBar.MouseDown += pnlBar_MouseDown;
            pnlBar.MouseMove += pnlBar_MouseMove;
            pnlBar.MouseUp += pnlBar_MouseUp;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(4, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 73);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // btnMinimizar
            // 
            btnMinimizar.BackColor = SystemColors.GradientActiveCaption;
            btnMinimizar.FlatStyle = FlatStyle.Flat;
            btnMinimizar.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMinimizar.ForeColor = SystemColors.ActiveCaption;
            btnMinimizar.Location = new Point(1182, 12);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(40, 40);
            btnMinimizar.TabIndex = 2;
            btnMinimizar.Text = "__";
            btnMinimizar.TextAlign = ContentAlignment.TopCenter;
            btnMinimizar.UseVisualStyleBackColor = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.Red;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrar.ForeColor = SystemColors.ControlLightLight;
            btnCerrar.Location = new Point(1228, 12);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(40, 40);
            btnCerrar.TabIndex = 1;
            btnCerrar.Text = "X";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // flpMenu
            // 
            flpMenu.BackColor = Color.Azure;
            flpMenu.Controls.Add(btnPacientes);
            flpMenu.Controls.Add(btnMedicos);
            flpMenu.Controls.Add(btnMedicamentos);
            flpMenu.Controls.Add(btnFacturacion);
            flpMenu.Dock = DockStyle.Left;
            flpMenu.Location = new Point(0, 80);
            flpMenu.Name = "flpMenu";
            flpMenu.Size = new Size(244, 640);
            flpMenu.TabIndex = 9;
            // 
            // pnlViews
            // 
            pnlViews.BackColor = SystemColors.InactiveCaption;
            pnlViews.Dock = DockStyle.Fill;
            pnlViews.Location = new Point(244, 80);
            pnlViews.Name = "pnlViews";
            pnlViews.Size = new Size(1036, 640);
            pnlViews.TabIndex = 10;
            // 
            // MenuView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 720);
            Controls.Add(pnlViews);
            Controls.Add(flpMenu);
            Controls.Add(pnlBar);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MenuView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MenuView";
            pnlBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flpMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnMedicamentos;
        private Button btnFacturacion;
        private Button btnPacientes;
        private Button btnMedicos;
        private Panel pnlBar;
        private FlowLayoutPanel flpMenu;
        private Panel pnlViews;
        private Button btnCerrar;
        private Button btnMinimizar;
        private PictureBox pictureBox1;
    }
}