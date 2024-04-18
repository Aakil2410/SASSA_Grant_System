using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using SASSAGrantSystem.Authorization.Roles;
using SASSAGrantSystem.Authorization.Users;
using SASSAGrantSystem.MultiTenancy;

namespace SASSAGrantSystem.EntityFrameworkCore
{
    public class SASSAGrantSystemDbContext : AbpZeroDbContext<Tenant, Role, User, SASSAGrantSystemDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public SASSAGrantSystemDbContext(DbContextOptions<SASSAGrantSystemDbContext> options)
            : base(options)
        {
        }
    }
}
