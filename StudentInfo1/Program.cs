using System;
using System.Collections.Generic;

namespace StudentInfo1
{
    class Program
    {
        public static void PrintData(List<StudentInfo> list)
        {
            foreach (var student in list)
            {
                Console.WriteLine("Name : " + student.Name + " Grade : " + student.Grade + " Total : " + student.Total);
            }
        }
        static void Main(string[] args)
        {
            List<StudentInfo> list = new List<StudentInfo>();
            do
            {
                Console.WriteLine("Press c or x to continue and exit");
                char ch = ReadMethod();

                switch (ch)
                {
                    case 'x':
                        Console.ReadLine();
                        Environment.Exit(0);
                        break;

                    case 'c':

                        DataProcess(list);
                        break;

                    default:
                        Console.WriteLine("Here invalid Key Pressed");
                        break;
                }
            } while (true);
        }

        private static char ReadMethod()
        {
            return Convert.ToChar(Console.ReadKey().KeyChar);
        }

        private static void DataProcess(List<StudentInfo> list)
        {
            Console.WriteLine("Enter Student ID :");
            var i = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Student Name :");
            var name = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Enter Math Marks " + name);
            var MathsMark = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Science Marks " + name);
            var ScienceMark = Convert.ToInt32(Console.ReadLine());

            StudentInfo studentInfo = new StudentInfo(i, name, MathsMark, ScienceMark);
            list.Add(studentInfo);
        }
    }
}





