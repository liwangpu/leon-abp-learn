using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace MyAbpLearn.Localization
{
    public static class MyAbpLearnLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(MyAbpLearnConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(MyAbpLearnLocalizationConfigurer).GetAssembly(),
                        "MyAbpLearn.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
