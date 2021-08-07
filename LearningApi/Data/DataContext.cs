using System.Diagnostics.CodeAnalysis;
using LearningApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace LearningApi.Data
{
    
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<AppUser> Users { get; set; }
    }
}