namespace StudentManagement.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.User",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        Username = c.String(),
                        Password = c.String(),
                        Gender = c.String(),
                        Email = c.String(),
                        Address = c.String(),
                        Phone = c.String(),
                        Image = c.String(),
                        IDRole = c.Guid(nullable: false),
                        Role_ID = c.Guid(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Role", t => t.Role_ID)
                .Index(t => t.Role_ID);
            
            CreateTable(
                "dbo.Blog",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        Title = c.String(),
                        Content = c.String(),
                        PostDate = c.DateTime(nullable: false),
                        IDCategory = c.Guid(nullable: false),
                        IDUser = c.Guid(nullable: false),
                        Category_ID = c.Guid(),
                        User_ID = c.Guid(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Category", t => t.Category_ID)
                .ForeignKey("dbo.User", t => t.User_ID)
                .Index(t => t.Category_ID)
                .Index(t => t.User_ID);
            
            CreateTable(
                "dbo.Category",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Comment",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        Content = c.String(),
                        CommentDate = c.DateTime(nullable: false),
                        IDUser = c.Guid(nullable: false),
                        IDBlog = c.Guid(nullable: false),
                        Blog_ID = c.Guid(),
                        User_ID = c.Guid(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Blog", t => t.Blog_ID)
                .ForeignKey("dbo.User", t => t.User_ID)
                .Index(t => t.Blog_ID)
                .Index(t => t.User_ID);
            
            CreateTable(
                "dbo.Image",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        IDBlog = c.Guid(nullable: false),
                        LinkImage = c.String(),
                        Blog_ID = c.Guid(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Blog", t => t.Blog_ID)
                .Index(t => t.Blog_ID);
            
            CreateTable(
                "dbo.Role",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        RoleName = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.User", "Role_ID", "dbo.Role");
            DropForeignKey("dbo.Blog", "User_ID", "dbo.User");
            DropForeignKey("dbo.Image", "Blog_ID", "dbo.Blog");
            DropForeignKey("dbo.Comment", "User_ID", "dbo.User");
            DropForeignKey("dbo.Comment", "Blog_ID", "dbo.Blog");
            DropForeignKey("dbo.Blog", "Category_ID", "dbo.Category");
            DropIndex("dbo.Image", new[] { "Blog_ID" });
            DropIndex("dbo.Comment", new[] { "User_ID" });
            DropIndex("dbo.Comment", new[] { "Blog_ID" });
            DropIndex("dbo.Blog", new[] { "User_ID" });
            DropIndex("dbo.Blog", new[] { "Category_ID" });
            DropIndex("dbo.User", new[] { "Role_ID" });
            DropTable("dbo.Role");
            DropTable("dbo.Image");
            DropTable("dbo.Comment");
            DropTable("dbo.Category");
            DropTable("dbo.Blog");
            DropTable("dbo.User");
        }
    }
}
