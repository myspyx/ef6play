namespace EF6Play.Host.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatepublishtimenullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("public.Blogs", "Published", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("public.Blogs", "Published", c => c.DateTime(nullable: false));
        }
    }
}
