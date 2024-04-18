using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace SASSAGrantSystem.Localization
{
    public static class SASSAGrantSystemLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(SASSAGrantSystemConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(SASSAGrantSystemLocalizationConfigurer).GetAssembly(),
                        "SASSAGrantSystem.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
