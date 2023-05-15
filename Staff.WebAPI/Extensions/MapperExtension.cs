using AutoMapper;
using Staff.Service.Mappings;

namespace Staff.WebAPI.Extensions
{
    public static class MapperExtension
    {
        public static void AddMapperExtension(this IServiceCollection services)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new MapProfile());
            });
            services.AddSingleton(config.CreateMapper());
        }
    }
}