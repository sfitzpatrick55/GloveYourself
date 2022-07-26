using System;
using System.ComponentModel.DataAnnotations;

namespace GloveYourself.Data.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Category")]
        public string CategoryName { get; set; }

        public virtual ICollection<UserTask> UserTasks { get; set; } // One-to-many
    }
}
