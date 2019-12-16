using NewspaaperCoreGrapgQL.Core.DataAccess;
using NewspaaperCoreGrapgQL.Entities.Models;
using System.Collections.Generic;

namespace NewspaaperCoreGrapgQL.DataAccess.Abstract
{

    public interface ITagDal : IEntityRepository<Tag>
    {
        List<Tag> GetPostTags(int postId);
    }
}
