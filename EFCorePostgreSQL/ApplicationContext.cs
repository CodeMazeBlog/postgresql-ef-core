using EFCorePostgreSQL.Entities;
using Microsoft.EntityFrameworkCore;

namespace EFCorePostgreSQL
{
	public class ApplicationContext : DbContext
	{
		public ApplicationContext(DbContextOptions options)
				: base(options)
		{
		}

		public DbSet<Student> Students { get; set; }
	}
}
