using IRO.Application.Common.Interfaces;
using IRO.Common;
using IRO.Domain.Common;
using IRO.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace IRO.Persistence
{
    class IRODbContext : DbContext, IIRODbContext
    {
        private readonly IDateTime _dateTime;
        public IRODbContext(DbContextOptions options) : base(options)
        {

        }

        public IRODbContext(
            DbContextOptions<IRODbContext> options,
            IDateTime dateTime)
            : base(options)
        {
            _dateTime = dateTime;
        }

        public DbSet<User> Users { get; set; }
        public DbSet<UserDmsLink> UserDmsLinks { get; set; }
        public DbSet<UserVehicle> UserVehicles { get; set; }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach(var entry in ChangeTracker.Entries<AuditableEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.Created = _dateTime.Now;
                        break;
                    case EntityState.Modified:
                        entry.Entity.LastModified = _dateTime.Now;
                        break;
                }
            }

            return base.SaveChangesAsync(cancellationToken);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(IRODbContext).Assembly);
        }
    }
}
