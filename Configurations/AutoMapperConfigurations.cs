using AutoMapper;

namespace SpanishFootballLeague.Configurations
{
    public class AutoMapperConfigurations
    {
        public static void Configure()
        {
            Mapper.Initialize(x =>
            {
                x.AddProfile<MappingProfiles>();
            });

            Mapper.Configuration.AssertConfigurationIsValid();
        }
    }
}