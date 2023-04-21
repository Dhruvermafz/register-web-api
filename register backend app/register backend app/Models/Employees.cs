using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace register_backend_app.Models
{
    public class Employees
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string State { get; set; }
        public string Country { get; set; } 
    }
}