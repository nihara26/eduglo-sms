using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace EduGloStudentMS
{
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to Logout? ", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                FrmLogin A = new FrmLogin();
                this.Hide();
                A.Show();
            }
        }

        private void btnstudent_Click(object sender, EventArgs e)
        {
            FrmStudent S = new FrmStudent();
            this.Hide();
            S.Show();
        }

        private void btnlecturer_Click(object sender, EventArgs e)
        {
            FrmLecturer L = new FrmLecturer();
            this.Hide();
            L.Show();
        }

        private void btncourse_Click(object sender, EventArgs e)
        {
            FrmCourse C = new FrmCourse();
            this.Hide();
            C.Show();
        }
    }
}
