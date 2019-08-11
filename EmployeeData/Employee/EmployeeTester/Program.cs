using System;
using EmployeeData;

namespace EmployeeTester
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeClass em = new EmployeeClass();
            Console.WriteLine(em.EmployeeData("https://hooks.slack.com/services/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"));
            Console.ReadLine();
        }
    }
}
