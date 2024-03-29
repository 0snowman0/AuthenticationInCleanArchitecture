﻿using AuthenticationInCleanArchitecture.Infrasteucture.Identity.Features.Login.Requests;
using AuthenticationInCleanArchitecture.Infrasteucture.Identity.Features.Register.Requests;
using AuthenticationInCleanArchitecture.Infrasteucture.Identity.IdentityService.Abstract;
using AuthenticationInCleanArchitecture.Infrasteucture.Identity.Model.Dto;
using AuthenticationInCleanArchitecture.Infrasteucture.Identity.Model.En;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AuthenticationInCleanArchitecture.Api.Controllers.Identity
{
    public class AuthController
    {
        private readonly IMediator _mediator;
        private readonly IUserService _userService;

        public AuthController(IMediator mediator, IUserService userService)
        {
            _mediator = mediator;
            _userService = userService;
        }

        [Authorize]
        [HttpGet("getMe")]
        public async Task<ActionResult<string>> GetMe()
        {
            var responce = _userService.GetMyName();
            return responce;
        }


        [HttpPost("register")]
        public async Task<ActionResult<User_En>> Register(Register_Dto request)
        {
            var responce = await _mediator.Send(new Register_R { register_Dto = request });
            return responce;
        }

        [HttpPost("login")]
        public async Task<ActionResult<string>> Login(Login_Dto request)
        {
            var responce = await _mediator.Send(new Login_R { login_Dto = request });
            return responce;
        }
    }
}
