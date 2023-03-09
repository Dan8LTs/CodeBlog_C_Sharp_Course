namespace SQL.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Authors",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.Pictures",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(),
                    Year = c.Int(),
                    AuthorId = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Authors", t => t.AuthorId, cascadeDelete: true)
                .Index(t => t.AuthorId);
        }

        public override void Down()
        {
            DropForeignKey("dbo.Pictures", "AuthorId", "dbo.Authors");
            DropIndex("dbo.Pictures", new[] { "AuthorId" });
            DropTable("dbo.Pictures");
            DropTable("dbo.Authors");
        }
    }
}
