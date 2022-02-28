using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bubblesort
{
    class Student
    {
        public string name { get; set; }
        public int age { get; set; }

        public static List<Student> sList= new List<Student>();     


        public Student(string n, int a)
        {
            this.name = n;
            this.age = a;
            sList.Add(this);
        }

        public Student()
        { }
    }



}
