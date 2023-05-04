using System;
using toDoApi;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http.HttpResults;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace toDoApi.Models
{
	[Table("todo")]
	public class ToDo
	{
		[Key]
        public Guid Id { get; set; }

		[Required]
		public string? Title { get; set; }
	}
}

