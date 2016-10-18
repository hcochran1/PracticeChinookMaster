﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinookSystem.Security
{
    public class RoleProfile
    {
        public string RoleID { get; set; }
        public string RoleName { get; set; }
        public IEnumerable<string> Usernames { get; set; }

    }
}
