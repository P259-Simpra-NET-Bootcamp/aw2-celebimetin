using Staff.Data.Context;
using Staff.Data.Repositories.Base;
using Kadro = Staff.Data.Domains;

namespace Staff.Data.Repositories.Staff
{
    public class StaffRepository : GenericRepository<Kadro.Staff>, IStaffRepository
    {
        public StaffRepository(StaffDbContext dbContext) : base(dbContext) { }
    }
}