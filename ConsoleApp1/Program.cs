string employeeName = "";
double employeeSalary = 0;

Console.WriteLine("Employee System");
Console.WriteLine("--------------------------");

Console.WriteLine("Enter employee name:");
employeeName = Console.ReadLine();

Console.WriteLine("Enter employee salary:");
employeeSalary = double.Parse(Console.ReadLine());

Console.WriteLine($"Name: {employeeName}, Salary: {employeeSalary}");