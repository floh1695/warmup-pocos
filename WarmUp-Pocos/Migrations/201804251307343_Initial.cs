namespace WarmUp_Pocos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserID = c.Int(nullable: false),
                        PostID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Posts", t => t.PostID, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserID, cascadeDelete: true)
                .Index(t => t.UserID)
                .Index(t => t.PostID);
            
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserID = c.Int(),
                        CategoryID = c.Int(),
                        Title = c.String(),
                        Link = c.String(),
                        Content = c.String(),
                        Timestamp = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Categories", t => t.CategoryID)
                .ForeignKey("dbo.Users", t => t.UserID)
                .Index(t => t.UserID)
                .Index(t => t.CategoryID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        Timestamp = c.DateTime(nullable: false),
                        Karma = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Favorites",
                c => new
                    {
                        UserID = c.Int(nullable: false),
                        PostID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.UserID, t.PostID })
                .ForeignKey("dbo.Posts", t => t.PostID, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserID, cascadeDelete: true)
                .Index(t => t.UserID)
                .Index(t => t.PostID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Favorites", "UserID", "dbo.Users");
            DropForeignKey("dbo.Favorites", "PostID", "dbo.Posts");
            DropForeignKey("dbo.Comments", "UserID", "dbo.Users");
            DropForeignKey("dbo.Comments", "PostID", "dbo.Posts");
            DropForeignKey("dbo.Posts", "UserID", "dbo.Users");
            DropForeignKey("dbo.Posts", "CategoryID", "dbo.Categories");
            DropIndex("dbo.Favorites", new[] { "PostID" });
            DropIndex("dbo.Favorites", new[] { "UserID" });
            DropIndex("dbo.Posts", new[] { "CategoryID" });
            DropIndex("dbo.Posts", new[] { "UserID" });
            DropIndex("dbo.Comments", new[] { "PostID" });
            DropIndex("dbo.Comments", new[] { "UserID" });
            DropTable("dbo.Favorites");
            DropTable("dbo.Users");
            DropTable("dbo.Posts");
            DropTable("dbo.Comments");
            DropTable("dbo.Categories");
        }
    }
}
