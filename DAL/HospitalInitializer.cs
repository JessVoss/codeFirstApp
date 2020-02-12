using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using codeFirstApp.Models;

namespace codeFirstApp.DAL
{
    public class HospitalInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<HospitalContext>
    {
        protected override void Seed(HospitalContext context)
        {
            var patients = new List<Patient>
            {
                new Patient{FirstName="Peggy", LastName ="Lancaster", DateOfBirth=DateTime.Parse("2005-09-01") },
                new Patient{FirstName="Alex", LastName ="Blanzy", DateOfBirth= DateTime.Parse("2002-09-01")},
                new Patient{FirstName="Gytis", LastName ="Alonso", DateOfBirth= DateTime.Parse("2003-09-01")},
                new Patient{FirstName="Nino", LastName ="Norman", DateOfBirth=DateTime.Parse("2002-09-01") },
                new Patient{FirstName="Justice", LastName ="James", DateOfBirth= DateTime.Parse("2002-09-01")}
            };
            patients.ForEach(s => context.Patients.Add(s));
            context.SaveChanges();

             var employees = new List<Employee>
            {
                new Employee{EmployeeID=101, FirstName ="Meredith",LastName="Moses"},
                new Employee{EmployeeID=102, FirstName ="Jazzmin",LastName="Mann"},
                new Employee{EmployeeID=103, FirstName ="Pamela",LastName="Grace"},
                new Employee{EmployeeID=104, FirstName ="Heather",LastName="Shaw"},
                new Employee{EmployeeID=105, FirstName ="Diane",LastName="Voss"},
                new Employee{EmployeeID=106, FirstName ="Audrey",LastName="Westerman"},
                 new Employee{EmployeeID=107, FirstName ="Audrey",LastName="Angleman"}
            };
            employees.ForEach(s => context.Employees.Add(s));
            context.SaveChanges();

            var encounters = new List<Encounter>
            {
                new Encounter{EncounterID = 205046, PatientID= 1, DOS=DateTime.Parse("2019-09-01") , EmployeeID = 105,ServiceType=ServiceType.A},
                new Encounter{EncounterID = 205072, PatientID= 2, DOS=DateTime.Parse("2019-03-01") , EmployeeID = 102,ServiceType=ServiceType.B},
                new Encounter{EncounterID = 205421, PatientID= 3, DOS=DateTime.Parse("2019-09-10") , EmployeeID = 101,ServiceType=ServiceType.D},
                new Encounter{EncounterID = 205364, PatientID= 4, DOS=DateTime.Parse("2019-10-20") , EmployeeID = 106},
                new Encounter{EncounterID = 205123, PatientID= 2, DOS=DateTime.Parse("2019-11-01") , EmployeeID = 107,ServiceType=ServiceType.A}
            };
            encounters.ForEach(s => context.Encounters.Add(s));
            context.SaveChanges();
           
        }
    }
}