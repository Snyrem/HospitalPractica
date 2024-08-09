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
            dgvPaciente = new DataGridView();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            txtNombre = new TextBox();
            dtpFechaDeNacimiento = new DateTimePicker();
            txtTelefono = new TextBox();
            txtDomicilio = new TextBox();
            lbNombre = new Label();
            lbFechaDeNacimiento = new Label();
            lbTelefono = new Label();
            lbDomicilio = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPaciente).BeginInit();
            SuspendLayout();
            // 
            // dgvPaciente
            // 
            dgvPaciente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPaciente.Location = new Point(36, 61);
            dgvPaciente.Name = "dgvPaciente";
            dgvPaciente.Size = new Size(328, 249);
            dgvPaciente.TabIndex = 0;
            dgvPaciente.CellContentClick += dgvPaciente_CellContentClick;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(518, 299);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(622, 299);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 2;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(36, 403);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(535, 84);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 4;
            // 
            // dtpFechaDeNacimiento
            // 
            dtpFechaDeNacimiento.Location = new Point(535, 132);
            dtpFechaDeNacimiento.Name = "dtpFechaDeNacimiento";
            dtpFechaDeNacimiento.Size = new Size(200, 23);
            dtpFechaDeNacimiento.TabIndex = 5;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(535, 178);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(100, 23);
            txtTelefono.TabIndex = 6;
            // 
            // txtDomicilio
            // 
            txtDomicilio.Location = new Point(535, 239);
            txtDomicilio.Name = "txtDomicilio";
            txtDomicilio.Size = new Size(100, 23);
            txtDomicilio.TabIndex = 7;
            // 
            // lbNombre
            // 
            lbNombre.AutoSize = true;
            lbNombre.Location = new Point(441, 87);
            lbNombre.Name = "lbNombre";
            lbNombre.Size = new Size(51, 15);
            lbNombre.TabIndex = 8;
            lbNombre.Text = "Nombre";
            // 
            // lbFechaDeNacimiento
            // 
            lbFechaDeNacimiento.AutoSize = true;
            lbFechaDeNacimiento.Location = new Point(409, 132);
            lbFechaDeNacimiento.Name = "lbFechaDeNacimiento";
            lbFechaDeNacimiento.Size = new Size(120, 15);
            lbFechaDeNacimiento.TabIndex = 9;
            lbFechaDeNacimiento.Text = "Fecha De Nacimiento";
            // 
            // lbTelefono
            // 
            lbTelefono.AutoSize = true;
            lbTelefono.Location = new Point(441, 181);
            lbTelefono.Name = "lbTelefono";
            lbTelefono.Size = new Size(52, 15);
            lbTelefono.TabIndex = 10;
            lbTelefono.Text = "Telefono";
            // 
            // lbDomicilio
            // 
            lbDomicilio.AutoSize = true;
            lbDomicilio.Location = new Point(435, 242);
            lbDomicilio.Name = "lbDomicilio";
            lbDomicilio.Size = new Size(58, 15);
            lbDomicilio.TabIndex = 11;
            lbDomicilio.Text = "Domicilio";
            // 
            // Paciente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbDomicilio);
            Controls.Add(lbTelefono);
            Controls.Add(lbFechaDeNacimiento);
            Controls.Add(lbNombre);
            Controls.Add(txtDomicilio);
            Controls.Add(txtTelefono);
            Controls.Add(dtpFechaDeNacimiento);
            Controls.Add(txtNombre);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(dgvPaciente);
            Name = "Paciente";
            Text = "Paciente";
            ((System.ComponentModel.ISupportInitialize)dgvPaciente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPaciente;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnEliminar;
        private TextBox txtNombre;
        private DateTimePicker dtpFechaDeNacimiento;
        private TextBox txtTelefono;
        private TextBox txtDomicilio;
        private Label lbNombre;
        private Label lbFechaDeNacimiento;
        private Label lbTelefono;
        private Label lbDomicilio;
    }
}