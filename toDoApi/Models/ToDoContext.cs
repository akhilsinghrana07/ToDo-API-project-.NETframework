using System;
using Microsoft.EntityFrameworkCore;
using toDoApi.Models;

namespace toDoApi
{
	public class ToDoContext : DbContext
	{
		public ToDoContext(DbContextOptions<ToDoContext> options) : base(options) { }

		public DbSet<ToDo> ToDos { get; set; }
	}
}

