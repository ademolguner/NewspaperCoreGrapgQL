using GraphQL.Types;
using NewspaaperCoreGrapgQL.Business.Abstract;
using NewspaaperCoreGrapgQL.Business.GraphModels.Queries;
using NewspaaperCoreGrapgQL.Business.GraphModels.Types.Category;
using NewspaaperCoreGrapgQL.Business.GraphModels.Types.Post;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewspaperCoreGrapgQL.Business.GraphModels.Newspaper
{
   public class NewspaperQuery: ObjectGraphType<object>
    {
        public NewspaperQuery(IPostService postRepository,ICategoryService categoryRepository)
        {
            Name = "Newspaper_Query";
            Field<ListGraphType<PostType>>(
                "PostList",
                resolve: context => postRepository.GetAll());

            Field<PostType>(
                "PostInfo",
                arguments: new QueryArguments(new QueryArgument<IntGraphType> { Name = "id" }),
                resolve: context => postRepository.GetById(context.GetArgument<int>("id"))
                );

            Field<ListGraphType<CategoryType>>(
                "CategoryList",
                resolve: context => categoryRepository.GetAll());

            Field<CategoryType>(
                "CategoryInfo",
                arguments: new QueryArguments(new QueryArgument<IntGraphType> { Name = "id" }),
                resolve: context => categoryRepository.GetById(context.GetArgument<int>("id"))
                );
        }
    }
}
