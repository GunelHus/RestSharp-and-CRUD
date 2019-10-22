using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using RestSharp.Models;

namespace RestSharp.DAL
{
    class UserDbContext: DbContext
    {
        public UserDbContext(): base("UserConnection")
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Post> Posts { get; set; }

    }
}
