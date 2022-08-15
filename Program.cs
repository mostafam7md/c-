using System;

namespace FacultyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Main Menu ");
                Console.WriteLine("1- Student");
                Console.WriteLine("2- Instructor");
                Console.WriteLine("3- Worker");
                Console.WriteLine("4- Exit");
                Console.WriteLine("select from 1 to 4");
                int NumberofChoice1 = Int32.Parse(Console.ReadLine());
                if(NumberofChoice1>=1&& NumberofChoice1 <= 4)
                {
                    if (NumberofChoice1 == 1)
                    {
                        Console.WriteLine("1- Add Student");
                        Console.WriteLine("2- Show Students");
                        Console.WriteLine("3- Remove Student");
                        Console.WriteLine("select from 1 to 3");
                        int NumberofChoice2 = Int32.Parse(Console.ReadLine());
                        if(NumberofChoice2==1 )
                            Student.addStudent();
                        if (NumberofChoice2 == 2)
                            Student.ShowStudents();
                        if (NumberofChoice2 == 3)
                            Student.RemoveStudent();
                    }
                if (NumberofChoice1 == 2)
                    {
                        Console.WriteLine("1- Add Instructor");
                        Console.WriteLine("2- Show Instructor");
                        Console.WriteLine("3- Remove Instructor");
                        Console.WriteLine("select from 1 to 3");
                        int NumberofChoice2 = Int32.Parse(Console.ReadLine());
                        if (NumberofChoice2 == 1)
                            Instructor.addInstructor();
                        if (NumberofChoice2 == 2)
                            Instructor.ShowInstructors();
                        if (NumberofChoice2 == 3)
                            Instructor.RemoveInstructor();
                    }
                }
                if (NumberofChoice1 == 3)
                {
                    Console.WriteLine("1- Add Worker");
                    Console.WriteLine("2- Show Worker");
                    Console.WriteLine("3- Remove Worker");
                    Console.WriteLine("select from 1 to 3");
                    int NumberofChoice2 = Int32.Parse(Console.ReadLine());
                    if (NumberofChoice2 == 1)
                        Worker.addWorker();
                    if (NumberofChoice2 == 2)
                        Worker.ShowWorkers();
                    if (NumberofChoice2 == 3)
                        Worker.RemoveWorker();
                }
                if (NumberofChoice1 == 4)
                {
                    break;
                }

            }
        }
    }
}
