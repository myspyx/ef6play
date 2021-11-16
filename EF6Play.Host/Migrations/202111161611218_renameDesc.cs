namespace EF6Play.Host.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class renameDesc : DbMigration
    {
        public override void Up()
        {
            AddColumn("public.Posts", "Description", c => c.String(nullable:false, defaultValue:"no desc"));
            DropColumn("public.Posts", "Desc");
        }
        
        public override void Down()
        {
            AddColumn("public.Posts", "Desc", c => c.String());
            DropColumn("public.Posts", "Description");
        }
    }
}
