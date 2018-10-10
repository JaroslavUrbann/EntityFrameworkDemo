using System.Collections.Generic;
using System.Linq;
using EFDemo.DL.Entities;
using EFDemo.DL.Enums;

namespace EFDemo.DL.Repositories
{
	internal class SongRepository : Repository<SongsEntity>, ISongRepository
	{
		public SongRepository(EntitiesContext context) : base(context)
		{
		}

		public IEnumerable<SongsEntity> GetByGenre(GenreEnum genre)
		{
			// LINQ TO SQL ZÁPIS
			return Context.Set<SongsEntity>().Where(song => song.Genre == genre);
		}
	}
}