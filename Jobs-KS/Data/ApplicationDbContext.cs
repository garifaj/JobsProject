using Jobs_KS.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Jobs_KS.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<JobTypes> JobTypes { get; set; }
    }
}
