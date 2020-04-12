using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] studentGrades = new string[5, 2];
            int[] average = new int[studentGrades.GetLength(0)];
            studentGrades[0, 0] = "Steve"; 
            studentGrades[0, 1] = "69";

            studentGrades[1, 0] = "Bob";
            studentGrades[1, 1] = "73";

            studentGrades[2, 0] = "Lewis";
            studentGrades[2, 1] = "67";

            studentGrades[3, 0] = "Sara";
            studentGrades[3, 1] = "55";

            studentGrades[4, 0] = "Xavier";
            studentGrades[4, 1] = "22";

            for (int name = 0; name < 5; name++)
            {
                //Console.WriteLine(studentGrades.GetLength(0));
                for (int grade = 0; grade < studentGrades.GetLength(1); grade++)
                {
                    // Console.WriteLine(studentGrades.GetLength(1));
                    Console.WriteLine(studentGrades[name, grade]);
                }
                Console.WriteLine("");
            }
            var min = 100;
            for (int grade = 0; grade < studentGrades.GetLength(1); grade++)
            {
                for (int name = 0; name < 5; name++)
                 {

                //Console.WriteLine(studentGrades.GetLength(0));
                
                    if (min > int.Parse(studentGrades[name, 1]))
                    {
                        min = Int32.Parse(studentGrades[name, 1]);
                    }
                }
            }
            Console.WriteLine("minimum grade is that  " + min);

            var max = 0;
            for (int grade = 0; grade < studentGrades.GetLength(1); grade++)
            {
                for (int name = 0; name < 5; name++)
                {

                    //Console.WriteLine(studentGrades.GetLength(0));

                    if (max < int.Parse(studentGrades[name, 1]))
                    {
                        max = Int32.Parse(studentGrades[name, 1]);
                    }
                }
            }
            Console.WriteLine("maximum grade is that  " + max);


            var total = 0;

            for (int i = 0; i < studentGrades.GetLength(0); i++)
            {
                
                for (int j = 0; j < studentGrades.GetLength(1); j++)
                {
                   
                    total += int.Parse(studentGrades[i, 1]);
                }
               

            }
            Console.WriteLine("average grade is that  " + total / studentGrades.Length);

            Console.ReadLine();
        }
        

    }

  
}
