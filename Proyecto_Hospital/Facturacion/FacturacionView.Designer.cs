namespace CapaPresentacion
{
    partial class FacturacionView
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
            label1 = new Label();
            dgvMedicamentos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvMedicamentos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 36);
            label1.Name = "label1";
            label1.Size = new Size(122, 25);
            label1.TabIndex = 3;
            label1.Text = "Facturaciones:";
            // 
            // dgvMedicamentos
            // 
            dgvMedicamentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMedicamentos.Location = new Point(28, 79);
            dgvMedicamentos.Name = "dgvMedicamentos";
            dgvMedicamentos.RowHeadersWidth = 62;
            dgvMedicamentos.Size = new Size(980, 420);
            dgvMedicamentos.TabIndex = 2;
            // 
            // FacturacionView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1036, 652);
            Controls.Add(label1);
            Controls.Add(dgvMedicamentos);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FacturacionView";
            Text = "FacturacionView";
            Load += FacturacionView_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMedicamentos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvMedicamentos;
    }
}