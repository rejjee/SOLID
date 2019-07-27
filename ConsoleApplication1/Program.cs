using SRP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            OCP();
        }


        static void OCP()
        {
            var report = new WorkReport();
            report.AddEntry(new WorkReportEntry { ProjectCode = "123Ds", ProjectName = "Project1", SpentHours = 5 });
            report.AddEntry(new WorkReportEntry { ProjectCode = "987Fc", ProjectName = "Project2", SpentHours = 3 });

            Console.WriteLine(report.ToString());

            var saver = new FileSaver();
            saver.SaveToFile(@"C:/temp/Reports", "WorkReport.txt", report);
        }

    }
}
