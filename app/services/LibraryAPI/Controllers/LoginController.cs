﻿using LibraryAPI.Request;
using LibraryAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ILoginService _loginService;

        public LoginController(ILoginService loginService)
        {
            _loginService = loginService;
        }

        [HttpPost]
        public async Task<ActionResult> LoginUser(LoginRequest request)
        {
            var token = await _loginService.LoginUser(request.Username, request.Password);
            if (token == null)
            {
                return BadRequest();
            }
            return Ok(new { token = token });
        }

        [HttpPost]
        [Route("/api/Register")]
        public async Task<ActionResult> RegisterUser([FromQuery] string email)
        {
            await _loginService.RegisterUser(email);
            
            return Ok();
        }

        [HttpGet]
        [Route("/api/Register")]
        public async Task<ActionResult> GetRegistrations()
        {
            var response = await _loginService.GetRegistrations();

            return Ok(response);
        }
    }
}
