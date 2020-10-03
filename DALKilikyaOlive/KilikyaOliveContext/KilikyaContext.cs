using DALKilikyaOlive.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DALKilikyaOlive.KilikyaOliveContext
{
    public class KilikyaContext : IdentityDbContext<AppUser, AppRole, int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=LAPTOP-J4NMAH4J;database=KilikyaOliveDB;Integrated Security=True");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityUserLogin<int>>().HasKey(m => new { m.LoginProvider, m.ProviderKey });
            modelBuilder.Entity<IdentityUserRole<int>>().HasKey(m => new { m.RoleId, m.UserId });
            modelBuilder.Entity<IdentityUserToken<int>>().HasKey(m => new { m.UserId, m.LoginProvider, m.Name });
        }
    }
}
