using HrPtoManagement.Web.Data;
using HrPtoManagement.Web.Interfaces;

namespace HrPtoManagement.Web.Repositories
{
    public class PtoTypeRepository : GenericRepository<PtoType>, IPtoTypeRepository
    {
        public PtoTypeRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
