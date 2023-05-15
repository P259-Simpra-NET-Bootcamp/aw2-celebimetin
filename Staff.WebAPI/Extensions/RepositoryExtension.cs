using Staff.Data.Repositories.Base;
using Staff.Data.Repositories.Staff;

namespace Staff.WebAPI.Extensions
{
    public static class RepositoryExtension
    {
        public static void AddRepositoryExtension(this IServiceCollection services)
        {
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<IStaffRepository, StaffRepository>();

        }
    }
}