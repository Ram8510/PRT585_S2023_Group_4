using System;
using System.ComponentModel.DataAnnotations;

namespace cinema_admin.Models.Domain
{
	public class Category
	{
        public int Id { get; set; }
        [Required]
        public string categoryType { get; set; }

        public string categoryCode { get; set; }
    }
}

