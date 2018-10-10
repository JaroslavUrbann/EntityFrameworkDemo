using System.Collections.Generic;
using EFDemo.DL.Entities;
using EFDemo.DL.Enums;

namespace EFDemo.DL.Migrations
{
	using System;
	using System.Data.Entity.Migrations;

	internal sealed class Configuration : DbMigrationsConfiguration<EFDemo.DL.EntitiesContext>
	{
		public Configuration()
		{
			AutomaticMigrationsEnabled = false;
		}

		protected override void Seed(EFDemo.DL.EntitiesContext context)
		{
			//  This method will be called after migrating to the latest version.

			//  You can use the DbSet<T>.AddOrUpdate() helper extension method 
			//  to avoid creating duplicate seed data.

			var songs = new List<SongsEntity>();

			songs.Add(new SongsEntity("První", "Sugar pro (Vladko)", "první", DateTime.Today, GenreEnum.SugarPro));
			songs.Add(new SongsEntity("Druhá", "Sugar pro (Vladko)", "druhé", DateTime.Today, GenreEnum.Emo));
			songs.Add(new SongsEntity("Třetí", "Sugar pro (Vladko)", "první", DateTime.Today, GenreEnum.Rock));

			context.Songs.AddRange(songs);
		}
	}
}