using System.ComponentModel.DataAnnotations;

namespace AddressBook.Models
{
    public class CountryModel
    {
        //[Required(ErrorMessage = "Country Name is required.")]
        //[StringLength(100, ErrorMessage = "Country Name cannot exceed 100 characters.")]
        public int CountryID { get; set; }

        [Required]
        public string CountryName { get; set; }

        [Required(ErrorMessage = "Country Code is required.")]
        [StringLength(50, ErrorMessage = "Country Code cannot exceed 50 characters.")]
        public string CountryCode { get; set; }
        public int UserID { get; set; }



    }

}