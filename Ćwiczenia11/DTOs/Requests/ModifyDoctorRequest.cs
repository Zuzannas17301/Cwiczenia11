using System.ComponentModel.DataAnnotations;

namespace Cwiczenia11.DTOs.Requests
{
    public class ModifyDoctorRequest
    {
        [Required] public int IdDoctor { get; set; }
        [Required] public string FirstName { get; set; }
        [Required] public string LastName { get; set; }
        [Required] public string Email { get; set; }
    }
}