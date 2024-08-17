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
    public partial class Medico : Form
    {
        private readonly BaseDatos db = new BaseDatos();
        public Medico()
        {
            InitializeComponent();
            LoadMedico();
            LoadDepartamento();
        }
        //--------------------------------------------------------------------------------------------------------------------
        //
        //Aqui cargamos nuestra informacion de nuestras tablas de la base de datos que hemos creado anteriormente.
        //
        //--------------------------------------------------------------------------------------------------------------------
        private void LoadMedico()
        {
            string query = "SELECT * FROM Medico";
            DataTable Medico = db.ExecuteQuery(query);
            dgvMedicos.DataSource = Medico;
        }

        private void LoadDepartamento()
        {
            string query = "SELECT DepartamentoID, Nombre FROM Departamento";
            DataTable Departamento = db.ExecuteQuery(query);
            cmbDepartamento.DataSource = Departamento;
            cmbDepartamento.ValueMember = "DepartamentoID";
            cmbDepartamento.DisplayMember = "Nombre";
        }

        private void dgvMedicos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        //--------------------------------------------------------------------------------------------------------------------
        //
        //Con este boton de agregar, registraremos un medico con su respectivo departamento para que al momento de que un paciente
        //tenga que ser revisado por uno pueda detectarse mas organizadamente que departamento le convendria mejor.
        //
        //--------------------------------------------------------------------------------------------------------------------
        {
            string query = "INSERT INTO Medico (DepartamentoID, Nombre) VALUES (@DepartamentoID, @Nombre)";
            SqlParameter[] parameters =
            {
                new SqlParameter("@DepartamentoID", cmbDepartamento.SelectedValue),
                new SqlParameter("@Nombre", txtNombre.Text)
            };

            db.ExecuteNonQuery(query, parameters);
            LoadMedico();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }


        private void txtNombreDepartamento_Click(object sender, EventArgs e)
        {

        }



        /*En esta parte se le asigna el nombre del departamento*/
        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbNombreDepartmaneto_Click(object sender, EventArgs e)
        {

        }

        private void Medico_Load(object sender, EventArgs e)
        {

        }
    }
}
