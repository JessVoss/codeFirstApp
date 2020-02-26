using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace codeFirstApp.Models
{
    [Table("PatientInfo")]
    public class Patient
    {
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage = "Please enter the student's last name.")]
        [StringLength(30, ErrorMessage = "The last name must be less than {1} characters")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Please enter the student's first name.")]
        [StringLength(20, ErrorMessage = "The first name must be less than {1} characters")]
        [Column("FirstName")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [RegularExpression(@"^(\+\s?)?((?<!\+.*)\(\+?\d+([\s\-\.]?\d+)?\)|\d+)([\s\-\.]?(\(\d+([\s\-\.]?\d+)?\)|\d+))*(\s?(x|ext\.?)\s?\d+)?$",
           ErrorMessage = "The Phone field is not a valid phone number")]
        public string Phone { get; set; }
        [Column("DateOfBirth")]
        [Display(Name = "Date Of Birth")]
        public DateTime DateOfBirth { get; set; }
    
    public virtual ICollection<Encounter> Encounters { get; set; }
}
}
