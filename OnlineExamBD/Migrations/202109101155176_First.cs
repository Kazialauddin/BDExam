namespace OnlineExamBD.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class First : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Answers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Answers = c.String(),
                        QuestionId = c.Int(nullable: false),
                        OptionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Options",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OptionA = c.String(),
                        OptionB = c.String(),
                        OptionC = c.String(),
                        OptionD = c.String(),
                        QuestionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Questions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Qustions = c.String(),
                        Answers_Id = c.Int(),
                        Options_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Answers", t => t.Answers_Id)
                .ForeignKey("dbo.Options", t => t.Options_Id)
                .Index(t => t.Answers_Id)
                .Index(t => t.Options_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Questions", "Options_Id", "dbo.Options");
            DropForeignKey("dbo.Questions", "Answers_Id", "dbo.Answers");
            DropIndex("dbo.Questions", new[] { "Options_Id" });
            DropIndex("dbo.Questions", new[] { "Answers_Id" });
            DropTable("dbo.Questions");
            DropTable("dbo.Options");
            DropTable("dbo.Answers");
        }
    }
}
