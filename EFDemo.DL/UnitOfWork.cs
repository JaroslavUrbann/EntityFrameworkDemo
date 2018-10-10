using EFDemo.DL.Entities;
using EFDemo.DL.Repositories;

namespace EFDemo.DL
{
	public class UnitOfWork : IUnitOfWork
	{
		private EntitiesContext _context;
		private readonly ISongRepository _songs;
		private readonly IRepository<AlbumEntity> _albums;

		public UnitOfWork()
		{
			// vytvořím instanci DbContextu
			_context = new EntitiesContext();

			// Vytvoření Repositories
			_songs = new SongRepository(_context);
			_albums = new Repository<AlbumEntity>(_context);
		}

		public void Dispose()
		{
			_context.Dispose();
		}

		/// <summary>
		/// Repository pro tabulku se songy.
		/// </summary>
		public ISongRepository Songs
		{
			get { return _songs; }
		}

		public IRepository<AlbumEntity> Albums
		{
			get { return _albums; }
		}

		/// <summary>
		/// Uloží změny v databázi.
		/// </summary>
		public int Save()
		{
			return _context.SaveChanges();
		}
	}
}