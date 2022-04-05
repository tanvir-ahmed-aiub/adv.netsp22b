namespace CodeFrist.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class coursestudentrealtionships : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CourseStudents",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StudentId = c.Int(nullable: false),
                        CourseId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Students", t => t.StudentId, cascadeDelete: true)
                .ForeignKey("dbo.Courses", t => t.CourseId, cascadeDelete: true)
                .Index(t => t.StudentId)
                .Index(t => t.CourseId);
            
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.CourseStudents", new[] { "CourseId" });
            DropIndex("dbo.CourseStudents", new[] { "StudentId" });
            DropForeignKey("dbo.CourseStudents", "CourseId", "dbo.Courses");
            DropForeignKey("dbo.CourseStudents", "StudentId", "dbo.Students");
            DropTable("dbo.Courses");
            DropTable("dbo.CourseStudents");
        }
    }
}
