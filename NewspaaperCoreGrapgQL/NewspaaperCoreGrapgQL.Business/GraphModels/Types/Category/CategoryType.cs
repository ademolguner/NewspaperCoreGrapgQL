using GraphQL.Types;
using NewspaaperCoreGrapgQL.Business.Abstract;
using NewspaaperCoreGrapgQL.Business.GraphModels.Types.Post;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewspaaperCoreGrapgQL.Business.GraphModels.Types.Category
{

    public class CategoryType : ObjectGraphType<Entities.Models.Category>
    {
        public CategoryType(IPostService postService)
        {
            Name = "Category";
            Field(x => x.CategoryId).Description("Category id."); ;
            Field(x => x.CategoryName, nullable: false).Description("Category Name."); ;

            Field<ListGraphType<PostType>>("postlist",
            resolve: context =>
            {
                return postService.GetPostsByCategoryId(context.Source.CategoryId);
            });
        }
    }
}
