
using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;

namespace EF6Play.Host.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<EF6Play.Host.BlogDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }
    } 
}