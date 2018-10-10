namespace EFDemo.DL.Migrations
{
	using System.Data.Entity.Migrations;

	public partial class mig2 : DbMigration
	{
		public override void Up()
		{
			CreateTable(
				"dbo.AlbumEntities",
				c => new
				{
					AlbumId = c.Int(nullable: false, identity: true),
					AlbumName = c.String(),
				})
				.PrimaryKey(t => t.AlbumId);

			AddColumn("dbo.Songs", "Album_AlbumId", c => c.Int());
			CreateIndex("dbo.Songs", "Album_AlbumId");
			AddForeignKey("dbo.Songs", "Album_AlbumId", "dbo.AlbumEntities", "AlbumId");
		}

		public override void Down()
		{
			DropForeignKey("dbo.Songs", "Album_AlbumId", "dbo.AlbumEntities");
			DropIndex("dbo.Songs", new[] { "Album_AlbumId" });
			DropColumn("dbo.Songs", "Album_AlbumId");
			DropTable("dbo.AlbumEntities");
		}
	}
}
