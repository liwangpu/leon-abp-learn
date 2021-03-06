﻿using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MyAbpLearn.Configuration;

namespace MyAbpLearn.Web.Host.Startup
{
    [DependsOn(
       typeof(MyAbpLearnWebCoreModule))]
    public class MyAbpLearnWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public MyAbpLearnWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MyAbpLearnWebHostModule).GetAssembly());
        }
    }
}
