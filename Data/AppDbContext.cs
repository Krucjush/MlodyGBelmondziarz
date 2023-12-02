using Microsoft.EntityFrameworkCore;
using MlodyGBelmondziak.Models;

namespace MlodyGBelmondziak.Data
{
	public class AppDbContext : DbContext
	{
		public DbSet<Sound> Sounds { get; set; }

		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
		{

		}
	}
}
