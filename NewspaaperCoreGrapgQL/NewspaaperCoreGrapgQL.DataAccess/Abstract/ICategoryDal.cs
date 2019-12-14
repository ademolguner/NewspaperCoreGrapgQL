using NewspaaperCoreGrapgQL.Core.DataAccess;
using NewspaaperCoreGrapgQL.Entities.Models;

namespace NewspaaperCoreGrapgQL.DataAccess.Abstract
{
    public interface ICategoryDal : IEntityRepository<Category>
    {
    }
}
