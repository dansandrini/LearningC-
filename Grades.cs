using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;


// Danilo Testa Sandrini
// Final Exam
// 19/12/2023

namespace Danilo_FinalExam
{
    public partial class Grades : Form
    {
        IGrades grades = new Final();
        FileStream fs = null;
        string dir = @"./Files";
        string fileTxt = "Final.txt";
        string fileXml = "Final.xml";

        public string student;
        public string year;
        public string session;
        public Grades()
        {
            InitializeComponent();
        }

        private void fbt_exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to close the form?\nOK to confirm or Cancel.", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void Grades_Load(object sender, EventArgs e)
        {
            try
            {
                string path = Path.Combine(dir, fileTxt);

                
                if (!string.IsNullOrEmpty(student))
                {
                    string[] studentInfo = student.Split('-');

                    
                    if (studentInfo.Length == 2)
                    {
                        string studentName = studentInfo[0].Trim();
                        string studentNumber = studentInfo[1].Trim();

                        
                        if (!Directory.Exists(dir))
                        {
                            Directory.CreateDirectory(dir);
                            fs = new FileStream(path, FileMode.Create);
                        }
                        else
                        {
                            MessageBox.Show("Invalid student information format.", "Error");
                            this.Close();
                            return; 
                        }

                        Reset();
                    }
                    else
                    {
                        MessageBox.Show("Invalid student information format.", "Error");
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Student information is not provided.", "Error");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error");
                this.Close();
            }
        }


        public void Reset()
        {
            ftx_midterm.Text = "0";
            ftx_project.Text = "0";
            ftx_final.Text = "0";
            ftx_midtermp.Text = "0";
            ftx_projectp.Text = "0";
            ftx_finalp.Text = "0";
            ftx_total.Text = "0";
            ftx_totala.Text = "F";

            ftx_midterm.ReadOnly = false;
            ftx_project.ReadOnly = false;
            ftx_final.ReadOnly = false;

            fbt_validate.Enabled = true;
            fbt_write.Enabled = true;
            fbt_create.Enabled = true;
            fbt_read.Enabled = true;
        }

        private void fbt_reset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void fbt_validate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Validator.ValidateNumber(ftx_midterm.Text.Trim()))
                {
                    MessageBox.Show($"Wrong Midterm grade!\nThe value {ftx_midterm.Text} is not a valid number", "Wrong Grade");
                    ftx_midterm.Focus();
                }
                else
                {
                    grades.Midterm = int.Parse(ftx_midterm.Text.Trim());
                    ftx_midterm.Text = grades.Midterm.ToString();

                    if (!Validator.ValidateNumber(ftx_project.Text.Trim()))
                    {
                        MessageBox.Show($"Wrong Project grade!\nThe value {ftx_project.Text} is not a valid number", "Wrong Grade");
                        ftx_project.Focus();
                    }
                    else
                    {
                        grades.Project = int.Parse(ftx_project.Text.Trim());
                        ftx_project.Text = grades.Project.ToString();

                        if (!Validator.ValidateNumber(ftx_final.Text.Trim()))
                        {
                            MessageBox.Show($"Wrong Final grade!\nThe value {ftx_final.Text} is not a valid number", "Wrong Grade");
                            ftx_final.Focus();
                        }
                        else
                        {
                            grades.FinalGrade = int.Parse(ftx_final.Text.Trim());
                            ftx_final.Text = grades.FinalGrade.ToString();
                            ftx_total.Text = grades.CalculateTotal().ToString();
                            ftx_totala.Text = grades.CalculateLetterGrade();

                            ftx_midtermp.Text = $"{grades.Midterm * 0.3}%";
                            ftx_projectp.Text = $"{grades.Project * 0.3}%";
                            ftx_finalp.Text = $"{grades.FinalGrade * 0.4}%";

                            ftx_midtermp.ReadOnly = true;
                            ftx_projectp.ReadOnly = true;
                            ftx_finalp.ReadOnly = true;

                            fbt_validate.Enabled = false;
                        }
                    }
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show("IO Exception: " + ex.Message, "Exception Error");
            }
        }

        private void fbt_write_Click(object sender, EventArgs e)
        {
            string path = Path.Combine(dir, fileTxt);

            try
            {

                string[] studentInfo = (!string.IsNullOrEmpty(student)) ? student.Split('-') : new string[0];

                if (studentInfo.Length == 2)
                {
                    string studentName = studentInfo[0].Trim();
                    string studentNumber = studentInfo[1].Trim();

                    using (StreamWriter writer = new StreamWriter(path, true))
                    {
                        writer.WriteLine($"{studentName}-{studentNumber}|{year}|{session}|{grades.Midterm}|{grades.Project}|{grades.FinalGrade}|{ftx_midtermp.Text}|{ftx_projectp.Text}|{ftx_finalp.Text}|{ftx_total.Text}|{ftx_totala.Text}");
                    }

                    MessageBox.Show($"Data added to {fileTxt}", "Write to File");

                    fbt_write.Enabled = false;
                }
                else
{
    MessageBox.Show("Invalid student information format. Please provide student information in the format 'Name-Number'.", "Error");
}

            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message, "IOException");
            }
        }

        private void fbt_create_Click(object sender, EventArgs e)
        {
            string pathTxt = Path.Combine(dir, fileTxt);
            string pathXml = Path.Combine(dir, fileXml);

            try
            {
                using (StreamReader textIn = new StreamReader(pathTxt))
                using (XmlWriter xmlOut = XmlWriter.Create(pathXml, new XmlWriterSettings { Indent = true }))
                {
                    xmlOut.WriteStartDocument();
                    xmlOut.WriteStartElement("Grades");

                    while (textIn.Peek() != -1)
                    {
                        string row = textIn.ReadLine();
                        xmlOut.WriteStartElement("Grade");
                        xmlOut.WriteElementString("Info", row);
                        xmlOut.WriteEndElement();
                    }

                    xmlOut.WriteEndElement();
                    xmlOut.WriteEndDocument();
                }

                MessageBox.Show($"XML file created at {fileXml}", "Create XML File");

                fbt_create.Enabled = false;
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message, "IOException");
            }
        }

        private void fbt_read_Click(object sender, EventArgs e)
        {
            string pathXml = Path.Combine(dir, fileXml);

            try
            {
                XmlReaderSettings settings = new XmlReaderSettings();
                settings.IgnoreWhitespace = true;
                settings.IgnoreComments = true;

                XmlReader xmlIn = XmlReader.Create(pathXml, settings);
                string tempStr = "", row = "";

                if (xmlIn.ReadToDescendant("Grade"))
                {
                    do
                    {
                        xmlIn.ReadStartElement("Grade");
                        row = xmlIn.ReadElementContentAsString();
                        tempStr += row + "\n";

                    } while (xmlIn.ReadToNextSibling("Grade"));
                }

                MessageBox.Show(tempStr, "Reading");
                xmlIn.Close();
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message, "IOException");
            }
        }
    }
}
