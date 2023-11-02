﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SASSTS.Business.Security.JWT
{
    public class TokenOptions
    {
        public string? Audience { get; set; }
        public string? Issuer { get; set; }
        public int TokenExpiration { get ; set; }
        public string? SecurityKey { get; set; }
    }
}
