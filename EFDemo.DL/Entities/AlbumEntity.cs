using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EFDemo.DL.Entities
{
	public class AlbumEntity
	{
		public AlbumEntity(string albumName)
		{
			AlbumName = albumName;

			Songs = new HashSet<SongsEntity>();
		}

		public AlbumEntity()
		{
				
		}

		public ICollection<SongsEntity> Songs { get; set; }

		[Key]
		public int AlbumId { get; set; }
		public string AlbumName { get; set; }
	}
}