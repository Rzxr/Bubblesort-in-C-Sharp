using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bubblesort
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Raz", 32);
            Student s2 = new Student("Jake", 99);
            Student s3 = new Student("Bert", 12);

            int num = Student.sList.Count;
            Console.WriteLine(num.ToString());

            Console.WriteLine("Would you like to sort by age or name: (Type a or n) ");
            string choice = Console.ReadLine();
            bubblesort(num, choice);
            printList();
        }

        public static void printList()
        {
            foreach (Student s in Student.sList)
            {
                Console.WriteLine(s.name + " " + s.age.ToString());
            }
            Console.ReadLine();
        }

        public static void bubblesort(int n, string c) 
        {
            Student temp;
            bool swaps = false;
            if (c == "a")
            {
                for (int i = 0; i < n - 1; i++)
                {
                    swaps = false;

                    for (int j = 0; j < n - 1; j++)
                    {
                        if (Student.sList[j].age > Student.sList[j + 1].age)
                        {
                            temp = Student.sList[j + 1];
                            Student.sList[j + 1] = Student.sList[j];
                            Student.sList[j] = temp;
                            swaps = true;
                        }
                    }

                    if (swaps == false)
                    {
                        printList();
                        break;
                    }
                }
            }

            if (c == "n")
            {
                for (int i = 0; i < n - 1; i++)
                {
                    swaps = false;

                    for (int j = 0; j < n - 1; j++)
                    {
                        int x = Student.sList[j].name.CompareTo(Student.sList[j + 1].name);

                        if (x == 1)
                        {
                            temp = Student.sList[j + 1];
                            Student.sList[j + 1] = Student.sList[j];
                            Student.sList[j] = temp;
                            swaps = true;
                        }
                    }
                    if (swaps == false)
                    {
                        printList();
                        break;
                    }
                }
            }
        }
    }
}
