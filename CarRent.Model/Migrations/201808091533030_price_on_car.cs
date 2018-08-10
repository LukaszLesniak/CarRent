namespace CarRent.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class price_on_car : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cars", "Price", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Cars", "Price");
        }
    }
}
