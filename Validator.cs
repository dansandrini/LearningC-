using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;



// Danilo Testa Sandrini
// Final Exam
// 19/12/2023

namespace Danilo_FinalExam
{
    public static class Validator
    {
        public static bool ValidateStudent(string student)
        {
            Regex regex = new Regex(@"^.+$");
            return regex.IsMatch(student);
        }

        public static bool ValidateYear(string year)
        {
            Regex regex = new Regex(@"^202[0-9]$");
            return regex.IsMatch(year);
        }

        public static bool ValidateSession(string session)
        {
            Regex regex = new Regex(@"^(Fall|Winter|Summer)$");
            return regex.IsMatch(session);
        }

        public static bool ValidateNumber(string text)
        {
            Regex regex = new Regex(@"^(\d{1,2}(\.\d)?|100?)$");
            return regex.IsMatch(text);
        }
    }
}
