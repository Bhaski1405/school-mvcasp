namespace AcademyApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class synctables_test : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Trainings", "Title", c => c.String(maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Trainings", "Title", c => c.String(nullable: false, maxLength: 255));
        }
    }
}
