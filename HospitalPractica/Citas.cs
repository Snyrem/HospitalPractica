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
    public partial class Citas : Form
    {
        private readonly BaseDatos db = new BaseDatos();
        public Citas()
        {
            InitializeComponent();
            LoadCitas();
            LoadPacientes();
            LoadMedicos();
        }
 
        //--------------------------------------------------------------------------------------------------------------------
        //
        //Aqui cargamos nuestra informacion de nuestras tablas de la base de datos que hemos creado anteriormente para hacerla 
        //interactuar con nuestro codigo form Citas, que se encargara de agrar una cita con un paciente y medico.
        //
        //--------------------------------------------------------------------------------------------------------------------

        private void LoadCitas()
        {
            string query = "SELECT * FROM Cita";
            DataTable Cita = db.ExecuteQuery(query);
            dgvCitas.DataSource = Cita;
        }

        private void LoadPacientes()
        {
            string query = "SELECT PacienteID, Nombre FROM Paciente";
            DataTable Paciente = db.ExecuteQuery(query);
            cmbPaciente.DataSource = Paciente;
            cmbPaciente.DisplayMember = "Nombre";
            cmbPaciente.ValueMember = "PacienteID";
        }

        private void LoadMedicos()
        {
            string query = "SELECT MedicoID, Nombre FROM Medico";
            DataTable Medico = db.ExecuteQuery(query);
            cmbMedico.DataSource = Medico;
            cmbMedico.DisplayMember = "Nombre";
            cmbMedico.ValueMember = "MedicoID";
        }

        private void dgvCitas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbMedico_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbPaciente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        //--------------------------------------------------------------------------------------------------------------------
        //
        //Este se boton se encarga de agregar los valores que selecciones a una cita para que quede registrada en una
        //tabla dentro de nuestra base de datos.
        //
        //--------------------------------------------------------------------------------------------------------------------
        {

            string query = "INSERT INTO Cita (PacienteID, MedicoID, Fecha, Motivo) VALUES (@PacienteID, @MedicoID, @FechaHora";
            SqlParameter[] parameters =
            {
                new SqlParameter("@PacienteID", cmbPaciente.SelectedValue),
                new SqlParameter("@MedicoID", cmbMedico.SelectedValue),
                new SqlParameter("@FechaHora", dtpFecha.Value),

            };

            db.ExecuteNonQuery(query, parameters);
            LoadCitas();
        }


        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void Citas_Load(object sender, EventArgs e)
        {

        }
    }
}
