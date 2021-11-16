namespace EF6Play.Host.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addDesc : DbMigration
    {
        public override void Up()
        {
            AddColumn("public.Posts", "Desc", c => c.String(nullable:false, defaultValue:"no desc"));
        }
        
        public override void Down()
        {
            DropColumn("public.Posts", "Desc");
        }
    }
}
