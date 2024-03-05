using AuthenticationInCleanArchitecture.Infrasteucture.Identity.Model.En;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthenticationInCleanArchitecture.Persistence
{
    public class Context_En : DbContext
    {
        public Context_En(DbContextOptions<Context_En> options)
            : base(options)
        {

        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .ApplyConfigurationsFromAssembly(typeof(Context_En).Assembly);
        }



        public DbSet<User_En> user_Ens { get; set; }
        public DbSet<RefreshToken> refreshTokens { get; set; }

    }
}
