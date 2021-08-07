namespace OnlineExamBD.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModelChange : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Questions", "Answers_Id", "dbo.Answers");
            DropForeignKey("dbo.Questions", "Options_Id", "dbo.Options");
            DropIndex("dbo.Questions", new[] { "Answers_Id" });
            DropIndex("dbo.Questions", new[] { "Options_Id" });
            AddColumn("dbo.Options", "CorrectAns", c => c.String());
            AddColumn("dbo.Questions", "OptionsId", c => c.Int(nullable: false));
            DropColumn("dbo.Options", "QuestionId");
            DropColumn("dbo.Questions", "Answers_Id");
            DropColumn("dbo.Questions", "Options_Id");
            DropTable("dbo.Answers");
        }
        
        public override void Down()
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
            
            AddColumn("dbo.Questions", "Options_Id", c => c.Int());
            AddColumn("dbo.Questions", "Answers_Id", c => c.Int());
            AddColumn("dbo.Options", "QuestionId", c => c.Int(nullable: false));
            DropColumn("dbo.Questions", "OptionsId");
            DropColumn("dbo.Options", "CorrectAns");
            CreateIndex("dbo.Questions", "Options_Id");
            CreateIndex("dbo.Questions", "Answers_Id");
            AddForeignKey("dbo.Questions", "Options_Id", "dbo.Options", "Id");
            AddForeignKey("dbo.Questions", "Answers_Id", "dbo.Answers", "Id");
        }
    }
}
