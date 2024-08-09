using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HospitalPractica
{
    public partial class Paciente : Form
    {
        private readonly BaseDeDatos db = new BaseDeDatos();
        public Paciente()
        {
            InitializeComponent();
            //LoadPacientes();
        }

        private void dgvPacientes(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Paciente_Load(object sender, EventArgs e)
        {

        }

        //private void LoadPacientes()
        //{
        //    string query = "SELECT * FROM Paciente";
        //    DataTable pacientes = db.ExecuteQuery(query);
        //    dgvPacientes.DataSource = pacientes;
        //}

    }
}
