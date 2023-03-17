namespace project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class twelveth : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Carts", "UserId", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Carts", "UserId");
        }
    }
}
