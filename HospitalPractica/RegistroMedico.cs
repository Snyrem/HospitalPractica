using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalPractica
{
    public partial class RegistroMedico : Form
    {
        private readonly BaseDatos db = new BaseDatos();

        public RegistroMedico()
        {
            InitializeComponent();
            LoadRegistroMedico();
            LoadPaciente();
        }

        private void LoadRegistroMedico()
        {
            string query = "SELECT * FROM RegistroMedico";
            DataTable RegistroMedico = db.ExecuteQuery(query);
            dgvRegistroMedico.DataSource = RegistroMedico;
        }

        private void LoadPaciente()
        {
            string query = "SELECT PacienteID, Nombre FROM Paciente";
            DataTable Paciente = db.ExecuteQuery(query);
            cmbPaciente.DataSource = Paciente;
            cmbPaciente.DisplayMember = "Nombre";
            cmbPaciente.ValueMember = "PacienteID";
        }

        private void LoadMedico()
        {
            {
                string query = "SELECT MedicoID, Nombre FROM Medico";
                DataTable Medico = db.ExecuteQuery(query);
                cmbMedico.DataSource = Medico;
                cmbMedico.DisplayMember = "Nombre";
                cmbMedico.ValueMember = "MedicoID";
            }


        }

        private void dgvRegistroMedico_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbPaciente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbMedico_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO RegistroMedico (PacienteID, Fecha, Descripcion) VALUES (@PacienteID, @Fecha, @Descripcion)";
            SqlParameter[] parameters =
            {
                new SqlParameter("@MedicoID", cmbMedico.SelectedValue),
                new SqlParameter("@PacienteID", cmbPaciente.SelectedValue),
                new SqlParameter("@Fecha", dtpFecha.Value),
                new SqlParameter("@Descripcion", txtDescripcion.Text)
            };

            db.ExecuteNonQuery(query, parameters);
            LoadRegistroMedico();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }
    }
}
