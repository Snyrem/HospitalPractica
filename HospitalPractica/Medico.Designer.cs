namespace HospitalPractica
{
    partial class Medico
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
            dgvMedicos = new DataGridView();
            cmbDepartamento = new ComboBox();
            lbDepartamentos = new Label();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            txtNombre = new TextBox();
            lbNombreDepartmaneto = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvMedicos).BeginInit();
            SuspendLayout();
            // 
            // dgvMedicos
            // 
            dgvMedicos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMedicos.Location = new Point(37, 56);
            dgvMedicos.Name = "dgvMedicos";
            dgvMedicos.Size = new Size(321, 248);
            dgvMedicos.TabIndex = 0;
            dgvMedicos.CellContentClick += dgvMedicos_CellContentClick;
            // 
            // cmbDepartamento
            // 
            cmbDepartamento.FormattingEnabled = true;
            cmbDepartamento.Location = new Point(543, 196);
            cmbDepartamento.Name = "cmbDepartamento";
            cmbDepartamento.Size = new Size(121, 23);
            cmbDepartamento.TabIndex = 1;
            cmbDepartamento.SelectedIndexChanged += cmbDepartamento_SelectedIndexChanged;
            // 
            // lbDepartamentos
            // 
            lbDepartamentos.AutoSize = true;
            lbDepartamentos.Location = new Point(393, 199);
            lbDepartamentos.Name = "lbDepartamentos";
            lbDepartamentos.Size = new Size(97, 15);
            lbDepartamentos.TabIndex = 2;
            lbDepartamentos.Text = "Departamento ID";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(471, 281);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(621, 281);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 4;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(50, 394);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(564, 231);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 6;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // lbNombreDepartmaneto
            // 
            lbNombreDepartmaneto.AutoSize = true;
            lbNombreDepartmaneto.Location = new Point(377, 231);
            lbNombreDepartmaneto.Name = "lbNombreDepartmaneto";
            lbNombreDepartmaneto.Size = new Size(149, 15);
            lbNombreDepartmaneto.TabIndex = 7;
            lbNombreDepartmaneto.Text = "Nombre del Departamento";
            lbNombreDepartmaneto.TextAlign = ContentAlignment.TopCenter;
            lbNombreDepartmaneto.Click += lbNombreDepartmaneto_Click;
            // 
            // Medico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbNombreDepartmaneto);
            Controls.Add(txtNombre);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(lbDepartamentos);
            Controls.Add(cmbDepartamento);
            Controls.Add(dgvMedicos);
            Name = "Medico";
            Text = "Medico";
            ((System.ComponentModel.ISupportInitialize)dgvMedicos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvMedicos;
        private ComboBox cmbDepartamento;
        private Label lbDepartamentos;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnEliminar;
        private TextBox txtNombre;
        private Label lbNombreDepartmaneto;
    }
}