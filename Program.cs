using System;
using System.Collections.Generic;

namespace Lab02
{
    class Program
    {
        static void Main(string[] args)
        {
            //3 task: (1) create a list student; (2) Enter student's info; (3) stop enter: "end"

            List<Student> lstStudent = new List<Student>(); //(1) create a list student
                                                           
            while(true) {
                //(2) Enter student's info
                Console.Write("Enter student: ");
                string strStudent = Console.ReadLine();
                if(strStudent =="end") 
                {
                    break; //(3) stop
                }
                string[] sliptString = strStudent.Split(" "); //Split " "
                Student objStudent = new Student(sliptString[0], sliptString[1],
                    Convert.ToInt32(sliptString[2]), sliptString[3]);

                int flag = -1;

                foreach (var st in lstStudent)
                {
                    if(st.FirstName == objStudent.FirstName && st.LastName ==
                        objStudent.LastName)
                             break;
                    flag++;
                }
                if (flag < 0)
                    lstStudent.Add(objStudent);
                else
                    lstStudent[flag] = objStudent;
            }
            // 2 task: Enter hometown; write line student
            Console.WriteLine("=================================");
            Console.Write("Enter hometown: ");
            string strhometown = Console.ReadLine();
            foreach (var std in lstStudent)
            {
                //Write line student
                if (std.HomeTown == strhometown)
                    Console.WriteLine($"{std.FirstName} {std.LastName} is {std.Age} year old");
            }
            Console.ReadKey();
        }
    }
}
