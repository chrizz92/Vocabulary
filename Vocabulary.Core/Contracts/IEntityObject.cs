﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Contracts
{
    public interface IEntityObject
    {
        public int Id { get; set; }
        public byte[] Timestamp { get; set; }
    }
}
