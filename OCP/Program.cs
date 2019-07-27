using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    class Program
    {
        static void Main(string[] args)
        {
            var devReports = new List<DeveloperReport>
            {
                new SrDeveloper {Id = 1, Name = "Dev1", Level = "Senior developer", HourlyRate  = 30.5, WorkingHours = 160 },
                new JrDeveloper {Id = 2, Name = "Dev2", Level = "Junior developer", HourlyRate  = 20, WorkingHours = 150 },
                new SrDeveloper {Id = 3, Name = "Dev3", Level = "Senior developer", HourlyRate  = 30.5, WorkingHours = 180 }
            };

            var calculator = new SalaryCalculator(devReports);
            Console.WriteLine(string.Format("Sum of all the developer salaries is {0} dollars", calculator.CalculateTotalSalaries()));
        }
    }
}
