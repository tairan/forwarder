using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Forwarder.Authorization.Roles;
using Forwarder.Authorization.Users;
using Forwarder.MultiTenancy;

namespace Forwarder.EntityFrameworkCore
{
    public class ForwarderDbContext : AbpZeroDbContext<Tenant, Role, User, ForwarderDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public ForwarderDbContext(DbContextOptions<ForwarderDbContext> options)
            : base(options)
        {
        }
    }
}
