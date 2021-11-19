namespace StudentMidterm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedFK : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Students", "Status_Id", "dbo.Status");
            DropIndex("dbo.Students", new[] { "Status_Id" });
            DropColumn("dbo.Students", "Status_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Students", "Status_Id", c => c.Int());
            CreateIndex("dbo.Students", "Status_Id");
            AddForeignKey("dbo.Students", "Status_Id", "dbo.Status", "Id");
        }
    }
}
