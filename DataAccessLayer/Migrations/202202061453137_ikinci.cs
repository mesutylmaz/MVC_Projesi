namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ikinci : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Contents", "Category_CategoryID", "dbo.Categories");
            DropIndex("dbo.Contents", new[] { "Category_CategoryID" });
            DropColumn("dbo.Contents", "Category_CategoryID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Contents", "Category_CategoryID", c => c.Int());
            CreateIndex("dbo.Contents", "Category_CategoryID");
            AddForeignKey("dbo.Contents", "Category_CategoryID", "dbo.Categories", "CategoryID");
        }
    }
}
