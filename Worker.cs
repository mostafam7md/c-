using System;
using System.Collections.Generic;
using System.Text;

namespace FacultyProject
{
    class Worker : Person
    {
        public static List<Worker> storeWorker = new List<Worker>();
        private double Salary
        {
            set
            {
                if (value < 0)
                    Salary = 0;
                else Salary = value;
            }
            get
            {
                return Salary;
            }
        }
        
        public override string ToString()
        {
            return "Name : " + Name + " Age : " + Age + " Gender : " + Gender + " Salary : " + Salary ;
        }
        public static bool operator ==(Worker W1, Worker W2)
        {
            return W1.Name == W2.Name && W1.Age == W2.Age && W1.Gender == W2.Gender && W1.Salary == W2.Salary ;
        }
        public static bool operator !=(Worker W1, Worker W2)
        {
            return W1.Name == W2.Name && W1.Age == W2.Age && W1.Gender == W2.Gender && W1.Salary == W2.Salary;
        }
        public static void addWorker()
        {
            try
            {
                Worker WorkerAdded = new Worker();
                Console.WriteLine("Enter the Name of the Worker ");
                WorkerAdded.Name = Console.ReadLine();
                Console.WriteLine("Enter the Age of the Worker ");
                WorkerAdded.Age = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Enter the Salary of the Worker ");
                WorkerAdded.Salary = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the ID of the Worker ");
                WorkerAdded.ID = Int32.Parse(Console.ReadLine());
            }
            catch { Console.WriteLine("Error in data type"); }
        }
        public static void ShowWorkers()
        {
            foreach (Worker w in storeWorker)
                Console.WriteLine(w);
        }
        public static void RemoveWorker()
        {
            Console.WriteLine("Enter the ID of Worker you want to remove ");
            int x = Int32.Parse(Console.ReadLine());
            foreach (Worker w in storeWorker)
                if (x == w.ID)
                {
                    storeWorker.Remove(w);
                }
        }
    }
 
    }
