using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MyAbpLearn.Configuration;
using MyAbpLearn.EntityFrameworkCore;
using MyAbpLearn.Migrator.DependencyInjection;

namespace MyAbpLearn.Migrator
{
    [DependsOn(typeof(MyAbpLearnEntityFrameworkModule))]
    public class MyAbpLearnMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public MyAbpLearnMigratorModule(MyAbpLearnEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(MyAbpLearnMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                MyAbpLearnConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MyAbpLearnMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
