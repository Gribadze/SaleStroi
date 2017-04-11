namespace IdentityMvc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataMigration1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Orders", "IdUser", c => c.Guid(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Orders", "IdUser", c => c.Int(nullable: false));
        }
    }
}
