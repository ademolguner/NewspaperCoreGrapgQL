using NewspaaperCoreGrapgQL.Entities.Models;
using System.Collections.Generic;

namespace NewspaaperCoreGrapgQL.Business.Abstract
{
    public interface ITagService
    {
        List<Tag> GetAll();

        Tag GetById(int id);

        Tag Add(Tag tag);

        Tag Update(Tag tag);

        void Delete(Tag tag);
        List<Tag> PostTagListForPost(int postID);
    }
}
