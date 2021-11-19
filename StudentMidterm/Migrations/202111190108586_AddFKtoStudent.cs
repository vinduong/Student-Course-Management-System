namespace StudentMidterm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFKtoStudent : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "Status_Id", c => c.Byte());
            CreateIndex("dbo.Students", "Status_Id");
            AddForeignKey("dbo.Students", "Status_Id", "dbo.Status", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "Status_Id", "dbo.Status");
            DropIndex("dbo.Students", new[] { "Status_Id" });
            DropColumn("dbo.Students", "Status_Id");
        }
    }
}
