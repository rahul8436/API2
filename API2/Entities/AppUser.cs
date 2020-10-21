using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API2.Entities
{
    public class AppUser
    {
        public int Id { get; set; }

        public string UserName { get; set; }
        public byte[] Passwordhash { get; set; }
        public byte[] PasswordSalt { get; set; }
    }
}
