using AuthenticationInCleanArchitecture.Application.Contracts.Generic;
using AuthenticationInCleanArchitecture.Infrasteucture.Identity.Model.En;

namespace AuthenticationInCleanArchitecture.Infrasteucture.Identity.IdentityService.Abstract
{
    public interface Iuser : IGenericRepository<User_En>
    {
        Task<User_En> GetUserByEmail(string email);
    }
}
