// File: HMS.Web/Data/ApplicationDbContext.cs

using HMS.Models;
using Microsoft.EntityFrameworkCore;

namespace HMS.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        // This DbSet will become a table in our database named "Patients"
        public DbSet<Patient> Patients { get; set; }
    }
}