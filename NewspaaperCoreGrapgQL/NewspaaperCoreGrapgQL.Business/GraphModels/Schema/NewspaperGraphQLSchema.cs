using GraphQL;
using NewspaaperCoreGrapgQL.Business.GraphModels.Mutations;
using NewspaaperCoreGrapgQL.Business.GraphModels.Queries;

namespace NewspaaperCoreGrapgQL.Business.GraphModels.Schema
{
    public class NewspaperGraphQLSchema : GraphQL.Types.Schema
    {
        public NewspaperGraphQLSchema(IDependencyResolver resolver)
            : base(resolver)
        {
            Query = resolver.Resolve<PostQuery>();
            Mutation = resolver.Resolve<PostMutation>();
        }


    }
}
