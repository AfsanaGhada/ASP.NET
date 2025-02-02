using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;

namespace AddressBook.Models
{
    public class StateModel
    {
        [Required(ErrorMessage = "Country ID is required.")]
        public int CountryID { get; set; }  

        [Required(ErrorMessage = "State Name is required.")]
        [StringLength(100, ErrorMessage = "State Name cannot exceed 100 characters.")]
        public string StateName { get; set; }

        [Required(ErrorMessage = "State Code is required.")]
        [StringLength(50, ErrorMessage = "State Code cannot exceed 50 characters.")]
        public string StateCode { get; set; }

        

    }
}
