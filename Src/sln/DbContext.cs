using System.Data.Entity;

namespace xDbIni
{
	public class DbIniPoc_DbContext : DbContext
	{
		public DbIniPoc_DbContext() : base() { }
		public DbIniPoc_DbContext(string dbName) : base(dbName) { }

		public DbSet<LkuGenre> Genres { get; set; }
		public DbSet<MediaUnit> MediaUnits { get; set; }

		void foo() { }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			//modelBuilder.Conventions.Remove<System.Data.Entity.ModelConfiguration.Conventions.PluralizingTableNameConvention>();
		}
	}
}
