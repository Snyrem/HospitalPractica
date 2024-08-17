namespace HospitalPractica
{
    partial class RegistroMedico
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
            dtpFecha = new DateTimePicker();
            txtDescripcion = new TextBox();
            dgvRegistroMedico = new DataGridView();
            btnAgregar = new Button();
            btnEliminar = new Button();
            btnModificar = new Button();
            cmbMedico = new ComboBox();
            lbPaciente = new Label();
            lbMedico = new Label();
            lbDescripcion = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvRegistroMedico).BeginInit();
            SuspendLayout();
            // 
            // cmbPaciente
            // 
            cmbPaciente.FormattingEnabled = true;
            cmbPaciente.Location = new Point(564, 40);
            cmbPaciente.Name = "cmbPaciente";
            cmbPaciente.Size = new Size(121, 23);
            cmbPaciente.TabIndex = 0;
            cmbPaciente.SelectedIndexChanged += cmbPaciente_SelectedIndexChanged;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(526, 326);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(200, 23);
            dtpFecha.TabIndex = 1;
            dtpFecha.ValueChanged += dtpFecha_ValueChanged;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(564, 149);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(100, 23);
            txtDescripcion.TabIndex = 2;
            txtDescripcion.TextChanged += txtDescripcion_TextChanged;
            // 
            // dgvRegistroMedico
            // 
            dgvRegistroMedico.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRegistroMedico.Location = new Point(31, 34);
            dgvRegistroMedico.Name = "dgvRegistroMedico";
            dgvRegistroMedico.Size = new Size(370, 262);
            dgvRegistroMedico.TabIndex = 3;
            dgvRegistroMedico.CellContentClick += dgvRegistroMedico_CellContentClick;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(120, 328);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(244, 322);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(365, 371);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 6;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // cmbMedico
            // 
            cmbMedico.FormattingEnabled = true;
            cmbMedico.Location = new Point(564, 89);
            cmbMedico.Name = "cmbMedico";
            cmbMedico.Size = new Size(121, 23);
            cmbMedico.TabIndex = 7;
            cmbMedico.SelectedIndexChanged += cmbMedico_SelectedIndexChanged;
            // 
            // lbPaciente
            // 
            lbPaciente.AutoSize = true;
            lbPaciente.Location = new Point(495, 43);
            lbPaciente.Name = "lbPaciente";
            lbPaciente.Size = new Size(52, 15);
            lbPaciente.TabIndex = 8;
            lbPaciente.Text = "Paciente";
            // 
            // lbMedico
            // 
            lbMedico.AutoSize = true;
            lbMedico.Location = new Point(500, 89);
            lbMedico.Name = "lbMedico";
            lbMedico.Size = new Size(47, 15);
            lbMedico.TabIndex = 9;
            lbMedico.Text = "Medico";
            // 
            // lbDescripcion
            // 
            lbDescripcion.AutoSize = true;
            lbDescripcion.Location = new Point(469, 152);
            lbDescripcion.Name = "lbDescripcion";
            lbDescripcion.Size = new Size(69, 15);
            lbDescripcion.TabIndex = 10;
            lbDescripcion.Text = "Descripcion";
            // 
            // RegistroMedico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbDescripcion);
            Controls.Add(lbMedico);
            Controls.Add(lbPaciente);
            Controls.Add(cmbMedico);
            Controls.Add(btnModificar);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(dgvRegistroMedico);
            Controls.Add(txtDescripcion);
            Controls.Add(dtpFecha);
            Controls.Add(cmbPaciente);
            Name = "RegistroMedico";
            Text = "RegistroMedico";
            Load += RegistroMedico_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRegistroMedico).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbPaciente;
        private DateTimePicker dtpFecha;
        private TextBox txtDescripcion;
        private DataGridView dgvRegistroMedico;
        private Button btnAgregar;
        private Button btnEliminar;
        private Button btnModificar;
        private ComboBox cmbMedico;
        private Label lbPaciente;
        private Label lbMedico;
        private Label lbDescripcion;
    }
}