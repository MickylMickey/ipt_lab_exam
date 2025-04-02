using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ipt_lab_exam
{
    public partial class Student_Page : Form
    {
        private string connectionString = "Server=localhost;Database=studentdb;Uid=root;Pwd=12345;";

        public Student_Page()
        {
            InitializeComponent();
            LoadStudentData();
        }

        private void LoadStudentData()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT studentId, CONCAT(firstName, ' ', lastName) AS fullName FROM studentrecordtb";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                DataTable studentTable = new DataTable();
                adapter.Fill(studentTable);

                dataGridView1.DataSource = studentTable;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["viewButton"].Index && e.RowIndex >= 0)
            {
                int studentId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["studentId"].Value);
                StudentPage_Individual studentPageIndividual = new StudentPage_Individual(studentId);
                studentPageIndividual.Show();
            }
        }
    }
}
