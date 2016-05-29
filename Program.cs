using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w4iLabProj
{
    class Program
    {
        static void Main(string[] args)
        {

            string firstName, lastName, letterGrade;
            double studentScore, studentPercent;

            Console.WriteLine("Please enter first name");
            firstName = Console.ReadLine();
            Console.WriteLine("Please enter last name");
            lastName = Console.ReadLine();
            Console.WriteLine("Please enter student score between 0-1000");
            studentScore = Convert.ToInt32(Console.ReadLine());

            studentPercent = studentScore / 1000;

            if (studentScore < 0 || studentScore > 1000)
            {
                Console.WriteLine("bad score");
                System.Threading.Thread.Sleep(1000);
                System.Environment.Exit(1);
            }


            if (studentPercent >= .9)
            {
                letterGrade = "A";
                Console.WriteLine("Your first name is " + firstName + ". Your last name is " + lastName + ". Your score was " + studentScore + ". Your percent is " + studentPercent + ". Your letter grade is " + letterGrade);
            }
            else if (studentPercent >= .8 & studentPercent < .9)
            {
                letterGrade = "B";
                Console.WriteLine("Your first name is " + firstName + ". Your last name is " + lastName + ". Your score was " + studentScore + ". Your percent is " + studentPercent + ". Your letter grade is " + letterGrade);
            }
            else if (studentPercent >= .7 & studentPercent <.8)
            {
                letterGrade = "C";
                Console.WriteLine("Your first name is " + firstName + ". Your last name is " + lastName + ". Your score was " + studentScore + ". Your percent is " + studentPercent + ". Your letter grade is " + letterGrade);
            }
            else if (studentPercent >= .6 & studentPercent <.7)
            {
                letterGrade = "D";
                Console.WriteLine("Your first name is " + firstName + ". Your last name is " + lastName + ". Your score was " + studentScore + ". Your percent is " + studentPercent + ". Your letter grade is " + letterGrade);
            }
            else if (studentPercent < .6)
            {
                letterGrade = "F";
                 
            }
            


                }
                }
}
