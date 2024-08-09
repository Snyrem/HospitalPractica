namespace HospitalPractica
{
    partial class Paciente
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
            ((System.ComponentModel.ISupportInitialize)dgvPacientes).BeginInit();
            SuspendLayout();
            // 
            // dgvPacientes
            // 
            dgvPacientes.AccessibleName = "dgvPacientes";
            dgvPacientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPacientes.Location = new Point(221, 101);
            dgvPacientes.Name = "dgvPacientes";
            dgvPacientes.Size = new Size(240, 150);
            dgvPacientes.TabIndex = 0;
            dgvPacientes.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Paciente
            // 
            ClientSize = new Size(814, 456);
            Controls.Add(dgvPacientes);
            Name = "Paciente";
            Load += Paciente_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPacientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvPacientes;
    }
}