using NewspaperCoreGrapgQL.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewspaaperCoreGrapgQL.Entities.Models
{
    public class Tag : IEntity
    {
        public int TagId { get; set; }
        public string TagName { get; set; }

    }
}
