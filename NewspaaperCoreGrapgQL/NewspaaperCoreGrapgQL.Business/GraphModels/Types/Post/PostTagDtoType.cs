using GraphQL.Types;

namespace NewspaperCoreGrapgQL.Business.GraphModels.Types.Post
{


    public class PostTagDtoType : ObjectGraphType<Entities.ComplexTypes.PostTagDto>
    {
        public PostTagDtoType()
        {
            Field(x => x.TagValueName); 
        }
    }
}
