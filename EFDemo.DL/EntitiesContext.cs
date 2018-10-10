using System.Data.Entity;
using EFDemo.DL.Entities;

namespace EFDemo.DL
{
	internal class EntitiesContext : DbContext
	{
		public DbSet<SongsEntity> Songs { get; set; }
		public DbSet<AlbumEntity> Albums { get; set; }
	}
}