using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


    //    public class CityModel
    //    {
    //        [Required(ErrorMessage = "Country ID is required.")]
    //        [ForeignKey("Country")]
    //        public int CountryID { get; set; }

    //        [Required(ErrorMessage = "State ID is required.")]
    //        [ForeignKey("State")]
    //        public int StateID { get; set; }  // Foreign Key referencing State table

    //        [Required(ErrorMessage = "City Name is required.")]
    //        [StringLength(100, ErrorMessage = "City Name cannot exceed 100 characters.")]
    //        public string CityName { get; set; }

    //        [StringLength(50, ErrorMessage = "STD Code cannot exceed 50 characters.")]
    //        public string? STDCode { get; set; }  // Nullable

    //        [StringLength(6, ErrorMessage = "Pin Code cannot exceed 6 characters.")]
    //        [RegularExpression(@"^\d{6}$", ErrorMessage = "Pin Code must be exactly 6 digits.")]
    //        public string? PinCode { get; set; }  // Nullable
    //        public int CityID { get; set; }
    //        public object UserID { get; set; }
    //    }
    //}



    namespace AddressBook.Models
    {
    public class CityModel
    {
        public int CityID { get; set; }

        [Required(ErrorMessage = "Country is required")]
        public int? CountryID { get; set; }

        [Required(ErrorMessage = "State is required")]
        public int? StateID { get; set; }

        [Required(ErrorMessage = "City Name is required")]
        public string CityName { get; set; }

        [Required(ErrorMessage = "STD Code is required")]
        public string STDCode { get; set; }

        [Required(ErrorMessage = "Pin Code is required")]
        public string PinCode { get; set; }

        public int UserID { get; set; } = 1; // Replace with actual logged-in UserID

        public DateTime CreationDate { get; set; } = DateTime.Now; // Optional for displaying/recording

    }
    }


