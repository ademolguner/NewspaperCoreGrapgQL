using GraphQL.Types;
using NewspaaperCoreGrapgQL.Business.Abstract;
using NewspaaperCoreGrapgQL.Business.GraphModels.Types.Category;
using NewspaaperCoreGrapgQL.Business.GraphModels.Types.Comment;
using NewspaperCoreGrapgQL.Business.GraphModels.Types.Post;
using NewspaperCoreGrapgQL.Business.GraphModels.Types.Tag;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewspaaperCoreGrapgQL.Business.GraphModels.Types.Post
{
    public class PostType : ObjectGraphType<Entities.Models.Post>
    {
        public PostType(ICommentService commentRepository, ICategoryService categoryRepository, ITagService tagService)
        {
            Field(x => x.PostId);
            Field(x => x.Title,nullable:false).Description("Başlık");
            Field(x => x.Content).Description("İçerik");
            Field(x => x.CreatedDate, nullable:true).DefaultValue(DateTime.Now).Description("Oluşturulma zamanı");
            Field(x => x.IsActive, nullable: true).DefaultValue(true);
            Field(x => x.CategoryId);

            Field<ListGraphType<CommentType>>(
                "comments",
                arguments: new QueryArguments(new QueryArgument<IntGraphType> { Name = "last" }),
                resolve: context =>
                {
                    var lastItemFilter = context.GetArgument<int?>("last");
                    return lastItemFilter != null
                    ? commentRepository.GetCommentsByPostId(context.Source.PostId, lastItemFilter.Value)
                    : commentRepository.GetCommentsByPostId(context.Source.PostId);
                });

            Field<CategoryType>("category",
                resolve: context =>
                {
                    return categoryRepository.GetById(context.Source.CategoryId);
                });

            Field<IntGraphType>("commentCount",
                resolve: context =>
                {
                    return commentRepository.GetCommentsByPostId(context.Source.PostId).Count;
                });

            Field<ListGraphType<PostTagDtoType>>("posttags",
            resolve: context =>
            {
                return tagService.PostTagListForPost(context.Source.PostId);
            });
        }
    }
}
