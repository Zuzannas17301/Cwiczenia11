using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Cwiczenia11.DAL;

namespace Cwiczenia11.DTOs.Requests
{
    public class DeleteDoctorRequest
    {
        [Required] 
        [JsonConverter(typeof(JsonIntToStringConverter))]
        public int IdDoctor { get; set; }
      
    }
}