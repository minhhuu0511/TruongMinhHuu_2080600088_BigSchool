namespace TruongMinhHuu_2080600088.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCategoryTable : DbMigration
    {
        public override void Up()
        {
            Sql("Insert Into Categories (Id,Name) values (1,'Development')");
        }
        
        public override void Down()
        {
        }
    }
}
