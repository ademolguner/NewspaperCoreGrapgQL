using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewspaaperCoreGrapgQL.Business.GraphModels.Types.Comment
{


    public class CommentType : ObjectGraphType<Entities.Models.Comment>
    {
        public CommentType()
        {
            Field(x => x.CommentId);
            Field(x => x.CommentContent);
            Field(x => x.CommentDate);
            Field(x => x.IsDelete);
            Field(x => x.GuestFullName);
        }
    }
}
