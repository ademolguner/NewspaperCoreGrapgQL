﻿using NewspaperCoreGrapgQL.Core.Entities;
using System.Collections.Generic;

namespace NewspaaperCoreGrapgQL.Entities.Models
{
    public class Category: IEntity
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}