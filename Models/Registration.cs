using System.ComponentModel.DataAnnotations;

namespace EventEase.Models
{
    public class Registration
    {
        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
