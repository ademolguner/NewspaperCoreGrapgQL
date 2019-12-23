using GraphQL;
using NewspaaperCoreGrapgQL.Business.GraphModels.Mutations;
using NewspaaperCoreGrapgQL.Business.GraphModels.Queries;
using NewspaperCoreGrapgQL.Business.GraphModels.Newspaper;

namespace NewspaaperCoreGrapgQL.Business.GraphModels.Schema
{
    public class NewspaperGraphQLSchema : GraphQL.Types.Schema
    {
        public NewspaperGraphQLSchema(IDependencyResolver resolver): base(resolver)
        {
            Query = resolver.Resolve<NewspaperQuery>();
            Mutation = resolver.Resolve<NewspaperMutation>();
        }
    }
}
