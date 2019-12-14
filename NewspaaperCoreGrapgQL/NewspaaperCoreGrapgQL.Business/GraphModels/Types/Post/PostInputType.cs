using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewspaaperCoreGrapgQL.Business.GraphModels.Types.Post
{
    public class PostInputType : InputObjectGraphType
    {
        public PostInputType()
        {
            Field<NonNullGraphType<StringGraphType>>("title");
            Field<StringGraphType>("context");
            Field<DateTimeGraphType>("createdDate");
            Field<BooleanGraphType>("isActive");
            Field<IntGraphType>("categoryId");
            Field<IntGraphType>("readCount");
        }
    }
}
