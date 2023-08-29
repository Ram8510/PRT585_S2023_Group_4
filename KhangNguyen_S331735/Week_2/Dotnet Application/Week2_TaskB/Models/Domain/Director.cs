using System;
using System.ComponentModel.DataAnnotations;

namespace cinema_admin.Models.Domain
{
	public class Director
	{
		public int Id { get; set; }
		[Required]

        public string directorName { get; set; }

     }
}

