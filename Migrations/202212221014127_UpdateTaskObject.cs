namespace HSchedule.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateTaskObject : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tasks", "Name", c => c.String(nullable: false));
            DropColumn("dbo.Tasks", "Title");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Tasks", "Title", c => c.String(nullable: false));
            DropColumn("dbo.Tasks", "Name");
        }
    }
}
