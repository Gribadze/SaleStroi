namespace IdentityMvc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OrdersAndTovars : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Tovars", "TovarName", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Tovars", "TovarName", c => c.String());
        }
    }
}
