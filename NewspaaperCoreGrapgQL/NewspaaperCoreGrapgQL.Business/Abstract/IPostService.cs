using NewspaaperCoreGrapgQL.Entities.Models;
using System.Collections.Generic;

namespace NewspaaperCoreGrapgQL.Business.Abstract
{
    public interface IPostService
    {
        List<Post> GetAll();

        Post GetById(int id);

        Post Add(Post post);

        Post Update(Post post);

        void Delete(Post post);

        List<Post> GetPostsByCategoryId(int categoryId);
        List<Post> GetPostsByCategoryId(int categoryId, int lastAmount);
    }
}
