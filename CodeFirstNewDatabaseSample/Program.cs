using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace CodeFirstNewDatabaseSample
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var db = new BloggingContext())
            {
                Console.Write("Ingrese un nombre para el Blog: ");
                var name = Console.ReadLine();
                var blog = new Blog {Name = name};
                db.Blogs.Add(blog);
                db.SaveChanges();

                var query = from b in db.Blogs
                            orderby b.Name
                            select b;

                Console.WriteLine("Datos almacenados en la BD: ");
                foreach (var item in query)
                {
                    Console.WriteLine(item.Name);
                }

                Console.WriteLine("Presione una tecla para continuar...");
                Console.ReadKey();
            }
        }
    }


    public class Blog
    {
        public int BlogId { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public virtual List<Post> Posts { get; set; }
    }

    public class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int BlogId { get; set; }
        public virtual Blog Blog { get; set; } 

    }

    public class User
    {
        [Key]
        public string Username { get; set; }
        public string DisplayName { get; set; }
    }

    public class BloggingContext : DbContext
    {
        public DbSet<Blog> Blogs {set; get;}
        public DbSet<Post> Posts {set; get;}
        public DbSet<User> Users { get; set; } 

    }
}
