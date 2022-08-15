using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace FacultyProject
{    enum PersonGender
    {
        Male,
        Female
    }
    class Person
    {
        private String name;
        public String Name { get; set; }
        private int age;
        public int Age {
            set
            { if (value < 18)
                    Console.WriteLine("the age must be equal or greater than 18");
                else age = value;
            }
            get
            {
                return age;
            }
        }
        private int id;
        public int ID { get; set; }
        public PersonGender Gender { get; set; }

       

        /* public override string ToString()
         {
             return "Name : " + Name + " Age : " + Age+" Gender : "+Gender;
         }
         public List<Person> storePerson = new List<Person>();
         public static void addPerson()
         {
             Person PersonAdded = new Person();
             Console.WriteLine("Enter the Name of the Person ");
             PersonAdded.Name=Console.ReadLine();
             Console.WriteLine("Enter the Age of the Person ");
             PersonAdded.Age = Int32.Parse(Console.ReadLine());

         }
         public static void ShowPersons()
         {
             foreach(Person p in storePerson)
                 Console.WriteLine(p);
         }
         public static void RemovePerson()
         {
             Console.WriteLine("Enter the ID of Person you want to remove ");
             int x = Int32.Parse(Console.ReadLine());
             foreach (Person p in storePerson)
                 if (x == p.ID)
                 {
                     storePerson.Remove(p);
                 }
         }*/
    }
}
