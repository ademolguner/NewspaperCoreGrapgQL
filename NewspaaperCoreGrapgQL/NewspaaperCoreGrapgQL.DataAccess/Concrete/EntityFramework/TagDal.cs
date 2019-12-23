using NewspaaperCoreGrapgQL.Core.DataAccess.EntityFramework;
using NewspaaperCoreGrapgQL.DataAccess.Abstract;
using NewspaaperCoreGrapgQL.DataAccess.Concrete;
using NewspaaperCoreGrapgQL.Entities.Models;
using NewspaperCoreGrapgQL.Entities.ComplexTypes;
using System.Collections.Generic;
using System.Linq;

namespace NewspaaperCoreGrapgQL.DataAccess.Concrete.EntityFramework
{
    public class TagDal : EntityRepositoryBase<Tag, NewspaperContext>, ITagDal
    {
        public List<PostTagDto> GetPostTags(int postId)
        {
            using (NewspaperContext context = new NewspaperContext())
            {
                var tagNameList = from pt in context.PostTag
                                  join p in context.Post
                                  on pt.PostId equals p.PostId
                                  join t in context.Tag
                                  on pt.TagId equals t.TagId
                                  where p.PostId == postId
                                  select new PostTagDto { TagValueName = t.TagName};
                return tagNameList.ToList();
            }
        }
    }
}
