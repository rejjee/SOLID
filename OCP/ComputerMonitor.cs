using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    public enum MonitorType
    {
        OLED,
        LCD,
        LED
    }

    public enum Screen
    {
        WideScreen,
        CurvedScreen
    }

    public class ComputerMonitor
    {
        public string Name { get; set; }
        public MonitorType Type { get; set; }
        public Screen Screen { get; set; }
    }

    public class MonitorFilter
    {
        public List<ComputerMonitor> FilterByType(IEnumerable<ComputerMonitor> monitors, MonitorType type)
        {
            return monitors.Where(m => m.Type == type).ToList();
        }

        public List<ComputerMonitor> FilterByType(IEnumerable<ComputerMonitor> monitors, Screen screen)
        {
            return monitors.Where(m => m.Screen == screen).ToList();
        }
    }

}
