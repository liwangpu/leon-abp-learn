using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace MyAbpLearn.EntityFrameworkCore
{
    public static class MyAbpLearnDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<MyAbpLearnDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString, s => s.UseRowNumberForPaging());
        }

        public static void Configure(DbContextOptionsBuilder<MyAbpLearnDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection, s => s.UseRowNumberForPaging());
        }
    }
}
