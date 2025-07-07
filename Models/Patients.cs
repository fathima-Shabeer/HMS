
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace HMS.Models
{
    public class Patient
    {
        [Key] // Marks this property as the primary key
        public int PatientId { get; set; }

        [Required(ErrorMessage = "Patient name is required.")]
        [StringLength(100)]
        [DisplayName("Patient Name")]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayName("Date of Birth")]
        public DateTime DateOfBirth { get; set; }

        [Required]
        public string Gender { get; set; } // Could be "Male", "Female", "Other"

        [Required(ErrorMessage = "Contact number is required.")]
        [DisplayName("Contact Number")]
        [Phone]
        public string ContactNumber { get; set; }

        public string? Address { get; set; } // The '?' makes it an optional field
    }
}