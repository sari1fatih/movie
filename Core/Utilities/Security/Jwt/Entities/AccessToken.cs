﻿using System;

namespace Core.Utilities.Security.Jwt.Entities
{
    public class AccessToken
    {
        public string Token { get; set; }
        public DateTime Expiration { get; set; }
    }
}
