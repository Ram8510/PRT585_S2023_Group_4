using System;
using System.ComponentModel.DataAnnotations;

namespace cinema_admin.Models.Domain
{
	public class Language
	{
        public int Id { get; set; }
        [Required]
        public string languageName { get; set; }

    
    }
}

