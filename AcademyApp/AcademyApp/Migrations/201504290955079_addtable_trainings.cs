namespace AcademyApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addtable_trainings : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Trainings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(maxLength: 255),
                        Description = c.String(maxLength: 255),
                        Anchor = c.String(maxLength: 100),
                        Duration = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Trainings");
        }
    }
}
