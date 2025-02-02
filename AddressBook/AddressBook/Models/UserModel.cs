using System.ComponentModel.DataAnnotations;

namespace AddressBook.Models
{
    public class UserModel
    {
        [Required(ErrorMessage = "User Name is required.")]
        [StringLength(100, ErrorMessage = "User Name cannot exceed 100 characters.")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Mobile Number is required.")]
        [StringLength(50, ErrorMessage = "Mobile Number cannot exceed 50 characters.")]
        [RegularExpression(@"^\d{10,15}$", ErrorMessage = "Mobile Number must be between 10 to 15 digits.")]
        public string MobileNo { get; set; }

        [Required(ErrorMessage = "Email ID is required.")]
        [StringLength(100, ErrorMessage = "Email ID cannot exceed 100 characters.")]
        [EmailAddress(ErrorMessage = "Invalid Email Address.")]
        public string EmailID { get; set; }

    }
}
