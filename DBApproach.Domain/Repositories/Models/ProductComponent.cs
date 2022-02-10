﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DBApproach.Domain.Repositories.Models
{
    public partial class ProductComponent
    {
        public int Id { get; set; }
        public string ProductId { get; set; }
        public string ComponentId { get; set; }
        public int? Amount { get; set; }

        public virtual Component Component { get; set; }
        public virtual Product Product { get; set; }
    }
}
