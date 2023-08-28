namespace Marwin.Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CompanyNameLength : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Companies", "CompanyName", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Companies", "CompanyName", c => c.String());
        }
    }
}
