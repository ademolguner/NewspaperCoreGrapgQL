using GraphQL.Types;
using NewspaaperCoreGrapgQL.Business.Abstract;
using NewspaaperCoreGrapgQL.Business.GraphModels.Types.Category;
using NewspaaperCoreGrapgQL.Business.GraphModels.Types.Comment;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewspaaperCoreGrapgQL.Business.GraphModels.Types.Post
{


    public class PostType : ObjectGraphType<Entities.Models.Post>
    {
        //public PostType(ICommentRepository commentRepository, ICategoryRepository categoryRepository)
        //{
        //    Field(x => x.PostId);
        //    Field(x => x.Title);
        //    Field(x => x.Content);
        //    Field(x => x.CreatedDate);
        //    Field(x => x.IsActive);
        //    Field(x => x.CategoryId);
        //    Field<ListGraphType<CommentType>>("comments",
        //        arguments: new QueryArguments(new QueryArgument<IntGraphType> { Name = "last" }),
        //        resolve: context =>
        //        {
        //            var lastItemFilter = context.GetArgument<int?>("last");
        //            return lastItemFilter != null
        //            ? commentRepository.GetCommentsByPostId(context.Source.PostId, lastItemFilter.Value)
        //            : commentRepository.GetCommentsByPostId(context.Source.PostId);
        //        });

        //    Field<CategoryType>("categoriy",
        //        resolve: context =>
        //        {
        //            return categoryRepository.GetById(context.Source.CategoryId);
        //        });
        //}

        public PostType(ICommentService commentRepository, ICategoryService categoryRepository)
        {
            Field(x => x.PostId);
            Field(x => x.Title);
            Field(x => x.Content);
            Field(x => x.CreatedDate);
            Field(x => x.IsActive);
            Field(x => x.CategoryId);
            Field<ListGraphType<CommentType>>("comments",
                arguments: new QueryArguments(new QueryArgument<IntGraphType> { Name = "last" }),
                resolve: context =>
                {
                    var lastItemFilter = context.GetArgument<int?>("last");
                    return lastItemFilter != null
                    ? commentRepository.GetCommentsByPostId(context.Source.PostId, lastItemFilter.Value)
                    : commentRepository.GetCommentsByPostId(context.Source.PostId);
                });

            Field<CategoryType>("categoriy",
                resolve: context =>
                {
                    return categoryRepository.GetById(context.Source.CategoryId);
                });
        }
    }
}
