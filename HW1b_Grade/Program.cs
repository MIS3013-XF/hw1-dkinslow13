// HW1b Grade

// Your Name: Dail Kinslow
// Did you seek help ? If yes, specify the helper or web link here: 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1b_Grade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double assignmentWeight = .20;
            double exam1Weight = .15;
            double exam2Weight = .25;
            double finalWeight = .25;
            double participationWeight = .15;

            Console.WriteLine("What is your First Name?");
            string firstName = Console.ReadLine();
            Console.WriteLine("What is your Last Name?");
            string lastName = Console.ReadLine();
            Console.WriteLine("What is your student ID?");
            string studentID = Console.ReadLine();
            Console.WriteLine("What is your overall grade percentage for Assignments?");
            double assignmentAvg = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is your overall grade percentage for Participation?");
            double participationAvg = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is your overall percentage grade for Exam 1?");
            double exam1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is your overall percentage grade for Exam 2?");
            double exam2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is your overall percentage grade for the Final?");
            double final = Convert.ToDouble(Console.ReadLine());

            double totalGrade = (assignmentAvg * assignmentWeight) + (participationAvg * participationWeight) + (exam1 * exam1Weight) + (exam2 * exam2Weight) + (final * finalWeight);


            Console.WriteLine($"{firstName} {lastName} {studentID}, your final grade is " + Math.Round(totalGrade, 2) + "%");

            Console.ReadKey();
        }
    }
}
