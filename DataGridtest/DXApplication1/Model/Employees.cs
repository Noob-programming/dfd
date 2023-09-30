using System;

namespace DXApplication1.Model
{

    public class Employees
    {
        public Guid EmGuid { get; set; } = Guid.Empty;

        public int EmployeeId { get; set; } = 0;

        public string Name { get; set; } = string.Empty;

        public int Age { get; set; } = 0;

        public string Gender { get; set; } = "";

    }
}