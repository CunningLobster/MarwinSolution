namespace Marwin.Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        CompanyId = c.Guid(nullable: false),
                        CompanyName = c.String(),
                        BIN = c.String(maxLength: 12),
                        Address = c.String(maxLength: 200),
                        Note = c.String(),
                    })
                .PrimaryKey(t => t.CompanyId);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmployeeId = c.Guid(nullable: false),
                        FirstName = c.String(maxLength: 30),
                        LastName = c.String(maxLength: 30),
                        ThirdName = c.String(maxLength: 30),
                        TIN = c.String(maxLength: 12),
                        CompanyId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.EmployeeId)
                .ForeignKey("dbo.Companies", t => t.CompanyId, cascadeDelete: true)
                .Index(t => t.CompanyId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "CompanyId", "dbo.Companies");
            DropIndex("dbo.Employees", new[] { "CompanyId" });
            DropTable("dbo.Employees");
            DropTable("dbo.Companies");
        }
    }
}
