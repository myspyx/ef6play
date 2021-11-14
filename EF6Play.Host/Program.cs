using System;
using System.Collections.Generic;
using System.Linq;

namespace EF6Play.Host
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            using (var db = new BlogDbContext())
            {
                var blog = new Blog { Name = "the little scheme" };
                db.Blogs.Add(blog);
                db.SaveChanges();

                // Display all Blogs from the database
                var query = from b in db.Blogs
                    orderby b.Name
                    select b;

                Console.WriteLine("All blogs in the database:");
                foreach (var item in query)
                {
                    Console.WriteLine(item.Name);
                }

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }
    }
    
    
}