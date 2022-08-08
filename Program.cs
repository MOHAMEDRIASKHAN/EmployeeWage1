// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

namespace employeewage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            employeePresentAbsent emp = new employeePresentAbsent();
            emp.EmployeePresentAndAbsent();
        }
    }
}