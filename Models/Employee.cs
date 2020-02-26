using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace codeFirstApp.Models
{
    public class Employee
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EmployeeID { get; set; }
        [Required(ErrorMessage = "Please enter the Employees first name.")]
        [StringLength(20, ErrorMessage = "The first name must be less than {1} characters")]
        [Column("FirstName")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Please enter the Employees last name.")]
        [StringLength(30, ErrorMessage = "The last name must be less than {1} characters")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        public virtual ICollection<Encounter> Encounters { get; set; }
    }

}