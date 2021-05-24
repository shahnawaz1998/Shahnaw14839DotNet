using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EfCodeFirstApp2.Migrations;
using Microsoft.EntityFrameworkCore;

namespace EfCodeFirstApp2
{
	public class BookDBContext:DbContext
	{
		public DbSet<Book> Books { get; set; }
		public DbSet<Member> Members { get; set; }
		public DbSet<Review> Reviews { get; set; }
		public DbSet<Publisher> Publishers { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=BookDB;Integrated Security=True;");
		}

	}
}
