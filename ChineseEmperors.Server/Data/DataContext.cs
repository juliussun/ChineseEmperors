using ChineseEmperors.Server.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace ChineseEmperors.Server.Data
{
    public class DataContext: DbContext 
    {
        public DataContext(DbContextOptions<DataContext> options):base(options)
        {
            
        }

        public DbSet<ChineseEmperor> ChineseEmperors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Father-Sons Relationship
            modelBuilder.Entity<ChineseEmperor>()
                .HasMany(p => p.Sons)
                .WithOne(s => s.Father)
                .HasForeignKey(s => s.FatherId)
                .OnDelete(DeleteBehavior.Restrict); // Prevents cascading deletes

            // Successor Relationship
            modelBuilder.Entity<ChineseEmperor>()
                .HasOne(p => p.Successor)
                .WithOne(s => s.Predecessor)
                .HasForeignKey<ChineseEmperor>(p => p.SuccessorId)
                .OnDelete(DeleteBehavior.Restrict); // Adjust as needed

            modelBuilder.Entity<ChineseEmperor>()
                .Property(e => e.Bio)
                .HasMaxLength(1000);
        }

    }


}
