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
        //Connect to database
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
                //Taking data from the course form
                string Course_ID = txtcourseid.Text;
                string Name = txtcoursename.Text;
                string Duration = txtcourseduration.Text;
                string NOM = txtcouresNOM.Text;

                //Check if any of the required fields is empty
                if (string.IsNullOrWhiteSpace(Course_ID) || string.IsNullOrWhiteSpace(Name) ||
                    string.IsNullOrWhiteSpace(Duration) || string.IsNullOrWhiteSpace(NOM))
                {
                    MessageBox.Show("Please fill in all the required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // exit the method without executing the SQL query
                }

                // Open the SQL connection
                con.Open();

                // Check if the course ID already exists in the database
                string check_query = "SELECT COUNT(*) FROM Course WHERE Course_ID = @CourseID;";
                using (SqlCommand checkCmd = new SqlCommand(check_query, con))
                {
                    checkCmd.Parameters.AddWithValue("@CourseID", Course_ID);
                    int existingCourseCount = Convert.ToInt32(checkCmd.ExecuteScalar());
                    if (existingCourseCount > 0)
                    {
                        MessageBox.Show("Unable to proceed. The Course ID provided already exists in the database.", "Duplicate Course ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return; // exit the method without executing the SQL query
                    }
                }

                // SQL Query
                string insert_query = "INSERT INTO Course VALUES (@CourseID, @Name, @Duration, @NOM);";

                // SQL Command
                using (SqlCommand cmd = new SqlCommand(insert_query, con))
                {
                    // Add parameters
                    cmd.Parameters.AddWithValue("@CourseID", Course_ID);
                    cmd.Parameters.AddWithValue("@Name", Name);
                    cmd.Parameters.AddWithValue("@Duration", Duration);
                    cmd.Parameters.AddWithValue("@NOM", NOM);

                    // Execute the command
                    cmd.ExecuteNonQuery();

                    //MessageBox with success icon
                    MessageBox.Show("Course details successfully added. Thank you.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                //MessageBox with error icon and detailed error message
                MessageBox.Show("An error occurred while processing the operation: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                //Get the Course_ID for deletion
                string Course_ID = txtcourseid.Text.Trim();

                //Check if the Course_ID is empty
                if (string.IsNullOrWhiteSpace(Course_ID))
                {
                    MessageBox.Show("Please enter a Course ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; //Exit the method if Course_ID is empty
                }

                //Check if the record exists
                bool recordExists = false;
                con.Open();
                string checkQuery = "SELECT COUNT(*) FROM Course WHERE Course_ID = @Course_ID";
                using (SqlCommand checkCmd = new SqlCommand(checkQuery, con))
                {
                    checkCmd.Parameters.AddWithValue("@Course_ID", Course_ID);
                    int count = (int)checkCmd.ExecuteScalar();
                    recordExists = (count > 0);
                }

                if (!recordExists)
                {
                    MessageBox.Show("Record with provided Course ID does not exist.", "Invalid Course ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Check if there are associated records in the student table
                bool hasStudents = false;
                string checkStudentQuery = "SELECT COUNT(*) FROM Student WHERE CourseID = @CourseID";
                using (SqlCommand checkStudentCmd = new SqlCommand(checkStudentQuery, con))
                {
                    checkStudentCmd.Parameters.AddWithValue("@CourseID", Course_ID);
                    int studentCount = (int)checkStudentCmd.ExecuteScalar();
                    hasStudents = (studentCount > 0);
                }

                // Check if there are associated records in the lecturer table
                bool hasLecturers = false;
                string checkLecturerQuery = "SELECT COUNT(*) FROM Lecturer WHERE Course_ID = @CourseID";
                using (SqlCommand checkLecturerCmd = new SqlCommand(checkLecturerQuery, con))
                {
                    checkLecturerCmd.Parameters.AddWithValue("@CourseID", Course_ID);
                    int lecturerCount = (int)checkLecturerCmd.ExecuteScalar();
                    hasLecturers = (lecturerCount > 0);
                }

                con.Close();

                //If there are associated records in either student or lecturer table, display a warning message
                if (hasStudents || hasLecturers)
                {
                    MessageBox.Show("Cannot delete the course because there are associated records in the student or lecturer table.", "Cannot Delete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                //Confirm deletion with the user
                DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                //If user clicks Yes, proceed with deletion
                if (result == DialogResult.Yes)
                {
                    con.Open();

                    //SQL DELETE Query
                    string delete_query = "DELETE FROM Course WHERE Course_ID = @CourseID";

                    //SQL Command
                    using (SqlCommand cmd = new SqlCommand(delete_query, con))
                    {
                        cmd.Parameters.AddWithValue("@CourseID", Course_ID);
                        //Execute the command
                        cmd.ExecuteNonQuery();
                    }

                    //MessageBox for successful deletion with information icon
                    MessageBox.Show("Deletion completed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    //User clicked No or closed the confirmation box, show message with warning icon
                    MessageBox.Show("Deletion canceled by user.", "Canceled", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                // MessageBox with error icon and detailed error message
                MessageBox.Show($"An error occurred during the deletion process: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                //Taking data from course form
                string Course_ID = txtcourseid.Text;
                string Name = txtcoursename.Text;
                string Duration = txtcourseduration.Text;
                string NOM = txtcouresNOM.Text;

                //Check if any of the required fields is empty
                if (string.IsNullOrWhiteSpace(Name) || string.IsNullOrWhiteSpace(Duration) || string.IsNullOrWhiteSpace(NOM))
                {
                    MessageBox.Show("Please fill in all the required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Exit the method without executing the SQL query
                }

                //Open the connection
                con.Open();

                //SQL query
                string update_query = "UPDATE Course SET Name = '" + Name + "', Duration = '" + Duration + "', NOM = '" + NOM + "' WHERE Course_ID = '" + Course_ID + "';";

                //SQL command
                using (SqlCommand cmd = new SqlCommand(update_query, con))
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Course data updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred during the update process: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtcourseid.Clear();
            txtcoursename.Clear();
            txtcourseduration.Clear();
            txtcouresNOM.Clear();
        }

        private void btnshowall_Click(object sender, EventArgs e)
        {
            try
            {
                string selectall_query = "SELECT * FROM Course ";
                SqlDataAdapter C = new SqlDataAdapter(selectall_query, con);
                DataSet ds = new DataSet();

                // Open the SQL connection
                con.Open();

                // Fill the DataSet
                C.Fill(ds, "Course");

                // Close the SQL connection
                con.Close();

                // Display the data in the DataGridView
                datagridcourse.DataSource = ds.Tables["Course"];
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while retrieving data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            try
            {
                string Course_ID = txtcourseid.Text;

                //Check if the Course_ID is empty
                if (string.IsNullOrWhiteSpace(Course_ID))
                {
                    MessageBox.Show("Please enter a Course ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Exit the method if Course_ID is empty
                }

                string select_query = "SELECT * FROM Course WHERE Course_ID = '" + Course_ID + "'";
                SqlDataAdapter cs = new SqlDataAdapter(select_query, con);
                DataSet ds = new DataSet();

                //Open the SQL connection
                con.Open();

                //Fill the DataSet
                cs.Fill(ds, "Course");

                //Close the SQL connection
                con.Close();

                //Check if any rows were returned
                if (ds.Tables["Course"].Rows.Count > 0)
                {
                    //Display the search results in the DataGridView
                    datagridcourse.DataSource = ds.Tables["Course"];
                }
                else
                {
                    MessageBox.Show("No records found for the specified Course ID.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Clear the DataGridView
                    datagridcourse.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while searching: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void datagridcourse_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //Check if the clicked cell is within a valid row
                if (e.RowIndex >= 0 && datagridcourse.SelectedRows.Count > 0)
                {
                    //Fill the text boxes with data from the selected row
                    txtcourseid.Text = datagridcourse.SelectedRows[0].Cells[0].Value.ToString();
                    txtcoursename.Text = datagridcourse.SelectedRows[0].Cells[1].Value.ToString();
                    txtcourseduration.Text = datagridcourse.SelectedRows[0].Cells[2].Value.ToString();
                    txtcouresNOM.Text = datagridcourse.SelectedRows[0].Cells[3].Value.ToString();
                }
                else
                {
                    //Inform the user to select the full row
                    MessageBox.Show("Please select the full row to fill the text.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                //Display any exception that might occur
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
