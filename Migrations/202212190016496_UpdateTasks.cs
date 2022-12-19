namespace HSchedule.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateTasks : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Tasks", name: "LastPerformer_Id", newName: "NextPerformer_Id");
            RenameIndex(table: "dbo.Tasks", name: "IX_LastPerformer_Id", newName: "IX_NextPerformer_Id");
            AddColumn("dbo.Tasks", "Type", c => c.String(nullable: false));
            AddColumn("dbo.Tasks", "DeadLine", c => c.DateTime());
            AddColumn("dbo.Tasks", "Description", c => c.String());
            DropColumn("dbo.Tasks", "Date");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Tasks", "Date", c => c.DateTime(nullable: false));
            DropColumn("dbo.Tasks", "Description");
            DropColumn("dbo.Tasks", "DeadLine");
            DropColumn("dbo.Tasks", "Type");
            RenameIndex(table: "dbo.Tasks", name: "IX_NextPerformer_Id", newName: "IX_LastPerformer_Id");
            RenameColumn(table: "dbo.Tasks", name: "NextPerformer_Id", newName: "LastPerformer_Id");
        }
    }
}
