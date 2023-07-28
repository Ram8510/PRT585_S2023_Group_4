using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace cinema_admin.Models.Domain
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        public string movieName { get; set; }

        [Required]
       

      
        public int CategoryId { get; set; }
        [Required]
        public int LanguageId { get; set; }
        [Required]
        public int DirectorId { get; set; }

        [NotMapped]
        public string? directorName { get; set; }
        [NotMapped]
        public string? languageName { get; set; }
        [NotMapped]
        public string? categoryType { get; set; }

        [NotMapped]
        public List<SelectListItem>? AuthorList { get; set; }
        [NotMapped]
        public List<SelectListItem>? PublisherList { get; set; }
        [NotMapped]
        public List<SelectListItem>? GenreList { get; set; }

    }
}