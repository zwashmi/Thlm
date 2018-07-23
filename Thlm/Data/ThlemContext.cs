using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using thlem.Data.Eintities;
using Thlm.Models;

namespace thlem.Data
{
    public class ThlemContext : IdentityDbContext<ApplicationUser>
    {
        public ThlemContext(DbContextOptions<ThlemContext> options): base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

        public DbSet<RegisterCompany> RegisterCompany { get; set; }
        public DbSet<ResgisterResearcher> RegisterResearcher { get; set; }
        public DbSet<CompanySubmition> CompanySubmition { get; set; }
        public DbSet<ResearcherSubmition> ResearcherSubmition { get; set; }
        public DbSet<SubmitionProjects> SubmitionProjects { get; set; }
        
    }
}
