using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthenticationInCleanArchitecture.Infrasteucture.Identity.IdentityService.Abstract
{
    public interface IUserService
    {
        string GetMyName();
        string GetEmail();
    }
}
