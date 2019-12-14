using GraphQL.Types;
using NewspaaperCoreGrapgQL.Business.Abstract;
using NewspaaperCoreGrapgQL.Business.GraphModels.Types.Post;
using NewspaaperCoreGrapgQL.Entities.Models;

namespace NewspaaperCoreGrapgQL.Business.GraphModels.Mutations
{
    public class PostMutation : ObjectGraphType
    {
        //public PostMutation(IPostRepository postRepository)
        //{
        //    Field<PostType>(
        //        "addPost",
        //        arguments: new QueryArguments(new QueryArgument<NonNullGraphType<PostInputType>>
        //        { Name = "post" }),
        //        resolve: context =>
        //        {
        //            var post = context.GetArgument<Post>("post");
        //            return postRepository.Add(post);
        //        }
        //        );
        //}

        public PostMutation(IPostService postRepository)
        {
            Field<PostType>(
                "addPost",
                arguments: new QueryArguments(new QueryArgument<NonNullGraphType<PostInputType>>
                { Name = "post" }),
                resolve: context =>
                {
                    var post = context.GetArgument<Post>("post");
                    return postRepository.Add(post);
                }
                );
        }
    }
}
