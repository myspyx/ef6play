namespace EF6Play.Host.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addAuthor : DbMigration
    {
        public override void Up()
        {
            AddColumn("public.Blogs", "Author", c => c.String(nullable:false, defaultValue:"bill"));
        }
        
        public override void Down()
        {
            DropColumn("public.Blogs", "Author");
        }
    }
}
