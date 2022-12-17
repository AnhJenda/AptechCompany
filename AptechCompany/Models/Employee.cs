using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AptechCompany.Models
{
    [PrimaryKey(nameof(Id))]
    public class Employee
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "EmployeeID")]
        public string Id { get; set; }

        [Display(Name = "EmployeeName")]
        public string Name { get; set; }

        public string Department { get; set; }

        public double Salary { get; set; }

    }
}
