namespace Lifect.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DrugaMigracija : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MuscleGroups", "About", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.MuscleGroups", "About");
        }
    }
}
