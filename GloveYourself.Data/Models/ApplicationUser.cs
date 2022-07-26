using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace GloveYourself.Data.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        public string? LastName { get; set; }

        [Display(Name = "Hand Width")]
        public decimal HandWidthInch { get; set; }

        [Display(Name = "Date Created")]
        public DateTimeOffset CreatedUtc { get; set; }

        public decimal HandWidthMm => HandWidthInch * 25.4m;

        public virtual ICollection<Glove> Gloves { get; set; } // One-to-many

    }
}
