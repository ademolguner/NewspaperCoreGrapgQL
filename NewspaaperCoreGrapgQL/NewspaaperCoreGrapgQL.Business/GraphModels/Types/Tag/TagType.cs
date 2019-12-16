using System;
using System.Collections.Generic;
using System.Text;
using GraphQL.Types;

namespace NewspaperCoreGrapgQL.Business.GraphModels.Types.Tag
{
      
    public class TagType : ObjectGraphType<NewspaaperCoreGrapgQL.Entities.Models.Tag>
    {
        public TagType()
        {
            Field(x => x.TagId);
            Field(x => x.TagName);
        }
    }
}
