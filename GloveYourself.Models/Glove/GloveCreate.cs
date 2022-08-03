using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using GloveYourself.Data.Models;

namespace GloveYourself.Models.Glove
{
    public class GloveCreate
    {
        public byte[]? Image { get; set; }

        [Required]
        [MinLength(3, ErrorMessage = "Please enter at least 3 characters.")]
        [MaxLength(100, ErrorMessage = "There are too many characters in this field.")]
        public string Title { get; set; }

        [Required]
        [MinLength(3, ErrorMessage = "Please enter at least 3 characters.")]
        [MaxLength(50, ErrorMessage = "There are too many characters in this field.")]
        public string Brand { get; set; }

        [Required]
        [MinLength(3, ErrorMessage = "Please enter at least 3 characters.")]
        [MaxLength(100, ErrorMessage = "There are too many characters in this field.")]
        public string Description { get; set; }

        public string GloveSize { get; set; }
        public ICollection<GloveYourself.Data.Models.GloveSize> GloveSizes { get; set; }

        public virtual GloveYourself.Data.Models.Category Category { get; set; }

        [ForeignKey(nameof(UserTask))]
        public virtual ICollection<UserTask> UserTasks { get; set; } // One-to-many

        public DateTimeOffset CreatedUtc { get; set; }

        //public string ApplicationUserId { get; set; }
    }
}

