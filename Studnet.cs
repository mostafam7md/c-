using System;
using System.Collections.Generic;
using System.Text;

namespace FacultyProject
{
   partial class Student:Person
    {
        public static List<Student> storeStudent = new List<Student>();
        private double Gpa;
        public double gpa
        {
            set
            {
                if (value > 4)
                {
                    Gpa = 4;
                }
                else if (value < 0)
                {
                    Gpa = 0;
                }
                else { Gpa = value; }
            }
            get
            {
                return Gpa;
            }
        }
        private String Department;
        public String department { get; set; }
       
        public override string ToString()
        {
            return "Name : " + Name + " Age : " + Age + " Gender : " + Gender + " Gpa : " + gpa;
        }
        public static bool operator ==(Student s1, Student s2)
        {
            return s1.Name == s2.Name && s1.Age == s2.Age && s1.Gender == s2.Gender &&s1.gpa==s2.gpa;
        }
        public static bool operator !=(Student s1, Student s2)
        {
            return s1.Name == s2.Name && s1.Age == s2.Age && s1.Gender == s2.Gender && s1.gpa==s2.gpa;
        }
        public static void addStudent()
        {
            try
            {
                Student StudentAdded = new Student();
                Console.WriteLine("Enter the Name of the Student ");
                StudentAdded.Name = Console.ReadLine();
                Console.WriteLine("Enter the Age of the Student ");
                StudentAdded.Age = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Enter the Department of the Student ");
                StudentAdded.Department = Console.ReadLine();
                Console.WriteLine("Enter the GPA of the Student ");
                StudentAdded.gpa = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the ID of the Student ");
                StudentAdded.ID = Int32.Parse(Console.ReadLine());
            }
            catch { Console.WriteLine("Error in data type"); }
        }
        public static void ShowStudents()
        {
            foreach (Student s in storeStudent)
                Console.WriteLine(s);
        }
        public static void RemoveStudent()
        {
            Console.WriteLine("Enter the ID of Student you want to remove ");
            int x = Int32.Parse(Console.ReadLine());
            foreach(Student s in storeStudent)
                if (x == s.ID)
                {
                    storeStudent.Remove(s);
                }
        }
        public static void CSDeaprtment(){
            foreach (Student s in storeStudent)
            {
                if (s.Department.ToUpper() == "CS")
                {
                    Console.WriteLine(s);
                }
            }
        } //return students in cs department


    }
    partial class Student : IComparable<Student>
    {
        public int CompareTo(Student other)
        {
            return string.CompareOrdinal(Name, other.Name) ;
        }
    } // compare by name 
}
