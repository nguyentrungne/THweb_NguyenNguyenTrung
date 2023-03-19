namespace TH_2080600752_NguyenNguyenTrung.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDateTime : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Courses", "DateTime", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Courses", "DateTime", c => c.String());
        }
    }
}
