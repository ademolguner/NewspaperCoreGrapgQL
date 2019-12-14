using NewspaaperCoreGrapgQL.Core.DataAccess.EntityFramework;
using NewspaaperCoreGrapgQL.DataAccess.Abstract;
using NewspaaperCoreGrapgQL.DataAccess.Concrete;
using NewspaaperCoreGrapgQL.Entities.Models;

namespace NewspaaperCoreGrapgQL.DataAccess.Concrete.EntityFramework
{
    public class EfPostTagDal : EfEntityRepositoryBase<PostTag, NewspaperContext>, IPostTagDal
    {
    }
}
