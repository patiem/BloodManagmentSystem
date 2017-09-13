namespace BloodManagmentSystem.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class AddBloodRequestAndBloodBank : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BloodBanks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        City = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.BloodRequests",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BloodType = c.Int(nullable: false),
                        DueDate = c.DateTime(nullable: false),
                        City = c.String(),
                        Type_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.BloodBanks", t => t.Type_Id)
                .Index(t => t.Type_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BloodRequests", "Type_Id", "dbo.BloodBanks");
            DropIndex("dbo.BloodRequests", new[] { "Type_Id" });
            DropTable("dbo.BloodRequests");
            DropTable("dbo.BloodBanks");
        }
    }
}
