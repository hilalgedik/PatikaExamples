using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UserLoginForm.Entities;

namespace UserLoginForm.DataAccess.EntityFramework.Context
{
    public class VotingContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(
                connectionString: @"Server=(localdb)\MSSQLLocalDB;Database=Voting;Trusted_Connection=true");
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Category> Categories { get; set; }

    }

}
    


