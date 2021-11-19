namespace StudentMidterm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeTablesSettings : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Students", "CourseId", "dbo.Courses");
            DropIndex("dbo.Students", new[] { "CourseId" });
            DropPrimaryKey("dbo.Courses");
            DropPrimaryKey("dbo.Status");
            DropPrimaryKey("dbo.Students");
            AddColumn("dbo.Students", "CourseStatusId", c => c.Byte(nullable: false));
            AlterColumn("dbo.Courses", "Id", c => c.Byte(nullable: false));
            AlterColumn("dbo.Status", "Id", c => c.Byte(nullable: false));
            AlterColumn("dbo.Students", "Id", c => c.Byte(nullable: false));
            AlterColumn("dbo.Students", "CourseId", c => c.Byte(nullable: false));
            AddPrimaryKey("dbo.Courses", "Id");
            AddPrimaryKey("dbo.Status", "Id");
            AddPrimaryKey("dbo.Students", "Id");
            CreateIndex("dbo.Students", "CourseId");
            AddForeignKey("dbo.Students", "CourseId", "dbo.Courses", "Id", cascadeDelete: true);
            DropColumn("dbo.Students", "CourseStatus");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Students", "CourseStatus", c => c.Int(nullable: false));
            DropForeignKey("dbo.Students", "CourseId", "dbo.Courses");
            DropIndex("dbo.Students", new[] { "CourseId" });
            DropPrimaryKey("dbo.Students");
            DropPrimaryKey("dbo.Status");
            DropPrimaryKey("dbo.Courses");
            AlterColumn("dbo.Students", "CourseId", c => c.Int(nullable: false));
            AlterColumn("dbo.Students", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Status", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Courses", "Id", c => c.Int(nullable: false, identity: true));
            DropColumn("dbo.Students", "CourseStatusId");
            AddPrimaryKey("dbo.Students", "Id");
            AddPrimaryKey("dbo.Status", "Id");
            AddPrimaryKey("dbo.Courses", "Id");
            CreateIndex("dbo.Students", "CourseId");
            AddForeignKey("dbo.Students", "CourseId", "dbo.Courses", "Id", cascadeDelete: true);
        }
    }
}
