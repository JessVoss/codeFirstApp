using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace codeFirstApp.Models
{
    public enum ServiceType
    {
        A, B, C, D, F
    }
    public class Encounter
    {
        [Display(Name = "Encounter ID")]
        public int EncounterID { get; set; }
        [Index]
        [Display(Name = "Patient ID")]
        public int PatientID { get; set; }
       
        [Display(Name = "Date of Service")]
        public DateTime DOS { get; set; }
        [Index]
        [Display(Name = "Employee ID")]
        public int EmployeeID { get; set; }

        public ServiceType? ServiceType { get; set; }
    }
}