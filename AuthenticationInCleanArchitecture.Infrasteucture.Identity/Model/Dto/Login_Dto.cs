﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthenticationInCleanArchitecture.Infrasteucture.Identity.Model.Dto
{
    public class Login_Dto
    {
        public string Password { get; set; }
        public string Email { get; set; }
    }
}
