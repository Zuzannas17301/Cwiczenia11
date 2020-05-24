using System.ComponentModel.DataAnnotations;

namespace Cwiczenia11.DTOs.Requests
{
    public class AddDoctorRequest
    {
        [Required(ErrorMessage = "Musisz podać imię)")]
        [MaxLength(50)]
        public string FirstName { get; set; }
        
        [Required(ErrorMessage = "Musisz podać nazwisko)")]
        [MaxLength(50)]
        public string LastName { get; set; }
        
        [Required(ErrorMessage = "Musisz podać email")]
        public string Email { get; set; }
    }
}