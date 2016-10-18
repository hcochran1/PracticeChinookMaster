﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinookSystem.Security
{
    public enum UnRegisteredUserType { Undefined, Employee, Customer}
    public class UnregisteredUserProfile
    {
        public string UserID { get; set; } //generated when user is added 
        public string UserName { get; set; } //collected 
        public string EmailAddress { get; set; } //collected
        public string FirstName { get; set; } //comes from user table
        public string LastName { get; set; } //comes from user table
        public UnRegisteredUserType UserType { get; set; } //
    }
}
