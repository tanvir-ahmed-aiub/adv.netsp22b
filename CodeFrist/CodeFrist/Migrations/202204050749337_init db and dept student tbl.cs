namespace CodeFrist.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initdbanddeptstudenttbl : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        DeparmentId = c.Int(nullable: false),
                        Department_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Departments", t => t.Department_Id)
                .Index(t => t.Department_Id);
            
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Students", new[] { "Department_Id" });
            DropForeignKey("dbo.Students", "Department_Id", "dbo.Departments");
            DropTable("dbo.Departments");
            DropTable("dbo.Students");
        }
    }
}
