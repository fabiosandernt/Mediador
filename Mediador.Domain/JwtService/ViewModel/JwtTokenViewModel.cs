﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediador.Domain.JwtService.ViewModel
{
    public class JwtTokenViewModel
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
    }
}
