namespace StudentMidterm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateStatus : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Status (ProgressStatus) VALUES ('In Progress')");
            Sql("INSERT INTO Status (ProgressStatus) VALUES ('Completed')");
        }
        
        public override void Down()
        {
        }
    }
}
