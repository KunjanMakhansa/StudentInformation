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
                Console.WriteLine( "Name : "+student.Name +" Grade : "+student.Grade +" Total : "+student.Total);
            }
        }
        static void Main(string[] args)
        {
            List<StudentInfo> list=new List<StudentInfo>();

            int i, total, MathsMark, ScienceMark;
            string name;

            do
            {
                Console.WriteLine("Press c or x to continue and exit");

                var ch = Convert.ToChar(Console.ReadKey().KeyChar);

                if (!(ch.Equals('x') || ch.Equals('c')))
                {
                    Console.WriteLine("Invalid Key Pressed");
                }

                else if (ch.Equals('x'))
                {
                    if (list.Count > 0)
                    {
                        PrintData(list);
                    }
                    Console.ReadLine();
                    Environment.Exit(0);
                }

                else
                {
                    Console.WriteLine("Enter Student ID :");
                    i = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter Student Name :");
                    name = Convert.ToString(Console.ReadLine());

                    Console.WriteLine("Enter Maths Mark " + name);
                    MathsMark = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter Science Mark " + name);
                    ScienceMark = Convert.ToInt32(Console.ReadLine());

                    total = MathsMark + ScienceMark;
                    char grade;

                    StudentInfo s=new StudentInfo(i,name,MathsMark, ScienceMark);
                    list.Add(s);
                }
            } while (true);
        }
    }
}





