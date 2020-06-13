namespace Lifect.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PrvaMigracija : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Exercises",
                c => new
                    {
                        Id_Exercise = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        MusclesId = c.Int(nullable: false),
                        Reps = c.Int(nullable: false),
                        Sets = c.Int(nullable: false),
                        ImageExercise = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id_Exercise);
            
            CreateTable(
                "dbo.MuscleGroups",
                c => new
                    {
                        Id_MuscleGroup = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        ImageMuscleGroup = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id_MuscleGroup);
            
            CreateTable(
                "dbo.Trainings",
                c => new
                    {
                        Id_Training = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Duration = c.Int(nullable: false),
                        ImageTraining = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id_Training);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Trainings");
            DropTable("dbo.MuscleGroups");
            DropTable("dbo.Exercises");
        }
    }
}
