namespace StudentMidterm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDataAnnotations : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Courses", "CourseName", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Courses", "CourseDescription", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Courses", "TutorName", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Students", "FirstName", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Students", "EnrolledDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Students", "Grade", c => c.String(nullable: false, maxLength: 1));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "Grade", c => c.String());
            AlterColumn("dbo.Students", "EnrolledDate", c => c.DateTime());
            AlterColumn("dbo.Students", "FirstName", c => c.String());
            AlterColumn("dbo.Courses", "TutorName", c => c.String());
            AlterColumn("dbo.Courses", "CourseDescription", c => c.String());
            AlterColumn("dbo.Courses", "CourseName", c => c.String());
        }
    }
}
