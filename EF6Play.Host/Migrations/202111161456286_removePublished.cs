namespace EF6Play.Host.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removePublished : DbMigration
    {
        public override void Up()
        {
            DropColumn("public.Blogs", "Published");
        }
        
        public override void Down()
        {
            AddColumn("public.Blogs", "Published", c => c.DateTime());
        }
    }
}
