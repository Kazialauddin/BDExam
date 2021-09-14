namespace OnlineExamBD.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _3rd : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Questions");
            AlterColumn("dbo.Questions", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Questions", "Id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Questions");
            AlterColumn("dbo.Questions", "Id", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Questions", "Id");
        }
    }
}
