﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediador.Domain.BaseEntity
{
    public  class Entity<T>
    {
        public T Id { get; set; }
    }
}
