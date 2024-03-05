using AuthenticationInCleanArchitecture.Infrasteucture.Identity.IdentityService.Abstract;
using AuthenticationInCleanArchitecture.Infrasteucture.Identity.Model.En;
using AuthenticationInCleanArchitecture.Persistence.Repositories.Generic;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthenticationInCleanArchitecture.Persistence.Repositories
{
    public class User_Rep : GenericRepository<User_En>, Iuser
    {
        private readonly Context_En _context;

        public User_Rep(Context_En context)
            : base(context)
        {
            _context = context;
        }

        public async Task<User_En?> GetUserByEmail(string email)
        {
            return await _context.user_Ens.FirstOrDefaultAsync(p => p.Email == email);
        }
    }
}
