using NewspaaperCoreGrapgQL.Business.Abstract;
using NewspaaperCoreGrapgQL.DataAccess.Abstract;
using NewspaaperCoreGrapgQL.Entities.Models;
using NewspaperCoreGrapgQL.Entities.ComplexTypes;
using System.Collections.Generic;

namespace NewspaaperCoreGrapgQL.Business.Concrete.Manager
{
    public class TagManager : ITagService
    {
        private readonly ITagDal _tagDal;
        public TagManager(ITagDal tagDal)
        {
            _tagDal = tagDal;
        }

        public Tag AddTag(Tag tag)
        {
            _tagDal.Add(tag);
            return tag;
        }

        public void DeleteTag(Tag tag)
        {
            _tagDal.Delete(tag);
        }

        public List<Tag> GetAllTags()
        {
            return _tagDal.GetList();
        }

        public Tag GetTagById(int id)
        {
            return _tagDal.Get(c => c.TagId == id);
        }

        public Tag UpdateTag(Tag tag)
        {
            _tagDal.Update(tag);
            return tag;
        }

        public List<PostTagDto> PostTagListForPost(int postID)
        {
            return _tagDal.GetPostTags(postID);
        }
    }
}
