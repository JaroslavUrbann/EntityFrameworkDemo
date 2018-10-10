using System.Collections.Generic;
using EFDemo.DL.Entities;
using EFDemo.DL.Enums;

namespace EFDemo.DL.Repositories
{
	public interface ISongRepository : IRepository<SongsEntity>
	{
		IEnumerable<SongsEntity> GetByGenre(GenreEnum genre);
	}
}