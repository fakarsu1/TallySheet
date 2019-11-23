namespace TSheet.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v1 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.WorkingTimes");
            AddPrimaryKey("dbo.WorkingTimes", new[] { "WorkingLocationID", "EmployeeID", "WorkingDate" });
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.WorkingTimes");
            AddPrimaryKey("dbo.WorkingTimes", new[] { "WorkingLocationID", "EmployeeID" });
        }
    }
}
