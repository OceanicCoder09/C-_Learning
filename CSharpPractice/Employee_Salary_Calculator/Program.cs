using System;

class Employee
{
    public string EmployeeName;
    public double BasicSalary;

    public static int EmployeeCount = 0;

    public int AddHRA(double basicSalary)
    {
        return (int)(basicSalary * 0.2);
    }

    public int AddDA(double basicSalary)
    {
        return (int)(basicSalary * 0.1);
    }

    public int AddPF(double basicSalary)
    {
        return (int)(basicSalary * 0.05);
    }
    public int CalculateGrossSalary(double basicSalary)
    {
        int hra = AddHRA(basicSalary);
        int da = AddDA(basicSalary);
        int pf = AddPF(basicSalary);

        return (int)(basicSalary + hra + da - pf);
    }
    public int CalculateNetSalary(double basicSalary)
    {
        int grossSalary = CalculateGrossSalary(basicSalary);
        int tax = (int)(grossSalary * 0.12); // 12% tax
        return grossSalary - tax;
    }
    public Employee()
    {
        EmployeeCount++;
    }
    public static void DisplayEmployeeCount()
    {
        Console.WriteLine($"Total Employees: {EmployeeCount}");
    }
}
class Program
{
    public static void Main()
    {
        while (true)
    {
        Employee emp = new Employee();

        Console.Write("Enter Employee Name: ");
        emp.EmployeeName = Console.ReadLine() ?? "";

        Console.Write("Enter Basic Salary: ");
        emp.BasicSalary = Convert.ToDouble(Console.ReadLine());
        
        double grossSalary = emp.CalculateGrossSalary(emp.BasicSalary);
        double netSalary = emp.CalculateNetSalary(emp.BasicSalary);
        Console.WriteLine($"Gross Salary: {grossSalary}");
        Console.WriteLine($"Net Salary: {netSalary}");
        Employee.DisplayEmployeeCount();
    } 
    

    }
}