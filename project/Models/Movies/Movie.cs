using System;
using System.ComponentModel.DataAnnotations;


namespace project.Models.Movies
{
    public class Movie
    {
        /// <summary>
        /// Movie id
        /// </summary>
        [Display(Name = "Id")]
        public int Id { get; set; }

        /// <summary>
        /// Movie poster 
        /// </summary>
        [Display(Name = "Url to poster")]
        public string Poster { get; set; }

        /// <summary>
        /// Movie name
        /// </summary>
        [Display(Name = "Movie name")]
        public string Name { get; set; }

        /// <summary>
        /// Author
        /// </summary>
        [Display(Name = "Author name")]
        public string Author { get; set; }

        /// <summary>
        /// Movie genere
        /// </summary>
        [Display(Name = "List of genres (by comma)")]
        public string Genre { get; set; }

        /// <summary>
        /// Creation date
        /// </summary>
        [Display(Name = "Release date")]
        public DateTime CreatedAt { get; set; }
    }

}