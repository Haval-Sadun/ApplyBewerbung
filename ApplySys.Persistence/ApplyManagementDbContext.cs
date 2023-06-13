using ApplySys.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplySys.Persistence
{
    public class ApplyManagementDbContext : DbContext
    {
        public ApplyManagementDbContext(DbContextOptions<ApplyManagementDbContext> options)
            :base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplyManagementDbContext).Assembly);
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
           /* foreach (var entry in ChangeTracker.Entries<BaseDomainEntity>())
            {
                entry.Entity.LastModifiedDate = DateTime.Now;
                if(entry.State == EntityState.Added)
                    entry.Entity.DateCreated = DateTime.Now;
            }*/ 

            return base.SaveChangesAsync(cancellationToken);
        }

        public DbSet<Apply> Applys { get; set; }
    }
}
