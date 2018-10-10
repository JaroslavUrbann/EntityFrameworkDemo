using System;
using System.Linq;
using EFDemo.DL;
using EFDemo.DL.Entities;
using EFDemo.DL.Enums;

namespace EFDemo.TestApp
{
	class Program
	{
		static void Main(string[] args)
		{
			// vytvořím instanci UnitOfWork
			using (var unitOfWork = new UnitOfWork())
			{
				// vytvořím si entitu
				var song = new SongsEntity("První", "The Papercuts", "první", DateTime.Today, GenreEnum.Dechovky);
				var sugarProAlbum = new AlbumEntity("SugarProFirstAlbum");


				var sugarProSong = new SongsEntity("firstsong", "sugarpro", "SugarProFirstAlbum", DateTime.Today, GenreEnum.SugarPro);

				sugarProAlbum.Songs.Add(sugarProSong);

				// Přidám záznam do databáze.
				unitOfWork.Albums.Add(sugarProAlbum);
				unitOfWork.Songs.Add(song);

				// Uložím změny.
				unitOfWork.Save();

				var entitiesInDb = unitOfWork.Songs.GetAll().ToList();

				foreach (var entity in entitiesInDb)
				{
					Console.WriteLine
					(
						$@"Název songu: {entity.Name} Interpret: {entity.Interpret}"
					);
				}

				var albums = unitOfWork.Albums.GetAll().ToList();
			}

			Console.ReadKey();
		}
	}
}