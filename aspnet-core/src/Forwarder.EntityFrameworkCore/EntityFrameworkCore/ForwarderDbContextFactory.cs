using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Forwarder.Configuration;
using Forwarder.Web;

namespace Forwarder.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class ForwarderDbContextFactory : IDesignTimeDbContextFactory<ForwarderDbContext>
    {
        public ForwarderDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ForwarderDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            ForwarderDbContextConfigurer.Configure(builder, configuration.GetConnectionString(ForwarderConsts.ConnectionStringName));

            return new ForwarderDbContext(builder.Options);
        }
    }
}
