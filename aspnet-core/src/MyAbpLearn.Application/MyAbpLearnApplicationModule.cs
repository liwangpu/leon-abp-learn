using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MyAbpLearn.Authorization;

namespace MyAbpLearn
{
    [DependsOn(
        typeof(MyAbpLearnCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class MyAbpLearnApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<MyAbpLearnAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(MyAbpLearnApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
