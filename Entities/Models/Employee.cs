using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Entities.Models;

namespace Entities
{
    public class Employee
    {
        [Column("EmployeeId")] public Guid Id { get; set; }

        [Required(ErrorMessage = "Employee name is required")]
        [MaxLength(30, ErrorMessage = "Max lenght is 30 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Age is required")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Position is required")]
        [MaxLength(20, ErrorMessage = "Max length for position is 20 characters")]
        public string Position { get; set; }

        [ForeignKey(nameof(Company))]
        public Guid CompanyId { get; set; }
        public Company Company { get; set; }
    }
}