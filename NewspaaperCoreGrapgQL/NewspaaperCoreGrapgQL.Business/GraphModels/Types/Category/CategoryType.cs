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
        public CategoryType(IPostService postService )
        {
            Name = "Category";
            Field(x => x.CategoryId);
            Field(x => x.CategoryName);

            Field<ListGraphType<PostType>>("postlist",
            resolve: context =>
            {
                return postService.GetPostsByCategoryId(context.Source.CategoryId);
            });
        }
    }
}
