using Microsoft.EntityFrameworkCore;
using NewspaaperCoreGrapgQL.Business.Abstract;
using NewspaaperCoreGrapgQL.Business.Concrete.Manager;
using NewspaaperCoreGrapgQL.DataAccess.Abstract;
using NewspaaperCoreGrapgQL.DataAccess.Concrete;
using NewspaaperCoreGrapgQL.DataAccess.Concrete.EntityFramework;
using Ninject.Modules;

namespace NewspaaperCoreGrapgQL.Business.DependencyResolver.Ninject
{
    public class NinjectBusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IPostService>().To<PostManager>().InSingletonScope();
            Bind<IPostDal>().To<EfPostDal>().InSingletonScope();

            Bind<ICategoryService>().To<CategoryManager>().InSingletonScope();
            Bind<ICategoryDal>().To<EfCategoryDal>().InSingletonScope();

            Bind<ITagService>().To<TagManager>().InSingletonScope();
            Bind<ITagDal>().To<EfTagDal>().InSingletonScope();

            Bind<ICommentService>().To<CommentManager>().InSingletonScope();
            Bind<ICommentDal>().To<EfCommentDal>().InSingletonScope();

            Bind<IPostTagService>().To<PostTagManager>().InSingletonScope();
            Bind<IPostTagDal>().To<EfPostTagDal>().InSingletonScope();

            //Bind(typeof(IQueryableRepository<>)).To(typeof(EfQueryableRepository<>));
            Bind<DbContext>().To<NewspaperContext>();
            //Bind<NHibernateHelper>().To<SqlServerHelper>();


        }
    }
}
