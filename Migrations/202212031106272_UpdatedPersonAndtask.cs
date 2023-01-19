namespace HSchedule.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedPersonAndtask : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "PinCode", c => c.Int(nullable: false));
            DropColumn("dbo.People", "Password");
        }
        
        public override void Down()
        {
            AddColumn("dbo.People", "Password", c => c.Int(nullable: false));
            DropColumn("dbo.People", "PinCode");
        }
    }
}
