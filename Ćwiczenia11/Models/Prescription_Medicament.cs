using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cwiczenia11.Models
{
    public class Prescription_Medicament
    {
        [ForeignKey("Medicament")]
        public int IdMedicament { get; set; }

        [ForeignKey("Prescription")]
        public int IdPrescription { get; set; }

        public int? Dose { get; set; }
        public string Details { get; set; }
        
    }
}