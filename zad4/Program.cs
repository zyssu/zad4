using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad4
{
    class Program
    {
        static void Main(string[] args)
        {
            bool running = true;

            while (running)
            {
                Console.Clear();
                Console.WriteLine("Main Menu:");
                Console.WriteLine("1. Add an employee");
                Console.WriteLine("2. Exit");
                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    Console.Write("Enter employee name: ");
                    string name = Console.ReadLine();

                    Console.Write("Enter employee age: ");
                    if (!int.TryParse(Console.ReadLine(), out int age))
                    {
                        Console.WriteLine("Age must be a valid number. Try again.");
                        continue;
                    }

                    Console.Write("Enter employee job (Driver, Mechanic, Personnel): ");
                    string job = Console.ReadLine();

                    Employee employee = new Employee(name, age, job);
                    double salary = employee.CalculateSalary();

                    Console.WriteLine($"\nEmployee {employee.Name} (Age: {employee.Age}, Job: {employee.Job})");
                    Console.WriteLine($"Calculated salary: {salary} USD\n");
                    Console.WriteLine("Press any key to return to the menu...");
                    Console.ReadKey();
                }
                else if (choice == "2")
                {
                    running = false;
                    Console.WriteLine("Exiting the program.");
                }
                else
                {
                    Console.WriteLine("Invalid choice, please try again.");
                }
            }
        }
    }
}