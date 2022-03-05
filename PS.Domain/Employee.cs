using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Text;
namespace PS.Domain
{
    public class Employee
    {

        public int id { get; set; }
        public string Emp_name { get; set; }
        public IList<Departement> departements { get; set; }
    }
}