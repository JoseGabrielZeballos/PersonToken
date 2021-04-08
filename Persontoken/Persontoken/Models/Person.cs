using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Persontoken.Models
{
    public class Person
    {
        [Key]

        public int Personid { get; set; }
        [Required]
        public string Name { get; set; }

        public int CovidStatus { get; set; }
    }
}
