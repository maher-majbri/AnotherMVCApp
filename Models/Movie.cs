﻿using System.ComponentModel.DataAnnotations;

namespace AnotherMVCApp.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string? Title { get; set; }

        [DataType(DataType.Date)]

        [Display(Name ="Release Date")]
        public DateTime ReleaseDate { get; set; }

        public string? Genre { get; set; }

        public decimal Price { get; set; }

        public string? Photo { get; set; }
    }
}
