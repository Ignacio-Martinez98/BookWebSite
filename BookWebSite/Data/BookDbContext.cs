using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BookWebSite.Models;
using System.Data.Entity;

namespace BookWebSite.Data
{
    public class BookDbContext:DbContext
    {
        public BookDbContext() : base("KeyDB") { }
        public DbSet<Book> Books { get; set; }
    }
}