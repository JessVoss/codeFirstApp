using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace codeFirstApp.Models
{
    public class Patient
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime DateOfBirth { get; set; }
    
    public virtual ICollection<Encounter> Encounters { get; set; }
}
}
