using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Recruter.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        
        public DbSet<Firm> Firms { get; set; }
        
        public DbSet<FirmServicePlan> FirmServicePlans { get; set; }
        
        public DbSet<UserServicePlan> UserServicePlans { get; set; }
        
        public DbSet<Vacancy> Vacancies { get; set; }
        
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}