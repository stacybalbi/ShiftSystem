using Microsoft.EntityFrameworkCore;
using ShiftSystem.Domain.Entities;
using ShiftSystem.Infrastructure.Context.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftSystem.Infrastructure.Context
{
    public interface IShiftSystemDbContext : IDisposable
    {
        public DbSet<T> GetDbSet<T>() where T : BaseEntity;
        int SaveChanges();
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
    public class ShiftSystemDbContext : DbContext, IShiftSystemDbContext
    {
        public DbSet<T> GetDbSet<T>() where T : BaseEntity => Set<T>();

        public DbSet<Person> Person { get; set; }

        public DbSet<Queue> Queue { get; set; }

        public ShiftSystemDbContext(DbContextOptions<ShiftSystemDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            foreach (var type in modelBuilder.Model.GetEntityTypes())
            {
                if (typeof(BaseEntity).IsAssignableFrom(type.ClrType))
                {
                    modelBuilder.SetSoftDeleteFilter(type.ClrType);
                }
            }
        }

        public void SetAuditEntities()
        {
            foreach (var entry in ChangeTracker.Entries<BaseEntity>())
            {
                if (entry.State != EntityState.Deleted)
                {
                    entry.State = EntityState.Modified;
                    entry.Entity.Deleted = true;
                }
            }
        }

        public override int SaveChanges()
        {
            return base.SaveChanges();
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {

            return base.SaveChangesAsync(cancellationToken);
        }

    }
}
