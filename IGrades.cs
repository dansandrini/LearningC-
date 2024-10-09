using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Danilo Testa Sandrini
// Final Exam
// 19/12/2023


namespace Danilo_FinalExam
{

    public interface IGrades
{
    int Midterm { get; set; }
    int Project { get; set; }
    int FinalGrade { get; set; }

    int CalculateTotal();
    string CalculateLetterGrade();
}


    public class Final : IGrades
    {
        private int midterm;
        private int project;
        private int finalGrade; 

        // Constructors
        public Final()
        {
            // Default constructor
        }

        public Final(int midterm, int project, int finalGrade)
        {
            this.midterm = midterm;
            this.project = project;
            this.finalGrade = finalGrade;
        }

        // Properties
        public int Midterm
        {
            get { return midterm; }
            set { midterm = value; }
        }

        public int Project
        {
            get { return project; }
            set { project = value; }
        }

        public int FinalGrade
        {
            get { return finalGrade; }
            set { finalGrade = value; }
        }

        // Calculate total obtained grade as a number
        public int CalculateTotal()
        {
            return (int)(midterm * 0.3 + project * 0.3 + finalGrade * 0.4);
        }

        // Calculate and return the letter grade
        public string CalculateLetterGrade()
        {
            int total = CalculateTotal();

            if (total >= 90 && total <= 100)
                return "A";
            else if (total >= 80 && total < 90)
                return "B";
            else if (total >= 70 && total < 80)
                return "C";
            else if (total >= 60 && total < 70)
                return "D";
            else if (total >= 0 && total < 60)
                return "F";
            else
                return "NaG";
        }
    }
}
