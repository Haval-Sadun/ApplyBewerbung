using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace ApplySys.Persistence
{
    public class ApplyManagmentDbContextFactory : IDesignTimeDbContextFactory<ApplyManagementDbContext>
    {
        public ApplyManagementDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var builder = new DbContextOptionsBuilder<ApplyManagementDbContext>();
            var connectionString = configuration.GetConnectionString("ApplySysConnectionString");

            builder.UseSqlServer(connectionString);


            return new ApplyManagementDbContext(builder.Options);

        }
    }
}
