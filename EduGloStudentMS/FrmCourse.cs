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

namespace EduGloStudentMS
{
    public partial class FrmCourse : Form
    {
        public FrmCourse()
        {
            InitializeComponent();
        }
        //connect to database
        static string connectionstring = "Data Source=LAPTOP-4R9I0DRP\\SQLEXPRESS;Initial Catalog=StudentManagemntSystem;Integrated Security=True;Encrypt=False";
        SqlConnection con = new SqlConnection(connectionstring);

        private void btnhome_Click(object sender, EventArgs e)
        {
            FrmDashboard D = new FrmDashboard();
            this.Hide();
            D.Show();
        }

        private void FrmCourse_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentManagemntSystemDataSet1.Course' table. You can move, or remove it, as needed.
            this.courseTableAdapter.Fill(this.studentManagemntSystemDataSet1.Course);

        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            try
            {
                //taking from data course form
                string Course_ID = txtcourseid.Text;
                string Name = txtcoursename.Text;
                string Duration = txtcourseduration.Text;
                string NOM = txtcouresNOM.Text;

                //SQL Query
                string insert_query = "INSERT INTO Course VALUES ('" + Course_ID + "','" + Name + "','" + Duration + "','" + NOM + "');";

                //SQL  Command
                SqlCommand cmd = new SqlCommand(insert_query, con);

                //Open the sql connection
                con.Open();

                //execute the command
                cmd.ExecuteNonQuery();

                //mgbox
                MessageBox.Show("Course details successfully added. Thank you.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while processing the operation." + ex);
            }
            finally { con.Close(); }
        }
    }
}
