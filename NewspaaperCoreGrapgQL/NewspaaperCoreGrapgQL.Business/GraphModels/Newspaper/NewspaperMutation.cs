using GraphQL.Types;
using NewspaaperCoreGrapgQL.Business.Abstract;
using NewspaaperCoreGrapgQL.Business.GraphModels.Types.Category;
using NewspaaperCoreGrapgQL.Business.GraphModels.Types.Post;
using NewspaaperCoreGrapgQL.Entities.Models;
using NewspaperCoreGrapgQL.Business.GraphModels.Types.Category;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewspaperCoreGrapgQL.Business.GraphModels.Newspaper
{
    public class NewspaperMutation : ObjectGraphType<object>
    {

        public NewspaperMutation(IPostService postRepository,ICategoryService categoryService)
        {
            Field<PostType>(
                "addPost",
                arguments: new QueryArguments(
                     new QueryArgument<NonNullGraphType<PostInputType>>
                     {
                         Name = "post",
                         Description = "Acıklama yazılabilir"
                     }),
                resolve: context =>
                {
                    var post = context.GetArgument<Post>("post");
                    return postRepository.Add(post);
                }
                          );
        
            Field<CategoryType>(
                "addCategory",
                arguments: new QueryArguments(
                     new QueryArgument<NonNullGraphType<CategoryInputType>>
                     {
                         Name = "category",
                         Description = "Category added input"
                     }),
                resolve: context =>
                {
                    var category = context.GetArgument<Category>("category");
                    return categoryService.Add(category);
                }
                          );
        }
    }
}
