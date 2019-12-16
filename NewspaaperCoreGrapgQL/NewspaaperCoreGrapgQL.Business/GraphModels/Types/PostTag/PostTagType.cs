using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewspaperCoreGrapgQL.Business.GraphModels.Types.PostTag
{
    

    public class PostTagType : ObjectGraphType<NewspaaperCoreGrapgQL.Entities.Models.PostTag>
    {
        public PostTagType()
        {
            Field(x => x.PostTagId);
            Field(x => x.PostId);
            Field(x => x.TagId);
        }
    }
}
