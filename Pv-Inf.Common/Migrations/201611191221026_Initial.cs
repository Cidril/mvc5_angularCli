namespace Pv_Inf.Common.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.group",
                c => new
                    {
                        group_id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.group_id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.group");
        }
    }
}
