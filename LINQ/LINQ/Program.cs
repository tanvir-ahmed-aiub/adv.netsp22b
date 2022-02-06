using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void PrintArray(List<Student> students)
        {
            foreach(var s in students)
            {
                s.Show();
            }
        }
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            Random rand = new Random();
            for (int i = 0; i < 1000; i++)
            {
                Student s = new Student();
                s.Name = "Student " + (i + 1);
                s.Id = (i + 1);
                
                s.Cgpa = rand.NextDouble()*(4.00 - 2.00) + 2.00;
                students.Add(s);

            }

            var filteredStudent = (from s in students 
                                   where s.Cgpa >= 3.75 &&
                                   (s.Id >= 1 && s.Id <=100 ||
                                   s.Id >=901 && s.Id <=1000)
                                   select s).ToList();
            PrintArray(filteredStudent);

            int[] arr = { 1, 2, 67, 54, 32, 23, 100, 50, 55 };
            var filteredd = (from i in arr where i > 20 select i).ToList();
            //Console.ReadLine();

        }
    }
}
