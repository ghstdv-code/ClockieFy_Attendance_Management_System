using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockiFyAMS
{
    public class Attendance : Workers
    {
        public string AttDate { get; set; }
        public string TimeIn { get; set; }
        public string Timeout { get; set; }
        public string TImeWorked { get; set; }   
    }
}
