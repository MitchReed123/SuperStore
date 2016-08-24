using System;
using System.ComponentModel.DataAnnotations;

namespace SuperStore.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Hired")]
        public DateTime HireDate { get; set; }
        public int DepartmentId { get; set; }

        public virtual Department Department { get; set; }
    }
}