using Domain.CallCenter_Case.Entities;
using Domain.CallCenter_Case.Entities.Common;
using Domain.CallCenter_Case.Entities.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.CallCenter_Case.Contexts
{
    public class CallCenterDbContext : IdentityDbContext<AppUser, AppRole, string>
    {
        public CallCenterDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<CallRecord> CallRecords { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<Request> Requests { get; set; }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
          
            var datas = ChangeTracker //yakala
                .Entries<BaseEntity>();
            foreach (var data in datas)
            {
                _ = data.State switch
                {
                    EntityState.Added => data.Entity.CreatedDate = DateTime.UtcNow,
                    _ => DateTime.UtcNow
                };
            }
            return await base.SaveChangesAsync(cancellationToken);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CallRecord>(entity =>
            {
                entity.HasOne(e => e.AppUser)
                        .WithMany(e => e.CallRecords)
                        .HasForeignKey(e => e.UserId);
            });
            modelBuilder.Entity<Request>(entity =>
            {
                entity.HasOne(d => d.AppUser)
                    .WithMany(p => p.Requests)
                    .HasForeignKey(p => p.UserId);

            });

            modelBuilder.Entity<Report>(entity =>
            {

                entity.HasOne(s => s.CallRecord)
                    .WithOne(l => l.Report);

            });
            
            //ilk migration da admin kullanıcısı tanımladık.
            //AppUser appUsers = new() { Id = Guid.NewGuid().ToString(), Email = "admin@hotmail.com", UserName = "admin", NameSurname = "Yönetici Admin" };
            //modelBuilder.Entity<AppUser>().HasData(appUsers);

            base.OnModelCreating(modelBuilder);

        }

    }
}
