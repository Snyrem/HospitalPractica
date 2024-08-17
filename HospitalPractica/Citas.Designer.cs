namespace HospitalPractica
{
    partial class Citas
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
            cmbPaciente = new ComboBox();
            cmbMedico = new ComboBox();
            dtpFecha = new DateTimePicker();
            dgvCitas = new DataGridView();
            btnAgregar = new Button();
            btnEliminar = new Button();
            btnModificar = new Button();
            lbMedicos = new Label();
            lbPaciente = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCitas).BeginInit();
            SuspendLayout();
            // 
            // cmbPaciente
            // 
            cmbPaciente.FormattingEnabled = true;
            cmbPaciente.Location = new Point(547, 103);
            cmbPaciente.Name = "cmbPaciente";
            cmbPaciente.Size = new Size(121, 23);
            cmbPaciente.TabIndex = 0;
            cmbPaciente.SelectedIndexChanged += cmbPaciente_SelectedIndexChanged;
            // 
            // cmbMedico
            // 
            cmbMedico.FormattingEnabled = true;
            cmbMedico.Location = new Point(547, 47);
            cmbMedico.Name = "cmbMedico";
            cmbMedico.Size = new Size(121, 23);
            cmbMedico.TabIndex = 1;
            cmbMedico.SelectedIndexChanged += cmbMedico_SelectedIndexChanged;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(448, 179);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(200, 23);
            dtpFecha.TabIndex = 2;
            // 
            // dgvCitas
            // 
            dgvCitas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCitas.Location = new Point(37, 33);
            dgvCitas.Name = "dgvCitas";
            dgvCitas.Size = new Size(374, 336);
            dgvCitas.TabIndex = 3;
            dgvCitas.CellContentClick += dgvCitas_CellContentClick;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(448, 253);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(629, 415);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(593, 253);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 6;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // lbMedicos
            // 
            lbMedicos.AutoSize = true;
            lbMedicos.Location = new Point(448, 47);
            lbMedicos.Name = "lbMedicos";
            lbMedicos.Size = new Size(52, 15);
            lbMedicos.TabIndex = 7;
            lbMedicos.Text = "Medicos";
            // 
            // lbPaciente
            // 
            lbPaciente.AutoSize = true;
            lbPaciente.Location = new Point(448, 103);
            lbPaciente.Name = "lbPaciente";
            lbPaciente.Size = new Size(52, 15);
            lbPaciente.TabIndex = 8;
            lbPaciente.Text = "Paciente";
            // 
            // Citas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbPaciente);
            Controls.Add(lbMedicos);
            Controls.Add(btnModificar);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(dgvCitas);
            Controls.Add(dtpFecha);
            Controls.Add(cmbMedico);
            Controls.Add(cmbPaciente);
            Name = "Citas";
            Text = "Citas";
            Load += Citas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCitas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbPaciente;
        private ComboBox cmbMedico;
        private DateTimePicker dtpFecha;
        private DataGridView dgvCitas;
        private Button btnAgregar;
        private Button btnEliminar;
        private Button btnModificar;
        private Label lbMedicos;
        private Label lbPaciente;
    }
}