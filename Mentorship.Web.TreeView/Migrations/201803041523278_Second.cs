namespace Mentorship.Web.TreeView.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Second : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Categories", "ParentId", "dbo.Categories");
            DropIndex("dbo.Categories", new[] { "ParentId" });
            AddColumn("dbo.Categories", "Type", c => c.String());
            AddColumn("dbo.Categories", "IdText", c => c.String());
            AddColumn("dbo.Categories", "Text", c => c.String());
            DropColumn("dbo.Categories", "Name");
            DropColumn("dbo.Categories", "Description");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Categories", "Description", c => c.String());
            AddColumn("dbo.Categories", "Name", c => c.String());
            DropColumn("dbo.Categories", "Text");
            DropColumn("dbo.Categories", "IdText");
            DropColumn("dbo.Categories", "Type");
            CreateIndex("dbo.Categories", "ParentId");
            AddForeignKey("dbo.Categories", "ParentId", "dbo.Categories", "ID");
        }
    }
}
