namespace StudentMidterm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeTableValuesAgain : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Students", "CourseId", "dbo.Courses");
            DropForeignKey("dbo.Students", "Status_Id", "dbo.Status");
            DropIndex("dbo.Students", new[] { "CourseId" });
            DropIndex("dbo.Students", new[] { "Status_Id" });
            DropPrimaryKey("dbo.Courses");
            DropPrimaryKey("dbo.Status");
            DropPrimaryKey("dbo.Students");
            AlterColumn("dbo.Courses", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Status", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Students", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Students", "CourseId", c => c.Int(nullable: false));
            AlterColumn("dbo.Students", "CourseStatusId", c => c.Int(nullable: false));
            AlterColumn("dbo.Students", "Status_Id", c => c.Int());
            AddPrimaryKey("dbo.Courses", "Id");
            AddPrimaryKey("dbo.Status", "Id");
            AddPrimaryKey("dbo.Students", "Id");
            CreateIndex("dbo.Students", "CourseId");
            CreateIndex("dbo.Students", "Status_Id");
            AddForeignKey("dbo.Students", "CourseId", "dbo.Courses", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Students", "Status_Id", "dbo.Status", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "Status_Id", "dbo.Status");
            DropForeignKey("dbo.Students", "CourseId", "dbo.Courses");
            DropIndex("dbo.Students", new[] { "Status_Id" });
            DropIndex("dbo.Students", new[] { "CourseId" });
            DropPrimaryKey("dbo.Students");
            DropPrimaryKey("dbo.Status");
            DropPrimaryKey("dbo.Courses");
            AlterColumn("dbo.Students", "Status_Id", c => c.Byte());
            AlterColumn("dbo.Students", "CourseStatusId", c => c.Byte(nullable: false));
            AlterColumn("dbo.Students", "CourseId", c => c.Byte(nullable: false));
            AlterColumn("dbo.Students", "Id", c => c.Byte(nullable: false));
            AlterColumn("dbo.Status", "Id", c => c.Byte(nullable: false));
            AlterColumn("dbo.Courses", "Id", c => c.Byte(nullable: false));
            AddPrimaryKey("dbo.Students", "Id");
            AddPrimaryKey("dbo.Status", "Id");
            AddPrimaryKey("dbo.Courses", "Id");
            CreateIndex("dbo.Students", "Status_Id");
            CreateIndex("dbo.Students", "CourseId");
            AddForeignKey("dbo.Students", "Status_Id", "dbo.Status", "Id");
            AddForeignKey("dbo.Students", "CourseId", "dbo.Courses", "Id", cascadeDelete: true);
        }
    }
}
