using System;

class Employee
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Job { get; set; }

    public Employee(string name, int age, string job)
    {
        Name = name;
        Age = age;
        Job = job;
    }

    public double CalculateSalary()
    {
        double baseSalary = 0;

        if (Job == "Driver")
        {
            baseSalary = 6000;
        }
        else if (Job == "Mechanic")
        {
            baseSalary = 5000;
        }
        else if (Job == "Personnel")
        {
            baseSalary = 4000;
        }

        double finalSalary = baseSalary * 1.1 * Age;
        return Math.Round(finalSalary, 2);
    }
}
