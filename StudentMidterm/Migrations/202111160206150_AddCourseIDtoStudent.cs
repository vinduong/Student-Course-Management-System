namespace StudentMidterm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCourseIDtoStudent : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "CourseId", c => c.Int(nullable: false));
            AddColumn("dbo.Students", "CourseStatus", c => c.Int(nullable: false));
            DropColumn("dbo.Students", "Status");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Students", "Status", c => c.Int(nullable: false));
            DropColumn("dbo.Students", "CourseStatus");
            DropColumn("dbo.Students", "CourseId");
        }
    }
}
