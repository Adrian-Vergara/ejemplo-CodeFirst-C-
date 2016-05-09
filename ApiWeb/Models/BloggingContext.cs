using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ApiWeb.Models
{

    public class BloggingContext : DbContext
    {
        public BloggingContext()
            : base("BloggingDatabase")
        {
        } 

        public DbSet<Blog> Blogs { set; get; }
        public DbSet<Post> Posts { set; get; }
        public DbSet<User> Users { get; set; }

    }
}