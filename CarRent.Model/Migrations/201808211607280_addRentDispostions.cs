namespace CarRent.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addRentDispostions : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RentDispositions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CarId = c.Int(nullable: false),
                        ClientId = c.Int(nullable: false),
                        CreatedOn = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cars", t => t.CarId, cascadeDelete: true)
                .ForeignKey("dbo.Clients", t => t.ClientId, cascadeDelete: true)
                .Index(t => t.CarId)
                .Index(t => t.ClientId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RentDispositions", "ClientId", "dbo.Clients");
            DropForeignKey("dbo.RentDispositions", "CarId", "dbo.Cars");
            DropIndex("dbo.RentDispositions", new[] { "ClientId" });
            DropIndex("dbo.RentDispositions", new[] { "CarId" });
            DropTable("dbo.RentDispositions");
        }
    }
}
