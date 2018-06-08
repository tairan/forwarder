using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Forwarder.EntityFrameworkCore
{
    public static class ForwarderDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<ForwarderDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<ForwarderDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
