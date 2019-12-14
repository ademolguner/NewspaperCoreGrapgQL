using GraphQL.Types;
using NewspaaperCoreGrapgQL.Business.Abstract;
using NewspaaperCoreGrapgQL.Business.GraphModels.Types.Post;

namespace NewspaaperCoreGrapgQL.Business.GraphModels.Queries
{
    public class PostQuery : ObjectGraphType
    {
        //public PostQuery(IPostRepository postRepository)
        //{
        //    Field<ListGraphType<PostType>>(
        //        "posts",
        //        resolve: context => postRepository.GetAll());

        //    Field<PostType>(
        //        "post",
        //        arguments: new QueryArguments(new QueryArgument<IntGraphType> { Name = "id" }),
        //        resolve: context => postRepository.GetById(context.GetArgument<int>("id"))
        //        );  
        //}
        public PostQuery(IPostService postRepository)
        {
            Field<ListGraphType<PostType>>(
                "posts",
                resolve: context => postRepository.GetAll());

            Field<PostType>(
                "post",
                arguments: new QueryArguments(new QueryArgument<IntGraphType> { Name = "id" }),
                resolve: context => postRepository.GetById(context.GetArgument<int>("id"))
                );
        }
    }
}
