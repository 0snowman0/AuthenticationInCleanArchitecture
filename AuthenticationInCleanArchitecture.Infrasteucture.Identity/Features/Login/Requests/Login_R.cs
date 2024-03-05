using AuthenticationInCleanArchitecture.Infrasteucture.Identity.Model.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthenticationInCleanArchitecture.Infrasteucture.Identity.Features.Login.Requests
{
    public class Login_R : IRequest<string>
    {
        public Login_Dto login_Dto { get; set; } = null!;
    }
}
