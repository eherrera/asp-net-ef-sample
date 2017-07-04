namespace ContosoUniversity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCompanyClass : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Company",
                c => new
                    {
                        CompanyId = c.Int(nullable: false, identity: true),
                        RUT = c.String(nullable: false),
                        Name = c.String(nullable: false),
                        Address = c.String(),
                        Email = c.String(maxLength: 100),
                        Website = c.String(),
                        Phone = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.CompanyId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Company");
        }
    }
}
