namespace StudentMidterm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedBirthdayAnnotations : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Students", "BirthDay", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "BirthDay", c => c.DateTime(nullable: false));
        }
    }
}
