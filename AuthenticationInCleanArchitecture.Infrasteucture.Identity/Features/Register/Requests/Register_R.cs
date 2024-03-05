using AuthenticationInCleanArchitecture.Infrasteucture.Identity.Model.Dto;
using AuthenticationInCleanArchitecture.Infrasteucture.Identity.Model.En;
using MediatR;

namespace AuthenticationInCleanArchitecture.Infrasteucture.Identity.Features.Register.Requests
{
    public class Register_R : IRequest<User_En>
    {
        public Register_Dto register_Dto { get; set; } = null!;
    }
}
