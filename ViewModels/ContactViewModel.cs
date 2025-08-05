using System.ComponentModel.DataAnnotations;

namespace InternTask2.ViewModels
{
    public class ContactViewModel
    {
        [Required]
        public string FullName { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Message { get; set; }
    }

}
