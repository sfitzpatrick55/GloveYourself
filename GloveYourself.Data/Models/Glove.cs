using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GloveYourself.Data.Models
{
    public class Glove
    {
        [Key]
        public int Id { get; set; }

        public byte[]? Image { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Brand { get; set; }

        [Required]
        public string Description { get; set; }

        public DateTimeOffset CreatedUtc { get; set; }

        public virtual ICollection<GloveSize> GloveSizes { get; set; } // One-to-many

        //[ForeignKey(nameof(UserTask))]
        //public virtual ICollection<UserTask> UserTasks { get; set; } // One-to-many

        //[ForeignKey(nameof(ApplicationUser))]
        //public virtual ICollection<ApplicationUser> ApplicationUsers { get; set; } // One-to-many
    }
}
