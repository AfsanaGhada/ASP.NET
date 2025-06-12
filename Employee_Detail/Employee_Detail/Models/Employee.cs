using System.ComponentModel.DataAnnotations;

namespace Employee_Detail.Models
{
    
        public class Employee
        {
            public int EmployeeID { get; set; }
            public string Name { get; set; }
            public int Salary { get; set; }
            public DateTime JoiningDate { get; set; }
            public string Department { get; set; }
        }

    
}
