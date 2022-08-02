using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace QRScanner.Model
{
    public class Employees
    {
        public string EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeDescription { get; set; }
        public string Category { get; set; }
        public DateTime TimeInOut { get; set; }
    }
}
