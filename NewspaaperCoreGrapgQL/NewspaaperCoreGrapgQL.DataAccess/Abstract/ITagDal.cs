using NewspaaperCoreGrapgQL.Core.DataAccess;
using NewspaaperCoreGrapgQL.Entities.Models;
using NewspaperCoreGrapgQL.Entities.ComplexTypes;
using System.Collections.Generic;

namespace NewspaaperCoreGrapgQL.DataAccess.Abstract
{

    public interface ITagDal : IEntityRepository<Tag>
    {
        List<PostTagDto> GetPostTags(int postId);
    }
}

