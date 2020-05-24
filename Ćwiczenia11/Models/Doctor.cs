using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace Cwiczenia11.Models
{
    public class Doctor
    {
        [Key]
        public int IdDoctor { get; set; }
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public ICollection <Prescription> Prescriptions { get; set; }
   
    }
}