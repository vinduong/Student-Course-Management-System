namespace StudentMidterm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedAnnotations : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Students", "BirthDay", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Students", "EnrolledDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Students", "Grade", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "Grade", c => c.String());
            AlterColumn("dbo.Students", "EnrolledDate", c => c.DateTime());
            AlterColumn("dbo.Students", "BirthDay", c => c.DateTime());
        }
    }
}
