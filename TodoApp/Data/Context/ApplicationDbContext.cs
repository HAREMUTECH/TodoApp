using Microsoft.EntityFrameworkCore;
using TodoApp.Data.Entities;

namespace TodoApp.Data.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }



        public DbSet<EmailTemplate> EmailTemplates => Set<EmailTemplate>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Not needed if db context derives from MultiTenantDbContext
            // builder.ConfigureMultiTenant();
            //modelBuilder.Entity<EmployeeCountRecord>(a =>
            //{
            //    a.HasNoKey();
            //});
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }

        public override int SaveChanges(bool acceptAllChangesOnSuccess)
        {
            //this.EnforceMultiTenant();
            return base.SaveChanges(acceptAllChangesOnSuccess);
        }

        public override async Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess,
            CancellationToken cancellationToken = default)
        {
            //this.EnforceMultiTenant();
            return await base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }
    }
}
