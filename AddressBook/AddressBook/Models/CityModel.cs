using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AddressBook.Models
{
    public class CityModel
    {
        [Required(ErrorMessage = "Country ID is required.")]
        [ForeignKey("Country")]
        public int CountryID { get; set; }

        [Required(ErrorMessage = "State ID is required.")]
        [ForeignKey("State")]
        public int StateID { get; set; }  // Foreign Key referencing State table

        [Required(ErrorMessage = "City Name is required.")]
        [StringLength(100, ErrorMessage = "City Name cannot exceed 100 characters.")]
        public string CityName { get; set; }

        [StringLength(50, ErrorMessage = "STD Code cannot exceed 50 characters.")]
        public string? STDCode { get; set; }  // Nullable

        [StringLength(6, ErrorMessage = "Pin Code cannot exceed 6 characters.")]
        [RegularExpression(@"^\d{6}$", ErrorMessage = "Pin Code must be exactly 6 digits.")]
        public string? PinCode { get; set; }  // Nullable

        

        
    }
}
