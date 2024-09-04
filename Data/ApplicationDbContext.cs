using Microsoft.EntityFrameworkCore;
using MegaCentralFinance.Models;

namespace MegaCentralFinance.Data
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{			
		}

		public DbSet<MsUserModel> Users { get; set; }
		public DbSet<MsStorageLocationModel> StorageLocations { get; set; }
		public DbSet<TrBpkbModel> Bpkbs { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=mcf;Integrated Security=True;Trusted_Connection=True;TrustServerCertificate=True;MultipleActiveResultSets=True;");
		}
	}
}