using Staff.Data.Repositories.Base;
using Kadro = Staff.Data.Domains;

namespace Staff.Data.Repositories.Staff
{
    public interface IStaffRepository : IGenericRepository<Kadro.Staff>
    {
    }
}