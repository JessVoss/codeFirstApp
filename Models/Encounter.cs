using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace codeFirstApp.Models
{
    public enum ServiceType
    {
        A, B, C, D, F
    }
    public class Encounter
    {
        public int EncounterID { get; set; }
        public int PatientID { get; set; }
        public DateTime DOS { get; set; }
        public int EmployeeID { get; set; }

        public ServiceType? ServiceType { get; set; }
    }
}