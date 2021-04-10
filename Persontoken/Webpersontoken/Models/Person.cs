using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Webpersontoken.Models
{
    public class Person
    {
        [Key]

        public int Personid { get; set; }
        [Required]
        public string Name { get; set; }

        public int CovidCount { get; set; }
    }
}