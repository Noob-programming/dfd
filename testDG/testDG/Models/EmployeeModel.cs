using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testDG.Models
{
    internal class EmployeeModel
    {
        public Guid EmployeeGuid { get; set; }
        public int EmployeeId { get; set; }
        public string EmployeeFirstName { get; set; }
        public string EmployeeLastName { get; set; }
        public DateTime Date { get; set; }  
        public string PhoneNumber { get; set; } = string.Empty;
    }
}
