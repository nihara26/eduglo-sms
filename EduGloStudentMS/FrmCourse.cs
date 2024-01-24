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

                // Check if any of the required fields is empty
                if (string.IsNullOrWhiteSpace(Course_ID) || string.IsNullOrWhiteSpace(Name) ||
                    string.IsNullOrWhiteSpace(Duration) || string.IsNullOrWhiteSpace(NOM))
                {
                    MessageBox.Show("Please fill in all the required fields.");
                    return; // exit the method without executing the SQL query
                }

                // SQL Query
                string insert_query = "INSERT INTO Course VALUES ('" + Course_ID + "','" + Name + "','" + Duration + "','" + NOM + "');";

                // SQL Command
                SqlCommand cmd = new SqlCommand(insert_query, con);

                // Open the SQL connection
                con.Open();

                // Execute the command
                cmd.ExecuteNonQuery();

                // MgBox
                MessageBox.Show("Course details successfully added. Thank you.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while processing the operation: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the Course_ID for deletion
                string Course_ID = txtcourseid.Text;

                // Confirm deletion with the user
                DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // If user clicks Yes, proceed with deletion
                if (result == DialogResult.Yes)
                {
                    // Open the SQL connection
                    con.Open();

                    // SQL DELETE Query
                    string delete_query = "DELETE FROM Course WHERE Course_ID = '" + Course_ID + "';";

                    // SQL Command
                    SqlCommand cmd = new SqlCommand(@delete_query, con);

                    // Execute the command
                    cmd.ExecuteNonQuery();

                    // MessageBox for successful deletion
                    MessageBox.Show("Deletion completed successfully.");
                }
                else
                {
                    // User clicked No or closed the confirmation box
                    MessageBox.Show("Deletion canceled by user.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred during the deletion process: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Close the SQL connection
                con.Close();
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                //taking from data course form
                string Course_ID = txtcourseid.Text;
                string Name = txtcoursename.Text;
                string Duration = txtcourseduration.Text;
                string NOM = txtcouresNOM.Text;

                //open the connection
                con.Open();

                //sql query
                string update_query = "UPDATE Course SET Name = '" + Name + "', Duration = '" + Duration + "', NOM = '" + NOM + "', Course_ID = '" + Course_ID + "' WHERE Course_ID = '" + Course_ID + "';";

                //sqlcommand
                using (SqlCommand cmd = new SqlCommand(update_query, con))
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Course data updated successfully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred during the update process" + ex);
            }
            finally { con.Close(); }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtcourseid.Clear();
            txtcoursename.Clear();
            txtcourseduration.Clear();
            txtcouresNOM.Clear();
        }
    }
}
