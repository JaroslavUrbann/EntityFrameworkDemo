using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using EFDemo.DL.Enums;

namespace EFDemo.DL.Entities
{
	[Table("Songs")]
	public class SongsEntity
	{
		
		public SongsEntity(string name, string interpret, string albumName, DateTime releaseDate, GenreEnum genre)
		{
			Name = name;
			Interpret = interpret;
			AlbumName = albumName;
			ReleaseDate = releaseDate;
			Genre = genre;
		}

		public SongsEntity(string name, string interpret, string albumName, DateTime releaseDate, GenreEnum genre, AlbumEntity album)
		{
			Name = name;
			Interpret = interpret;
			AlbumName = albumName;
			ReleaseDate = releaseDate;
			Genre = genre;
			Album = album;
			
		}

		public SongsEntity()
		{
			
		}

		[Key]
		public int Id { get; set; }
		public string Name { get; set; }
		public string Interpret { get; set; }
		public string AlbumName { get; set; }
		public DateTime ReleaseDate { get; set; }
		public GenreEnum Genre { get; set; }

		public AlbumEntity Album { get; set; }
	}
}