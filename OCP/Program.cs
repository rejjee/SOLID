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
            //CalculateTotalSalaries();
            FilterByType();
        }

        static void CalculateTotalSalaries()
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

        static void FilterByType()
        {
            var monitors = new List<ComputerMonitor>
            {
                new ComputerMonitor { Name = "Samsung S345", Screen = Screen.CurvedScreen, Type = MonitorType.OLED },
                new ComputerMonitor { Name = "Philips P532", Screen = Screen.WideScreen, Type = MonitorType.LCD },
                new ComputerMonitor { Name = "LG L888", Screen = Screen.WideScreen, Type = MonitorType.LED },
                new ComputerMonitor { Name = "Samsung S999", Screen = Screen.WideScreen, Type = MonitorType.OLED },
                new ComputerMonitor { Name = "Dell D2J47", Screen = Screen.CurvedScreen, Type = MonitorType.LCD }        
            };

            var filter = new MonitorFilter();

            //var filteredMonitors = filter.FilterByType(monitors, MonitorType.LCD);
            //Console.WriteLine("All LCD monitors");
            var filteredMonitors = filter.FilterByScreen(monitors, Screen.CurvedScreen);
            Console.WriteLine("All Curved monitors");
            foreach (var monitor in filteredMonitors)
            {
                string string1 = string.Format("Name: {0}, Type: {1}, Screen: {2}", monitor.Name, monitor.Type, monitor.Screen);
                Console.WriteLine(string1);
            }
        }
    }
}
