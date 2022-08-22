using Microsoft.EntityFrameworkCore;
using HospiEnCasa.App.Dominio; // Me


namespace HospiEnCasa.App.Persistencia
{

	public class AppContext : DbContext
	{
		// nullable
		public DbSet<Persona> Personas {get; set;}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			if (!optionsBuilder.IsConfigured)
			{
				optionsBuilder
				.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = HospiEnCasaData");
			}
		}
	}
}
