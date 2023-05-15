using Staff.Service.Services.Base;
using Staff.Service.Services.Staff;

namespace Staff.WebAPI.Extensions
{
    public static class ServiceExtension
    {
        public static void AddServiceExtension(this IServiceCollection services)
        {
            services.AddScoped(typeof(IGenericService<>), typeof(GenericService<>));
            services.AddScoped<IStaffService, StaffService>();
        }
    }
}