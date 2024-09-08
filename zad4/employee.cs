using System;

class Employee
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Role { get; set; }

    public Employee(string name, int age, string role)
    {
        Name = name;
        Age = age;
        Role = role;
    }

    public double CalculateSalary()
    {
        double baseSalary = 0;

        if (Role == "Driver")
        {
            baseSalary = 6000;
        }
        else if (Role == "Mechanic")
        {
            baseSalary = 5000;
        }
        else if (Role == "Personnel")
        {
            baseSalary = 4000;
        }

        double finalSalary = baseSalary * 1.1 * Age;
        return Math.Round(finalSalary, 2);
    }
}

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

                Console.Write("Enter employee role (Driver, Mechanic, Personnel): ");
                string role = Console.ReadLine();

                Employee employee = new Employee(name, age, role);
                double salary = employee.CalculateSalary();

                Console.WriteLine($"\nEmployee {employee.Name} (Age: {employee.Age}, Role: {employee.Role})");
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
