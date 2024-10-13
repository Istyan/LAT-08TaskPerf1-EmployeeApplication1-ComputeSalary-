using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EmployeeApplication1
{
    public class PartTimeEmployee : IEmployee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
        public string JobTitle { get; set; }
        public double BasicSalary { get; set; }
        public double RatePerHour { get; set; }
        public int TotalHoursWorked { get; set; }

        public double ComputeSalary()
        {
            return RatePerHour * TotalHoursWorked;
        }
    }
}

