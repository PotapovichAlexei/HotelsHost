using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelsHost.Models
{
    public class User
    {
        public long Id { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        public Profile Profile { get; set; }

    }
}
