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
        //public List<ComputerMonitor> FilterByType(IEnumerable<ComputerMonitor> monitors, MonitorType type)
        //{
        //    return monitors.Where(m => m.Type == type).ToList();
        //}

        //public List<ComputerMonitor> FilterByScreen(IEnumerable<ComputerMonitor> monitors, Screen screen)
        //{
        //    return monitors.Where(m => m.Screen == screen).ToList();
        //}

        public List<ComputerMonitor> Filter(List<ComputerMonitor> monitors, ISpecification specification)
        {
            return monitors.Where(m => (specification.isSatisfied(m))).ToList();
        }
    }

    public interface ISpecification
    {
        //ISpec<T>()

        bool isSatisfied(ComputerMonitor monitor);
    }

    public class MonitorTypeSpecification : ISpecification
    {
        MonitorType _type;

        public MonitorTypeSpecification(MonitorType monitorType)
        {
            _type = monitorType;
        }

        public bool isSatisfied(ComputerMonitor item)
        {
            return item.Type == _type;
        }
    }

    public class ScreenSpecification : ISpecification
    {
        Screen _screen;

        public ScreenSpecification(Screen screen)
        {
            _screen = screen;
        }

        public bool isSatisfied(ComputerMonitor monitor)
        {
            return monitor.Screen == _screen;
        }
    }

}
