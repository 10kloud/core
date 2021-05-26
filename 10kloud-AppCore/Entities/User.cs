using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10kloud_AppCore.Entities
{
    /// <summary>
    /// User class contain the database's attributes
    /// the primary key id is ereditated from Entity base
    /// </summary>
    public class User : Entity<int>
    {

        public string UserName { get; set; }

        public string NormalizedUserName { get; set; }


        /// <summary>
        /// user Email
        /// </summary>
        public string Email { get; set; }

        public string NormalizedEmail { get; set; }

        public bool EmailConfirmed { get; set; }

        public string PasswordHash { get; set; }

        public string SecurityStamp { get; set; }

        public string ConcurrencyStamp { get; set; }

        public string PhoneNumber { get; set; }

        public bool PhoneNumberConfirmed { get; set; }

        public bool TwoFactorEnabled { get; set; }

        public DateTime LockoutEnd { get; set; }

        public bool LockoutEnabled { get; set; }

        public int AccessFailedCount { get; set; }


        /// <summary>
        /// User Permission
        /// </summary>
        public int Permission { get; set; }
    }
}
