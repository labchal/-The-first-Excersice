using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersices_From_Codewars__8_kuy_
{

    //Create a function finalGrade, which calculates the final grade of a student depending on two parameters: 
    //a grade for the exam and a number of completed projects.
    //This function should take two arguments: exam - grade for exam (from 0 to 100); 
    //projects - number of completed projects (from 0 and above);
    //This function should return a number (final grade). There are four types of final grades:

    //100, if a grade for the exam is more than 90 or if a number of completed projects more than 10.
    //90, if a grade for the exam is more than 75 and if a number of completed projects is minimum 5.
    //75, if a grade for the exam is more than 50 and if a number of completed projects is minimum 2.
    //0, in other cases



    class Program
    {
        


        static void Main(string[] args)
        {
           
          
            Random tixaios = new Random();

            int gradeOfTheExam =  tixaios.Next(0, 100);
            int numOfCompletedProjects = tixaios.Next(0,11);
            int a1 = gradeOfTheExam;
            int a2 = numOfCompletedProjects;
            Console.WriteLine(a1.ToString(), a2.ToString());
            Console.WriteLine();

            int result = 0;
            finalGrade(a1, a2, out result);
        }



        public static void finalGrade(int exam, int projects, out int result)
        {
            if (exam >= 90 || projects > 10)
            {
                 result = 100;
                Console.WriteLine(result);
            }
            else if (exam >= 75 && projects >= 5)
            {
                result = 90;
                Console.WriteLine(result);
            }
            else if (exam >= 50 && projects >= 2)
            {
                result= 75;
                Console.WriteLine(result);
            }
            else
            {
               result = 0;
                Console.WriteLine(result);
            }
        }

    }
}
