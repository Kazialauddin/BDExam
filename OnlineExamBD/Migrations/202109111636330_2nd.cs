namespace OnlineExamBD.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _2nd : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Questions", "Answers_Id", "dbo.Answers");
            DropForeignKey("dbo.Questions", "Options_Id", "dbo.Options");
            DropIndex("dbo.Questions", new[] { "Answers_Id" });
            DropIndex("dbo.Questions", new[] { "Options_Id" });
            DropPrimaryKey("dbo.Questions");
            AlterColumn("dbo.Questions", "Id", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Questions", "Id");
            DropColumn("dbo.Questions", "Answers_Id");
            DropColumn("dbo.Questions", "Options_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Questions", "Options_Id", c => c.Int());
            AddColumn("dbo.Questions", "Answers_Id", c => c.Int());
            DropPrimaryKey("dbo.Questions");
            AlterColumn("dbo.Questions", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Questions", "Id");
            CreateIndex("dbo.Questions", "Options_Id");
            CreateIndex("dbo.Questions", "Answers_Id");
            AddForeignKey("dbo.Questions", "Options_Id", "dbo.Options", "Id");
            AddForeignKey("dbo.Questions", "Answers_Id", "dbo.Answers", "Id");
        }
    }
}
