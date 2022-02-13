using System;

namespace EmployeePayRollADONet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------Welcome TO Employee PayRoll Services Using ADO.NET----------");
            EmployeeRepository employeeRepository = new EmployeeRepository();
            employeeRepository.GetDataFromSql();

        }
    }
}