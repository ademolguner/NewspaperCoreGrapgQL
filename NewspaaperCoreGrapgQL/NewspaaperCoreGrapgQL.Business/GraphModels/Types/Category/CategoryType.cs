using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewspaaperCoreGrapgQL.Business.GraphModels.Types.Category
{

    public class CategoryType : ObjectGraphType<Entities.Models.Category>
    {
        public CategoryType()
        {
            Field(x => x.CategoryId);
            Field(x => x.CategoryName);
        }
    }
}
