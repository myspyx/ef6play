namespace EF6Play.Host.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addPublishTime : DbMigration
    {
        public override void Up()
        {
            AddColumn("public.Blogs", "Published", c => c.DateTime(nullable: false, defaultValue:new DateTime(1982,11,8)));
        }
        
        public override void Down()
        {
            DropColumn("public.Blogs", "Published");
        }
    }
}
