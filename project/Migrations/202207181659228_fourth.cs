namespace project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fourth : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Plants", "ShortDescription", c => c.String());
            AddColumn("dbo.Plants", "LongDescription", c => c.String());
            DropColumn("dbo.Plants", "Description");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Plants", "Description", c => c.String());
            DropColumn("dbo.Plants", "LongDescription");
            DropColumn("dbo.Plants", "ShortDescription");
        }
    }
}
