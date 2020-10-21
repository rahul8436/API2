using API2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API2.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}
