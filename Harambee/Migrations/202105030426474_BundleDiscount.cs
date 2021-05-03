namespace Harambee.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BundleDiscount : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Baskets", "Discount", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Baskets", "Discount");
        }
    }
}
