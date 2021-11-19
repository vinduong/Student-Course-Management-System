namespace StudentMidterm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBirthDay : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "BirthDay", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "BirthDay");
        }
    }
}
