namespace StudentMidterm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMoreAnnotations : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Students", "EnrolledDate", c => c.DateTime());
            AlterColumn("dbo.Students", "Grade", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "Grade", c => c.String(nullable: false, maxLength: 1));
            AlterColumn("dbo.Students", "EnrolledDate", c => c.DateTime(nullable: false));
        }
    }
}
