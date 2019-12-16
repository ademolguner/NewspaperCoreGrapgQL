using NewspaaperCoreGrapgQL.Business.Abstract;
using NewspaaperCoreGrapgQL.DataAccess.Abstract;
using NewspaaperCoreGrapgQL.Entities.Models;
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

        public Tag Add(Tag tag)
        {
            _tagDal.Add(tag);
            return tag;
        }

        public void Delete(Tag tag)
        {
            _tagDal.Delete(tag);
        }

        public List<Tag> GetAll()
        {
            return _tagDal.GetList();
        }

        public Tag GetById(int id)
        {
            return _tagDal.Get(c => c.TagId == id);
        }

        public Tag Update(Tag tag)
        {
            _tagDal.Update(tag);
            return tag;
        }

        public List<Tag> PostTagListForPost(int postID)
        {
            return _tagDal.GetPostTags(postID);
        }
    }
}
