using BackEnd.Entities;
// using Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BackEnd.Data
{
    public class DataContext : IdentityDbContext<
    ApiUser,
    ApiRole,
    int,
    IdentityUserClaim<int>,
    ApiUserRole,
    IdentityUserLogin<int>,
    IdentityRoleClaim<int>,
    IdentityUserToken<int>>
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<OldCeshtja> OldCeshtja { get; set; }
        public DbSet<BulkCreateReport> BulkCreateReport { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<ApiUser>().HasMany(ur => ur.UserRoles).WithOne(u => u.User).HasForeignKey(u => u.UserId).IsRequired();
            builder.Entity<ApiRole>().HasMany(ur => ur.UserRoles).WithOne(r => r.Role).HasForeignKey(r => r.RoleId).IsRequired();
        }
    }
}