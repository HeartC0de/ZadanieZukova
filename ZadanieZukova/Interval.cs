using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieZukova
{
    internal class Interval
    {

        public string StartTime { get; set; } = string.Empty;
        public string EndTime { get; set; } = string.Empty;

        public Interval(string start, string end)
        {
            StartTime = start;
            EndTime = end;
        }

        public void freeSpoons()
        {
            
        }
    }
}
