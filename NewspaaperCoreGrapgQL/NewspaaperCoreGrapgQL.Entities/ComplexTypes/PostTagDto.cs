using NewspaaperCoreGrapgQL.Entities.Models;
using NewspaperCoreGrapgQL.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewspaperCoreGrapgQL.Entities.ComplexTypes
{
   public class PostTagDto : IEntity
    {
        public string TagValueName { get; set; }
    }
}
