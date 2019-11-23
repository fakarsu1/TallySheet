namespace TSheet.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Firstcreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FName = c.String(nullable: false, maxLength: 30),
                        LName = c.String(nullable: false, maxLength: 30),
                        EmployeeTitleID = c.Int(nullable: false),
                        TC = c.String(maxLength: 11),
                        HireDate = c.DateTime(nullable: false),
                        Phone = c.String(maxLength: 13),
                        Email = c.String(maxLength: 50),
                        Adress = c.String(maxLength: 400),
                        ReportTo = c.Int(),
                        Salary = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SalaryTypeID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.EmployeeTitles", t => t.EmployeeTitleID, cascadeDelete: true)
                .ForeignKey("dbo.Employees", t => t.ReportTo)
                .ForeignKey("dbo.SalaryTypes", t => t.SalaryTypeID, cascadeDelete: true)
                .Index(t => t.EmployeeTitleID)
                .Index(t => t.ReportTo)
                .Index(t => t.SalaryTypeID);
            
            CreateTable(
                "dbo.EmployeeTitles",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 40),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.SalaryTypes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.WorkingTimes",
                c => new
                    {
                        WorkingLocationID = c.Int(nullable: false),
                        EmployeeID = c.Int(nullable: false),
                        WorkingDate = c.DateTime(nullable: false),
                        WorkingHours = c.Int(nullable: false),
                        ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.WorkingLocationID, t.EmployeeID, t.WorkingDate })
                .ForeignKey("dbo.Employees", t => t.EmployeeID, cascadeDelete: true)
                .ForeignKey("dbo.WorkingLocations", t => t.WorkingLocationID, cascadeDelete: true)
                .Index(t => t.WorkingLocationID)
                .Index(t => t.EmployeeID);
            
            CreateTable(
                "dbo.WorkingLocations",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 60),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.WorkingTimes", "WorkingLocationID", "dbo.WorkingLocations");
            DropForeignKey("dbo.WorkingTimes", "EmployeeID", "dbo.Employees");
            DropForeignKey("dbo.Employees", "SalaryTypeID", "dbo.SalaryTypes");
            DropForeignKey("dbo.Employees", "ReportTo", "dbo.Employees");
            DropForeignKey("dbo.Employees", "EmployeeTitleID", "dbo.EmployeeTitles");
            DropIndex("dbo.WorkingTimes", new[] { "EmployeeID" });
            DropIndex("dbo.WorkingTimes", new[] { "WorkingLocationID" });
            DropIndex("dbo.Employees", new[] { "SalaryTypeID" });
            DropIndex("dbo.Employees", new[] { "ReportTo" });
            DropIndex("dbo.Employees", new[] { "EmployeeTitleID" });
            DropTable("dbo.WorkingLocations");
            DropTable("dbo.WorkingTimes");
            DropTable("dbo.SalaryTypes");
            DropTable("dbo.EmployeeTitles");
            DropTable("dbo.Employees");
        }
    }
}
