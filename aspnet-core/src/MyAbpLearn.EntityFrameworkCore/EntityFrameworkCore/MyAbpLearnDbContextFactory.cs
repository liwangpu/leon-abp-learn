using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using MyAbpLearn.Configuration;
using MyAbpLearn.Web;

namespace MyAbpLearn.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class MyAbpLearnDbContextFactory : IDesignTimeDbContextFactory<MyAbpLearnDbContext>
    {
        public MyAbpLearnDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<MyAbpLearnDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            MyAbpLearnDbContextConfigurer.Configure(builder, configuration.GetConnectionString(MyAbpLearnConsts.ConnectionStringName));

            return new MyAbpLearnDbContext(builder.Options);
        }
    }
}
