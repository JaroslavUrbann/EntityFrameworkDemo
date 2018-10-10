namespace EFDemo.DL.Migrations
{
	using System.Data.Entity.Migrations;

	public partial class mig1 : DbMigration
	{
		public override void Up()
		{
			CreateTable(
				"dbo.Songs",
				c => new
				{
					Id = c.Int(nullable: false, identity: true),
					Name = c.String(),
					Interpret = c.String(),
					AlbumName = c.String(),
					ReleaseDate = c.DateTime(nullable: false),
					Genre = c.Int(nullable: false),
				})
				.PrimaryKey(t => t.Id);

		}

		public override void Down()
		{
			DropTable("dbo.Songs");
		}
	}
}