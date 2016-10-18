using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinookSystem.Security
{
    public class UserProfile
    {
        public string UserID {get; set;} //AspNetUser
        public string UserName { get; set; }//AspNetUser
        public int? EmployeeID { get; set; }//AspNetUser
        public int? CustomerID { get; set; }//AspNetUser
        public string FirstName { get; set; } //Employee or Customer Table
        public string LastName { get; set; } //Employee or Customer Table
        public string EmailAddress { get; set; } //AspNetUser 
        public string EmailConfirmation { get; set; } //AspNetUser
        public IEnumerable<string> RoleMemberships { get; set; } 
    }
}
