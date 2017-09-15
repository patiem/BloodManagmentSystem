namespace BloodManagmentSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateDBWithBloodBankExemple : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO BloodBanks (Id, Name, City) VALUES (1, 'RCK Krakow', 'Cracow')");
            Sql("INSERT INTO BloodBanks (Id, Name, City) VALUES (2, 'RCK Katowice', 'Katowice')");
            Sql("INSERT INTO BloodBanks (Id, Name, City) VALUES (3, 'RCK Warszawa', 'Warsow')");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM BloodBanks WHERE Id IN (1, 2, 3)");
        }
    }
}
