﻿using System.ComponentModel.DataAnnotations;

namespace Mission06_Kang.Models
{
    public class AddingMovie
    {
        [Key]
        [Required]
        public int MovieID { get; set; }
        public string Category { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public string Director { get; set; }
        public string Rating { get; set; }
        public bool Edited { get; set; }
        public string? Lent_To { get; set; }
        public string? Notes { get; set; }
    }
}
