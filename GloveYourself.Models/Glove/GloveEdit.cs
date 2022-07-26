using System;
using System.ComponentModel.DataAnnotations;

namespace GloveYourself.Models.Glove
{
    public class GloveEdit
    {
        public int Id { get; set; }

        public byte? Image { get; set; }

        [Required]
        [MinLength(3, ErrorMessage = "Please enter at least 3 characters.")]
        [MaxLength(100, ErrorMessage = "There are too many characters in this field.")]
        public string Title { get; set; }

        [Required]
        [MinLength(3, ErrorMessage = "Please enter at least 3 characters.")]
        [MaxLength(100, ErrorMessage = "There are too many characters in this field.")]
        public string Brand { get; set; }

        [Required]
        [MinLength(3, ErrorMessage = "Please enter at least 3 characters.")]
        [MaxLength(100, ErrorMessage = "There are too many characters in this field.")]
        public string Description { get; set; }

        //public string GloveSizes { get; set; }

        //public string UserTask { get; set; }

        //public string ApplicationUserId { get; set; }
    }
}

