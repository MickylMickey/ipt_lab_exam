using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ipt_lab_exam
{
    public partial class StudentPage_Individual : Form
    {
        private int studentId;
        private string connectionString = "Server=localhost;Database=studentdb;Uid=root;Pwd=12345;";

        public StudentPage_Individual(int studentId)
        {
            this.studentId = studentId;
            InitializeComponent();
        }

        private void StudentPage_Individual_Load(object sender, EventArgs e)
        {
            LoadStudentDetails(studentId);
        }

        private void LoadStudentDetails(int studentId)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM studentrecordtb WHERE studentId = @studentId";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@studentId", studentId);

                MySqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    labelName.Text = "Full Name: " + reader["firstName"] + " " + reader["lastName"];
                    labelAddress.Text = "Address: " + reader["houseNo"] + ", " + reader["brgyName"] + ", " + reader["municipality"];
                    labelContact.Text = "Contact No: " + reader["studContactNo"];
                }
                else
                {
                    MessageBox.Show("Student not found.");
                }
            }
        }
    }
}
