using GraphiQl;
using GraphQL;
using GraphQL.Types;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NewspaaperCoreGrapgQL.Business.Abstract;
using NewspaaperCoreGrapgQL.Business.Concrete.Manager;
using NewspaaperCoreGrapgQL.Business.GraphModels.Queries;
using NewspaaperCoreGrapgQL.Business.GraphModels.Schema;
using NewspaaperCoreGrapgQL.Business.GraphModels.Types.Category;
using NewspaaperCoreGrapgQL.Business.GraphModels.Types.Comment;
using NewspaaperCoreGrapgQL.Business.GraphModels.Types.Post;
using NewspaaperCoreGrapgQL.DataAccess.Abstract;
using NewspaaperCoreGrapgQL.DataAccess.Concrete;
using NewspaaperCoreGrapgQL.DataAccess.Concrete.EntityFramework;
using NewspaperCoreGrapgQL.Business.GraphModels.Newspaper;
using NewspaperCoreGrapgQL.Business.GraphModels.Types.Category;
using NewspaperCoreGrapgQL.Business.GraphModels.Types.Post;
using NewspaperCoreGrapgQL.Business.GraphModels.Types.PostTag;
using NewspaperCoreGrapgQL.Business.GraphModels.Types.Tag;

namespace NewspaaperCoreGrapgQL.GraphWebAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            
            services.AddTransient<IPostService, PostManager>();
            services.AddTransient<IPostDal, PostDal>();
            services.AddTransient<ICategoryService, CategoryManager>();
            services.AddTransient<ICategoryDal, CategoryDal>();
            services.AddTransient<ITagService, TagManager>();
            services.AddTransient<ITagDal, TagDal>();
            services.AddTransient<ICommentService, CommentManager>();
            services.AddTransient<ICommentDal, CommentDal>();
            services.AddTransient<IPostTagService, PostTagManager>();
            services.AddTransient<IPostTagDal, PostTagDal>();
            services.AddDbContext<NewspaperContext>(options => options.UseSqlServer(Configuration["ConnectionStrings:NewspaperDb"]));
            
            services.AddSingleton<IDocumentExecuter, DocumentExecuter>();

            services.AddSingleton<NewspaperQuery>();
            services.AddSingleton<NewspaperMutation>();
            services.AddSingleton<PostQuery>();
            services.AddSingleton<CategoryQuery>();

            services.AddSingleton<PostType>();
            services.AddSingleton<PostInputType>();
            services.AddSingleton<CategoryInputType>();
            services.AddSingleton<CommentType>();
            services.AddSingleton<CategoryType>();
            services.AddSingleton<PostTagType>();
            services.AddSingleton<TagType>();
            services.AddSingleton<PostTagDtoType>();

            services.AddSingleton<IDependencyResolver>(_ => new FuncDependencyResolver(_.GetRequiredService));
            services.AddSingleton<ISchema, NewspaperGraphQLSchema>();
             

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }
            app.UseGraphiQl();
            app.UseHttpsRedirection();
            app.UseMvc();
           
        }
    }
}
