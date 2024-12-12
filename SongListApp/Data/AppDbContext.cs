using Microsoft.EntityFrameworkCore;

using Microsoft.EntityFrameworkCore; // Ensure this namespace is included

namespace SongListApp.Data
{
	public class AppDbContext : DbContext // Inherit from DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options) :
			base(options) // Pass options to the base DbContext constructor
		{
		}

		public DbSet<Song> Songs { get; set; } // Define a DbSet for your Song entity
	}
}
