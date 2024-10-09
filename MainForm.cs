using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



// Danilo Testa Sandrini
// Final Exam
// 19/12/2023


namespace Danilo_FinalExam
{
    public partial class MainForm : Form
    {
        public int minYear = 2023;
        public int maxYear = 2025;
        public MainForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (!Validator.ValidateYear(ftx_year.Text.Trim()))
            {

                MessageBox.Show($"Wrong Year: {ftx_year.Text.Trim()}.\nEntry a valid year:\n{minYear} to {maxYear}", "Wrong Year");
                ftx_year.Focus();
            }
            else if (!Validator.ValidateSession(ftx_session.Text.Trim()) || (ftx_session.Text.Trim() != "Fall" && ftx_session.Text.Trim() != "Winter" && ftx_session.Text.Trim() != "Summer"))
            {
                MessageBox.Show($"Wrong Session: {ftx_session.Text.Trim()}.\nEntry a valid session: Fall, Winter, or Summer", "Wrong Session");
                ftx_session.Focus();
            }
        
            else
            {
                Grades obj = new Grades();
                obj.student = ftx_student.Text;
                obj.year = ftx_year.Text;
                obj.session = ftx_session.Text;
                obj.ShowDialog();
            }
        }

        private void fbt_reset_Click(object sender, EventArgs e)
        {
            ftx_student.Text = "Danilo Testa Sandri - 2320014";
            ftx_session.Text = "Fall";
            ftx_year.Text = "2023";
        }

        private void fbt_exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
