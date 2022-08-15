using System;
using System.Collections.Generic;
using System.Text;

namespace FacultyProject
{
    
    class Instructor : Person
    {
        public static List<Instructor> storeInstructor = new List<Instructor>();
        private double salary;
        public double Salary {
            set
            {
                if (value < 0)
                    salary = 0;
                else salary = value;
            }
            get
            {
                return salary;
            }
        }
        
        private String Course { get; set; }
        public override string ToString()
        {
            return "Name : " + Name + " Age : " + Age + " Gender : " + Gender +" Salary : "+Salary+" Course : "+Course;
        }
        public static bool operator ==(Instructor I1, Instructor I2)
        {
            return I1.Name == I2.Name && I1.Age == I2.Age && I1.Gender == I2.Gender && I1.Salary == I2.Salary&&I1.Course==I2.Course;
        }
        public static bool operator !=(Instructor I1, Instructor I2)
        {
            return I1.Name == I2.Name && I1.Age == I2.Age && I1.Gender == I2.Gender && I1.Salary == I2.Salary && I1.Course == I2.Course;
        }
        public static void addInstructor()
        {
            try
            {
                Instructor InstructorAdded = new Instructor();
                Console.WriteLine("Enter the Name of the Instructor ");
                InstructorAdded.Name = Console.ReadLine();
                Console.WriteLine("Enter the Age of the Instructor ");
                InstructorAdded.Age = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Enter the Salary of the Instructor ");
                InstructorAdded.Salary = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the Course of the Instructor ");
                InstructorAdded.Course = Console.ReadLine();
                Console.WriteLine("Enter the ID of the Instructor ");
                InstructorAdded.ID = Int32.Parse(Console.ReadLine());
            }
            catch { Console.WriteLine("Error in data type"); }
        }
        public static void ShowInstructors()
        {
            foreach (Instructor i in storeInstructor)
                Console.WriteLine(i);
        }
        public static void RemoveInstructor()
        {
            Console.WriteLine("Enter the ID of Instructor you want to remove ");
            int x = Int32.Parse(Console.ReadLine());
            foreach (Instructor i  in storeInstructor)
                if (x == i.ID)
                {
                    storeInstructor.Remove(i);
                }
        } 
        public static void top3()
        {
            foreach (Instructor I in storeInstructor)
            {
                I.Sort(new help());
            }   
        }
    }
    class help : IComparer<Instructor>
    {
        public int Compare(Instructor x, Instructor y)
        {
            if (x.Salary < y.Salary)
            {
                return 1;
            }
            else if (x.Salary > y.Salary)
            {
                return -1;
            }
            else return 0;
        }

    }
     
}
