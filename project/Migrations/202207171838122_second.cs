namespace project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class second : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clients", "Email", c => c.String());
            AddColumn("dbo.Plants", "Description", c => c.String());
            AddColumn("dbo.Plants", "Available", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Plants", "Available");
            DropColumn("dbo.Plants", "Description");
            DropColumn("dbo.Clients", "Email");
        }
    }
}
