using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EduGloStudentMS
{
    public partial class FrmLecturer : Form
    {
        public FrmLecturer()
        {
            InitializeComponent();

            // Clear the ComboBox text to ensure it appears empty initially
            comlectcourses.Text = "";
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

        private void FrmLecturer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentManagemntSystemDataSet2.Lecturer' table. You can move, or remove it, as needed.
            this.lecturerTableAdapter.Fill(this.studentManagemntSystemDataSet2.Lecturer);

            // TODO: This line of code loads data into the 'studentManagemntSystemDataSet4.Course' table. You can move, or remove it, as needed.
            this.courseTableAdapter.Fill(this.studentManagemntSystemDataSet4.Course);
            // TODO: This line of code loads data into the 'studentManagemntSystemDataSet2.Lecturer' table. You can move, or remove it, as needed.
            this.lecturerTableAdapter.Fill(this.studentManagemntSystemDataSet2.Lecturer);
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtlecturerid.Clear();
            txtlecname.Clear();
            txtlecdob.Clear();
            txtlecaddress.Clear();
            txtlectelephone.Clear();
            txtlectureryoe.Clear();
            comlectcourses.SelectedIndex = -1; //Clear ComboBox selection
        }

        private void btnshowall_Click(object sender, EventArgs e)
        {
            try
            {
                string selectall_query = "SELECT * FROM Lecturer ";
                SqlDataAdapter L = new SqlDataAdapter(selectall_query, con);
                DataSet ds = new DataSet();

                //Open the SQL connection
                con.Open();

                //Fill the DataSet
                L.Fill(ds, "Lecturer");

                //Close the SQL connection
                con.Close();

                //Display the data in the DataGridView
                datagridlecturer.DataSource = ds.Tables["Lecturer"];
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while retrieving data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lablCoursename_Click(object sender, EventArgs e)
        {
            //Check if CourseID combo box is not empty
            if (!string.IsNullOrEmpty(comlectcourses.Text))
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
                        cmd.Parameters.AddWithValue("@CourseID", comlectcourses.Text);

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
                //Clear the label if Course combo box is empty
                lablCoursename.Text = "";
            }
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            try
            {
                string Lecturer_ID = txtlecturerid.Text;

                //Check if the Lecturer_ID is empty
                if (string.IsNullOrWhiteSpace(Lecturer_ID))
                {
                    MessageBox.Show("Please enter a Lecturer ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Exit the method if Lecturer_ID is empty
                }

                string select_query = "SELECT * FROM Lecturer WHERE Lecturer_ID = '" + Lecturer_ID + "'";
                SqlDataAdapter cs = new SqlDataAdapter(select_query, con);
                DataSet ds = new DataSet();

                //Open the SQL connection
                con.Open();

                //Fill the DataSet
                cs.Fill(ds, "Lecturer");

                //Close the SQL connection
                con.Close();

                //Check if any rows were returned
                if (ds.Tables["Lecturer"].Rows.Count > 0)
                {
                    //Display the search results in the DataGridView
                    datagridlecturer.DataSource = ds.Tables["Lecturer"];
                }
                else
                {
                    MessageBox.Show("No records found for the specified Lecturer ID.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Clear the DataGridView
                    datagridlecturer.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while searching: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            try
            {
                // Taking data from the Lecturer form
                string Lecturer_ID = txtlecturerid.Text;
                string Name = txtlecname.Text;
                string DOB = txtlecdob.Text;
                string Address = txtlecaddress.Text;
                string TeleNo = txtlectelephone.Text;
                string YOE = txtlectureryoe.Text;
                string Course_ID = comlectcourses.Text;

                // Check if any of the required fields is empty
                if (string.IsNullOrWhiteSpace(Lecturer_ID) || string.IsNullOrWhiteSpace(Name) ||
                    string.IsNullOrWhiteSpace(DOB) || string.IsNullOrWhiteSpace(Address) ||
                    string.IsNullOrWhiteSpace(TeleNo) || string.IsNullOrWhiteSpace(YOE) || string.IsNullOrWhiteSpace(Course_ID))
                {
                    MessageBox.Show("Please fill in all the required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // exit the method without executing the SQL query
                }

                // Open the SQL connection
                con.Open();

                // Check if the Lecturer ID already exists in the database
                string check_query = "SELECT COUNT(*) FROM Lecturer WHERE Lecturer_ID = @LecturerID;";
                using (SqlCommand checkCmd = new SqlCommand(check_query, con))
                {
                    checkCmd.Parameters.AddWithValue("@LecturerID", Lecturer_ID);
                    int existingStudentCount = Convert.ToInt32(checkCmd.ExecuteScalar());
                    if (existingStudentCount > 0)
                    {
                        MessageBox.Show("Unable to proceed. The Lecturer ID provided already exists in the database.", "Duplicate Lecturer ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return; // exit the method without executing the SQL query
                    }
                }

                //SQL Query
                string insert_query = "INSERT INTO Lecturer VALUES ('" + Lecturer_ID + "','" + Name + "','" + DOB + "','" + Address + "','" + TeleNo + "','"+ YOE +"','" + Course_ID + "');";

                // SQL command
                using (SqlCommand cmd = new SqlCommand(insert_query, con))
                {
                    // Add parameters
                    cmd.Parameters.AddWithValue("@LecturerID", Lecturer_ID);
                    cmd.Parameters.AddWithValue("@Name", Name);
                    cmd.Parameters.AddWithValue("@DOB", DOB);
                    cmd.Parameters.AddWithValue("@Address", Address);
                    cmd.Parameters.AddWithValue("@TeleNo", TeleNo);
                    cmd.Parameters.AddWithValue("@YOE", YOE);
                    cmd.Parameters.AddWithValue("@CourseID", Course_ID);

                    // Execute the command
                    cmd.ExecuteNonQuery();

                    // MessageBox with success icon
                    MessageBox.Show("Lecturer details successfully added. Thank you.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                //Taking data from Lecturer form
                string Lecturer_ID = txtlecturerid.Text;
                string Name = txtlecname.Text;
                // Properly format the date or set to null if empty
                string DOB = string.IsNullOrWhiteSpace(txtlecdob.Text) ? null : DateTime.ParseExact(txtlecdob.Text, "yyyy-MM-dd", CultureInfo.InvariantCulture).ToString("yyyy-MM-dd");
                string Address = txtlecaddress.Text;
                string TeleNo = txtlectelephone.Text;
                string YOE = txtlectureryoe.Text;
                string Course_ID = comlectcourses.Text;

                // Check if any of the required fields is empty
                if (string.IsNullOrWhiteSpace(Lecturer_ID) || string.IsNullOrWhiteSpace(Name) ||
                    string.IsNullOrWhiteSpace(DOB) || string.IsNullOrWhiteSpace(Address) ||
                    string.IsNullOrWhiteSpace(TeleNo) || string.IsNullOrWhiteSpace(YOE) || string.IsNullOrWhiteSpace(Course_ID))
                {
                    MessageBox.Show("Please fill in all the required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Exit the method without executing the SQL query
                }

                //Open the connection
                con.Open();

                //SQL query
                string update_query = "UPDATE Lecturer SET Name = @Name, DOB = @DOB, Address = @Address, TeleNo = @TeleNo, YOE = @YOE, Course_ID = @CourseID WHERE Lecturer_ID = @LecturerID;";

                //SQL command
                using (SqlCommand cmd = new SqlCommand(update_query, con))
                {
                    // Add parameters
                    cmd.Parameters.AddWithValue("@LecturerID", Lecturer_ID);
                    cmd.Parameters.AddWithValue("@Name", Name);
                    cmd.Parameters.AddWithValue("@DOB", DOB);
                    cmd.Parameters.AddWithValue("@Address", Address);
                    cmd.Parameters.AddWithValue("@TeleNo", TeleNo);
                    cmd.Parameters.AddWithValue("@YOE", YOE);
                    cmd.Parameters.AddWithValue("@CourseID", Course_ID);

                    //Execute the command
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Lecturer data updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void datagridlecturer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //Check if the clicked cell is within a valid row
                if (e.RowIndex >= 0 && datagridlecturer.SelectedRows.Count > 0)
                {
                    //Fill the text boxes with data from the selected row
                    txtlecturerid.Text = datagridlecturer.SelectedRows[0].Cells[0].Value.ToString();
                    txtlecname.Text = datagridlecturer.SelectedRows[0].Cells[1].Value.ToString();

                    //Format DOB properly
                    txtlecdob.Text = Convert.ToDateTime(datagridlecturer.SelectedRows[0].Cells[2].Value).ToString("yyyy-MM-dd");

                    txtlecaddress.Text = datagridlecturer.SelectedRows[0].Cells[3].Value.ToString();
                    txtlectelephone.Text = datagridlecturer.SelectedRows[0].Cells[4].Value.ToString();
                    txtlectureryoe.Text = datagridlecturer.SelectedRows[0].Cells[5].Value.ToString();
                    comlectcourses.Text = datagridlecturer.SelectedRows[0].Cells[6].Value.ToString();

                    //Fetch and display the corresponding Course Name based on Course ID
                    string courseId = comlectcourses.Text;

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

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                //Get the Lecturer_ID for deletion
                string Lecturer_ID = txtlecturerid.Text;

                //Check if the Lecturer_ID is empty
                if (string.IsNullOrWhiteSpace(Lecturer_ID))
                {
                    MessageBox.Show("Please enter a Lecturer ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Exit the method if Lecturer_ID is empty
                }

                //Check if the given Lecturer_ID exists in the database
                bool lecturerExists = false;
                con.Open();
                string check_query = "SELECT COUNT(*) FROM Lecturer WHERE Lecturer_ID = @LecturerID;";
                using (SqlCommand checkCmd = new SqlCommand(check_query, con))
                {
                    checkCmd.Parameters.AddWithValue("@LecturerID", Lecturer_ID);
                    int existingLecturerCount = Convert.ToInt32(checkCmd.ExecuteScalar());
                    lecturerExists = existingLecturerCount > 0;
                }
                con.Close();

                //If the Lecturer does not exist, shows a warning message
                if (!lecturerExists)
                {
                    MessageBox.Show("The Lecturer ID does not exist in the database. Deletion cannot be performed.", "Invalid Lecturer ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                //Confirm deletion with the user
                DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // If user clicks Yes, proceed with deletion
                if (result == DialogResult.Yes)
                {
                    con.Open();

                    // SQL DELETE Query
                    string delete_query = "DELETE FROM Lecturer WHERE Lecturer_ID = @LecturerID;";

                    // SQL Command
                    SqlCommand cmd = new SqlCommand(delete_query, con);
                    cmd.Parameters.AddWithValue("@LecturerID", Lecturer_ID);

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

