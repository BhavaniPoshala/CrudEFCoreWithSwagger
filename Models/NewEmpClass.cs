using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CrudEFCoreWithSwagger.Models
{
    public class NewEmpClass
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Empid { get; set; }

        public String Empname { get; set; }

        public String Email { get; set; }

        public int Age { get; set; }

        public int Salary { get; set; }
    }
}
