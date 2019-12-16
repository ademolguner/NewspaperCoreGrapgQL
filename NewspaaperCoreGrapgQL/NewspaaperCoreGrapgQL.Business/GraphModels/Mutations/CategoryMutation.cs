using GraphQL.Types;
using NewspaaperCoreGrapgQL.Business.Abstract;
using NewspaaperCoreGrapgQL.Business.GraphModels.Types.Category;
using NewspaaperCoreGrapgQL.Entities.Models;
using NewspaperCoreGrapgQL.Business.GraphModels.Types.Category;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewspaperCoreGrapgQL.Business.GraphModels.Mutations
{
  public    class CategoryMutation : ObjectGraphType<object>
    {

        public CategoryMutation(ICategoryService categoryService)
        {
            Field<CategoryType>(
                "addCategory",
                arguments: new QueryArguments(
                     new QueryArgument<NonNullGraphType<CategoryInputType>>
                     {
                         Name = "category",
                         Description = "Category added input"
                     }),
                resolve: context =>
                {
                    var category = context.GetArgument<Category>("category");
                    return categoryService.Add(category);
                }
                          );
        }
    }
}
