using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WarmUp_Pocos.Models;

namespace WarmUp_Pocos.Contexts
{
    public class HackerNews : DbContext
    {
        public HackerNews()
            : base("HackerNews")
        { }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Favorite> Favorites { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Student>()
            //    .HasOptional<Standard>(s => s.Standard)
            //    .WithMany()
            //    .WillCascadeOnDelete(false);
        }
    }
}