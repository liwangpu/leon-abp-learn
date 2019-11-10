using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using MyAbpLearn.Authorization.Roles;
using MyAbpLearn.Authorization.Users;
using MyAbpLearn.MultiTenancy;

namespace MyAbpLearn.EntityFrameworkCore
{
    public class MyAbpLearnDbContext : AbpZeroDbContext<Tenant, Role, User, MyAbpLearnDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public MyAbpLearnDbContext(DbContextOptions<MyAbpLearnDbContext> options)
            : base(options)
        {
        }
    }
}
