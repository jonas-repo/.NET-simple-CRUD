using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class Persona
    {
        [Key]
        public int IdPersona { get; set; }
        public string NamePersona { get; set; }
        public string AddressPersona { get; set; }
    }
}