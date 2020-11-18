using EBE_BackEnd.Models;
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EBE_BackEnd.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<Street> Streets { get; set; }
        public DbSet<Instituiton> Instituitons { get; set; }
        public DbSet<Events> Events { get; set; }
        public DbSet<SubEvents> SubEvents { get; set; }
        public DbSet<Users_has_Events> Users_has_Events { get; set; }
        public DbSet<SubEvents_has_Users> SubEvents_has_Users { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<EventsImages> EventsImages { get; set; }
        public DbSet<Palestrantes> Palestrantes { get; set; }
        public DbSet<Instituitions_has_Users> Instituitions_has_Users { get; set; }
    }
}
