using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testDG.View.Interfaces
{
    internal interface IEmployee
    {
        Guid EmployeeGuid { get; set; }
        int EmployeeId { get; set; }
        string EmployeeFirstName { get; set; }
        string EmployeeLastName { get; set; }
        DateTime Date { get; set; }
        string PhoneNumber { get; set; }
    }
}
