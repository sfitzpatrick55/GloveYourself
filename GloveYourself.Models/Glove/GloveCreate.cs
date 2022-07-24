using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GloveYourself.Models.Glove
{
    public class GloveCreate
    {
        //public byte Image { get; set; }

        [Required]
        [MinLength(3, ErrorMessage = "Please enter at least 3 characters.")]
        [MaxLength(100, ErrorMessage = "There are too many characters in this field.")]
        public string Brand { get; set; }

        [Required]
        [MinLength(3, ErrorMessage = "Please enter at least 3 characters.")]
        [MaxLength(100, ErrorMessage = "There are too many characters in this field.")]
        public string Title { get; set; }

        public string Description { get; set; }

        public string GloveSizes { get; set; }

        public int TaskId { get; set; }

        public string ApplicationUserId { get; set; }
    }
}

