using NewspaaperCoreGrapgQL.Business.Abstract;
using NewspaaperCoreGrapgQL.DataAccess.Abstract;
using NewspaaperCoreGrapgQL.Entities.Models;
using System.Collections.Generic;
using System.Linq;

namespace NewspaaperCoreGrapgQL.Business.Concrete.Manager
{
    public class PostManager : IPostService
    {
        private readonly IPostDal _postDal;
        public PostManager(IPostDal postDal)
        {
            _postDal = postDal;
        }

        public Post Add(Post post)
        {
            _postDal.Add(post);
            return post;
        }

        public void Delete(Post post)
        {
            _postDal.Delete(post);
        }

        public List<Post> GetAll()
        {
            return _postDal.GetList();
        }

        public Post GetById(int id)
        {
            return _postDal.Get(c => c.PostId == id);
        }

        public List<Post> GetPostsByCategoryId(int categoryId)
        {
            return _postDal.GetList(c => c.CategoryId == categoryId);
        }
        
        public List<Post> GetPostsByCategoryId(int categoryId, int lastAmount)
        {
            return _postDal.GetList(c => c.CategoryId == categoryId).Take(lastAmount).ToList();
        }

        public Post Update(Post post)
        {
            _postDal.Update(post);
            return GetById(post.PostId);
        }
    }
}
