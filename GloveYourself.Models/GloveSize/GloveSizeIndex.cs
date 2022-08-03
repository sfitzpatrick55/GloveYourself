using System;
using System.ComponentModel.DataAnnotations;
using GloveYourself.Data.Models;

namespace GloveYourself.Models.GloveSize
{
    public class GloveSizeIndex
    {
        [Key]
        public int Id { get; set; }

        public Size Size { get; set; }
    }
}

