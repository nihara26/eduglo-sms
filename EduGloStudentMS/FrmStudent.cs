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
using System.Net;
using System.Globalization;

namespace EduGloStudentMS
{
    public partial class FrmStudent : Form
    {
        public FrmStudent()
        {
            InitializeComponent();

            // Clear the ComboBox text to ensure it appears empty initially
            comstucourses.Text = "";
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

        private void FrmStudent_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentManagemntSystemDataSet3.Course' table. You can move, or remove it, as needed.
            this.courseTableAdapter.Fill(this.studentManagemntSystemDataSet3.Course);
            // TODO: This line of code loads data into the 'studentManagemntSystemDataSet.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.studentManagemntSystemDataSet.Student);

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            try
            {
                string Student_ID = txtstudentid.Text;

                //Check if the Course_ID is empty
                if (string.IsNullOrWhiteSpace(Student_ID))
                {
                    MessageBox.Show("Please enter a Student ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Exit the method if Course_ID is empty
                }

                string select_query = "SELECT * FROM Student WHERE Student_ID = '" + Student_ID + "'";
                SqlDataAdapter cs = new SqlDataAdapter(select_query, con);
                DataSet ds = new DataSet();

                //Open the SQL connection
                con.Open();

                //Fill the DataSet
                cs.Fill(ds, "Student");

                //Close the SQL connection
                con.Close();

                //Check if any rows were returned
                if (ds.Tables["Student"].Rows.Count > 0)
                {
                    //Display the search results in the DataGridView
                    datagridstudent.DataSource = ds.Tables["Student"];
                }
                else
                {
                    MessageBox.Show("No records found for the specified Student ID.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Clear the DataGridView
                    datagridstudent.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while searching: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnshowall_Click(object sender, EventArgs e)
        {
            try
            {
                string selectall_query = "SELECT * FROM Student ";
                SqlDataAdapter C = new SqlDataAdapter(selectall_query, con);
                DataSet ds = new DataSet();

                // Open the SQL connection
                con.Open();

                // Fill the DataSet
                C.Fill(ds, "Student");

                // Close the SQL connection
                con.Close();

                // Display the data in the DataGridView
                datagridstudent.DataSource = ds.Tables["Student"];
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while retrieving data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Inserting student details into the database
        private void btninsert_Click(object sender, EventArgs e)
        {
            try
            {
                // Taking data from the course form
                string Student_ID = txtstudentid.Text;
                string Name = txtstuname.Text;
                string DOB = txtstudentdob.Text;
                string Gender = combogender.Text;
                string Address = txtstuaddress.Text;
                string TeleNo = txtstutelephone.Text;
                string CourseID = comstucourses.Text;

                // Check if any of the required fields is empty
                if (string.IsNullOrWhiteSpace(Student_ID) || string.IsNullOrWhiteSpace(Name) ||
                    string.IsNullOrWhiteSpace(DOB) || string.IsNullOrWhiteSpace(Address) ||
                    string.IsNullOrWhiteSpace(TeleNo) || string.IsNullOrWhiteSpace(CourseID) || string.IsNullOrWhiteSpace(Gender))
                {
                    MessageBox.Show("Please fill in all the required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // exit the method without executing the SQL query
                }

                // Open the SQL connection
                con.Open();

                // Check if the student ID already exists in the database
                string check_query = "SELECT COUNT(*) FROM Student WHERE Student_ID = @StudentID;";
                using (SqlCommand checkCmd = new SqlCommand(check_query, con))
                {
                    checkCmd.Parameters.AddWithValue("@StudentID", Student_ID);
                    int existingStudentCount = Convert.ToInt32(checkCmd.ExecuteScalar());
                    if (existingStudentCount > 0)
                    {
                        MessageBox.Show("Unable to proceed. The Student ID provided already exists in the database.", "Duplicate Student ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return; // exit the method without executing the SQL query
                    }
                }

                //SQL Query
                string insert_query = "INSERT INTO Student VALUES ('" + Student_ID + "','" + Name + "','" + DOB + "','" + Gender + "','" + Address + "','" + TeleNo + "','" + CourseID + "');";

                // SQL command
                using (SqlCommand cmd = new SqlCommand(insert_query, con))
                {
                    // Add parameters
                    cmd.Parameters.AddWithValue("@StudentID", Student_ID);
                    cmd.Parameters.AddWithValue("@Name", Name);
                    cmd.Parameters.AddWithValue("@DOB", DOB);
                    cmd.Parameters.AddWithValue("@Gender", Gender);
                    cmd.Parameters.AddWithValue("@Address", Address);
                    cmd.Parameters.AddWithValue("@TeleNo", TeleNo);
                    cmd.Parameters.AddWithValue("@CourseID", CourseID);

                    // Execute the command
                    cmd.ExecuteNonQuery();

                    // MessageBox with success icon
                    MessageBox.Show("Student details successfully added. Thank you.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // MessageBox with error icon and detailed error message
                MessageBox.Show("An error occurred while processing the operation: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtstudentid.Clear();
            txtstuname.Clear();
            txtstudentdob.Clear();
            combogender.SelectedIndex = -1;
            txtstuaddress.Clear();
            txtstutelephone.Clear();
            comstucourses.SelectedIndex = -1; //Clear ComboBox selection

        }

        private void comstucourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Check if CourseID combo box is not empty
            if (!string.IsNullOrEmpty(comstucourses.Text))
            {
                try
                {
                    //Open the SQL connection
                    con.Open();

                    //SQL query to retrieve the Course name based on selected CourseID
                    string select_query = "SELECT Name FROM Course WHERE Course_ID = @CourseID"; // Use the correct column name

                    //SQL command with parameters
                    using (SqlCommand cmd = new SqlCommand(select_query, con))
                    {
                        //Add parameter to the command
                        cmd.Parameters.AddWithValue("@CourseID", comstucourses.Text);

                        //Execute the command and retrieve the Course name
                        object result = cmd.ExecuteScalar();

                        //Display the Course name in the label if not null
                        if (result != null)
                        {
                            lablCoursename.Text = result.ToString();
                        }
                        else
                        {
                            lablCoursename.Text = "Course name not found";
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while retrieving course details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    //Close the SQL connection
                    con.Close();
                }
            }
            else
            {
                //Clear the label if CourseID combo box is empty
                lablCoursename.Text = "";
            }
        }

        private void datagridstudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //Check if the clicked cell is within a valid row
                if (e.RowIndex >= 0 && datagridstudent.SelectedRows.Count > 0)
                {
                    //Fill the text boxes with data from the selected row
                    txtstudentid.Text = datagridstudent.SelectedRows[0].Cells[0].Value.ToString();
                    txtstuname.Text = datagridstudent.SelectedRows[0].Cells[1].Value.ToString();

                    //Format DOB properly
                    txtstudentdob.Text = Convert.ToDateTime(datagridstudent.SelectedRows[0].Cells[2].Value).ToString("yyyy-MM-dd");

                    combogender.Text = datagridstudent.SelectedRows[0].Cells[3].Value.ToString();
                    txtstuaddress.Text = datagridstudent.SelectedRows[0].Cells[4].Value.ToString();
                    txtstutelephone.Text = datagridstudent.SelectedRows[0].Cells[5].Value.ToString();
                    comstucourses.Text = datagridstudent.SelectedRows[0].Cells[6].Value.ToString();

                    //Fetch and display the corresponding Course Name based on Course ID
                    string courseId = comstucourses.Text;

                    //Open the SQL connection
                    con.Open();

                    //SQL query to retrieve the Course name based on selected CourseID
                    string select_query = "SELECT Name FROM Course WHERE Course_ID = @CourseID"; // Use the correct column name

                    //SQL command with parameters
                    using (SqlCommand cmd = new SqlCommand(select_query, con))
                    {
                        //Add parameter to the command
                        cmd.Parameters.AddWithValue("@CourseID", courseId);

                        //Execute the command and retrieve the Course name
                        object result = cmd.ExecuteScalar();

                        //Display the Course name in the label if not null
                        if (result != null)
                        {
                            lablCoursename.Text = result.ToString();
                        }
                        else
                        {
                            lablCoursename.Text = "Course name not found";
                        }
                    }
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
                string Student_ID = txtstudentid.Text;
                string Name = txtstuname.Text;
                // Properly format the date or set to null if empty
                string DOB = string.IsNullOrWhiteSpace(txtstudentdob.Text) ? null : DateTime.ParseExact(txtstudentdob.Text, "yyyy-MM-dd", CultureInfo.InvariantCulture).ToString("yyyy-MM-dd"); 
                string Gender = combogender.Text;
                string Address = txtstuaddress.Text;
                string TeleNo = txtstutelephone.Text;
                string CourseID = comstucourses.Text;

                // Check if any of the required fields is empty
                if (string.IsNullOrWhiteSpace(Student_ID) || string.IsNullOrWhiteSpace(Name) ||
                    string.IsNullOrWhiteSpace(Address) ||
                    string.IsNullOrWhiteSpace(TeleNo) || string.IsNullOrWhiteSpace(CourseID) || string.IsNullOrWhiteSpace(Gender))
                {
                    MessageBox.Show("Please fill in all the required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Exit the method without executing the SQL query
                }

                //Open the connection
                con.Open();

                //SQL query
                string update_query = "UPDATE Student SET Name = @Name, DOB = @DOB, Gender = @Gender, Address = @Address, TeleNo = @TeleNo, CourseID = @CourseID WHERE Student_ID = @StudentID;";

                //SQL command
                using (SqlCommand cmd = new SqlCommand(update_query, con))
                {
                    // Add parameters
                    cmd.Parameters.AddWithValue("@Name", Name);
                    cmd.Parameters.AddWithValue("@DOB", DOB);
                    cmd.Parameters.AddWithValue("@Gender", Gender);
                    cmd.Parameters.AddWithValue("@Address", Address);
                    cmd.Parameters.AddWithValue("@TeleNo", TeleNo);
                    cmd.Parameters.AddWithValue("@CourseID", CourseID);
                    cmd.Parameters.AddWithValue("@StudentID", Student_ID);

                    //Execute the command
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Student data updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the Student_ID for deletion
                string Student_ID = txtstudentid.Text;

                // Check if the Student_ID is empty
                if (string.IsNullOrWhiteSpace(Student_ID))
                {
                    MessageBox.Show("Please enter a Student ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Exit the method if Student_ID is empty
                }

                // Check if the given Student_ID exists in the database
                bool studentExists = false;
                con.Open();
                string check_query = "SELECT COUNT(*) FROM Student WHERE Student_ID = @StudentID;";
                using (SqlCommand checkCmd = new SqlCommand(check_query, con))
                {
                    checkCmd.Parameters.AddWithValue("@StudentID", Student_ID);
                    int existingStudentCount = Convert.ToInt32(checkCmd.ExecuteScalar());
                    studentExists = existingStudentCount > 0;
                }
                con.Close();

                // If the student does not exist, show a warning message
                if (!studentExists)
                {
                    MessageBox.Show("The Student ID does not exist in the database. Deletion cannot be performed.", "Invalid Student ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Confirm deletion with the user
                DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // If user clicks Yes, proceed with deletion
                if (result == DialogResult.Yes)
                {
                    con.Open();

                    // SQL DELETE Query
                    string delete_query = "DELETE FROM Student WHERE Student_ID = @StudentID;";

                    // SQL Command
                    SqlCommand cmd = new SqlCommand(delete_query, con);
                    cmd.Parameters.AddWithValue("@StudentID", Student_ID);

                    // Execute the command
                    cmd.ExecuteNonQuery();

                    // MessageBox for successful deletion with information icon
                    MessageBox.Show("Deletion completed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // User clicked No or closed the confirmation box, show message with warning icon
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
    }
}
  

