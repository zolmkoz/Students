using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }


        /// <summary>
        /// Init a student with paremeter
        /// Date create: 04/10/2021
        /// Author: zolmkoz
        /// </summary>
        /// <param name="fistname"></param>
        /// <param name="lastname"></param>
        /// <param name="age"></param>
        /// <param name="hometown"></param>




        public Student(string fistname, string lastname, int age, string hometown)
        {
            this.FirstName = fistname;
            this.LastName = lastname;
            this.Age = age;
            this.HomeTown = hometown;
        }

    }
}
