namespace StudentMidterm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewFKinStudent : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Students", "CourseStatusId");
            AddForeignKey("dbo.Students", "CourseStatusId", "dbo.Status", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "CourseStatusId", "dbo.Status");
            DropIndex("dbo.Students", new[] { "CourseStatusId" });
        }
    }
}
