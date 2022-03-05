using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
namespace PS.Domain
{
    public class Departement
    {
        [Key]
        public int id { get; set; }
        public String Dept_name { get; set; }
        public IList<Employee> employees { get; set; }
    }
}
