using Domain.CallCenter_Case.Entities;
using Domain.CallCenter_Case.Entities.Common;
using Domain.CallCenter_Case.Entities.Identity;
using Microsoft.AspNetCore.Identity;
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
            Guid adminId = Guid.NewGuid();
            Guid adminRoleId = Guid.NewGuid();
            // Create Admin user
            var admin = new AppUser
            {
                Id = adminId.ToString(),
                NameSurname = "admin",
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "admin@example.com",
                NormalizedEmail = "ADMIN@EXAMPLE.COM",
                EmailConfirmed = true,
                LockoutEnabled = false,
                SecurityStamp = Guid.NewGuid().ToString()
            };
            admin.PasswordHash = new PasswordHasher<AppUser>().HashPassword(admin, "123");

            modelBuilder.Entity<AppUser>().HasData(admin);

            // Create Admin role
            modelBuilder.Entity<AppRole>().HasData(new AppRole
            {
                Id = adminRoleId.ToString(),
                Name = "Admin",
                NormalizedName = "ADMIN",
                
            });

            // Assign Admin role to Admin user
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = adminRoleId.ToString(),
                UserId = adminId.ToString()
            });

            base.OnModelCreating(modelBuilder);

        }

    }
}
