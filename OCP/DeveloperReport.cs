using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    public class DeveloperReport
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Level { get; set; }
        public int WorkingHours { get; set; }
        public double HourlyRate { get; set; }
        public virtual double CalculateSalary()
        {
            return WorkingHours * HourlyRate;
        }
    }

    public class JrDeveloper : DeveloperReport
    {

    }

    public class SrDeveloper : DeveloperReport
    {
        public override double CalculateSalary()
        {
            return WorkingHours * HourlyRate * 1.2;
        }
    }
}
