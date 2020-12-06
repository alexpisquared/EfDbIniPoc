using System;
using System.Data.Entity;
using System.Windows;

namespace xDbIni
{
	public class DBInitializer : DropCreateDatabaseIfModelChanges<DbIniPoc_DbContext>
	{
		public static void SetDbInitializer()
		{
			try
			{
				Database.SetInitializer(new CreateDatabaseIfNotExists<DbIniPoc_DbContext>());
				Database.SetInitializer(new DropCreateDatabaseIfModelChanges<DbIniPoc_DbContext>());
				Database.SetInitializer(new DBInitializer());
			}
			catch (Exception ex) { MessageBox.Show(ex.ToString(), "Exception", MessageBoxButton.OK, MessageBoxImage.Error); }
		}

		protected override void Seed(DbIniPoc_DbContext dbCtx)
		{
			try
			{
				base.Seed(dbCtx);

				var g1 = dbCtx.Genres.Add(new LkuGenre { Name = "New", Desc = "New" });
				var g2 = dbCtx.Genres.Add(new LkuGenre { Name = "Unused", Desc = "Unused" });

				dbCtx.MediaUnits.Add(new MediaUnit { ID = 1, AddedAt = DateTime.Now, FileName = "abc.wav", LkuGenre = g1 });
				dbCtx.MediaUnits.Add(new MediaUnit { ID = 2, AddedAt = DateTime.Now, FileName = "abc.wav", LkuGenre = g1 });
				dbCtx.MediaUnits.Add(new MediaUnit { ID = 3, AddedAt = DateTime.Now, FileName = "abc.wav", LkuGenre = g2 });

				dbCtx.SaveChanges();
			}
			catch (Exception ex) { MessageBox.Show(ex.ToString(), "Exception", MessageBoxButton.OK, MessageBoxImage.Error); }
		}
	}
}
