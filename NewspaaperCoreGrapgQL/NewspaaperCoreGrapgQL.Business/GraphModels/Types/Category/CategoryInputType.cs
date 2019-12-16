using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewspaperCoreGrapgQL.Business.GraphModels.Types.Category
{
    
    public class CategoryInputType : InputObjectGraphType
    {
        public CategoryInputType()
        {
            Field<NonNullGraphType<StringGraphType>>("categoryname");
        }
    }
}
