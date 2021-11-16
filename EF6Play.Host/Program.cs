using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace EF6Play.Host
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            using (var db = new BlogDbContext())
            {
                // Auto migration
                var migrator = new DbMigrator(new EF6Play.Host.Migrations.Configuration(), db);
                migrator.Update(null);

                // Display all Blogs from the database
                var query = from b in db.Blogs
                    orderby b.Name
                    select b;

                Console.WriteLine("All blogs in the database:");
                foreach (var item in query)
                {
                    Console.WriteLine($"{item.Name}-{item.BlogId}-{item.Author}.");
                }

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }
    }
}