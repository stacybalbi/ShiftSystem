﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftSystem.Domain.Entities
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public bool Deleted { get; set; }

    }
}
