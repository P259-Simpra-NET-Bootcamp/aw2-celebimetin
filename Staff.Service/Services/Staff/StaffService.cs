using Staff.Data.Repositories.Base;
using Staff.Service.Services.Base;
using Kadro = Staff.Data.Domains;

namespace Staff.Service.Services.Staff
{
    public class StaffService : GenericService<Kadro.Staff>, IStaffService
    {
        public StaffService(IGenericRepository<Kadro.Staff> repository) : base(repository)
        {
        }
    }
}