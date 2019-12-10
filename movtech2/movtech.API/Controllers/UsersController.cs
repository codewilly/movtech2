using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using movtech.Domain.Contracts.User;
using movtech.Domain.Entities;
using movtech.Domain.Interfaces.Services;

namespace movtech.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {

        #region Config

        private readonly IUserService _service;

        public UsersController(IUserService service)
        {
            _service = service;
        }

        #endregion

        [HttpPost("login")]
        public IActionResult Login(UserLoginRequest request)
        {
            if (ModelState.IsValid)
            {
                var login = _service.Login(request.CPF, request.Password);

                return Ok(login);

            }

            return BadRequest();
        }

        [HttpPost("register")]
        public IActionResult Register(UserRegisterRequest request)
        {

            if (request.Password == request.ConfirmPassword)
            {
                var user = new User()
                {
                    CPF = request.CPF,
                    //Password = HashPassword(request.Password),      
                    Password = request.Password,
                    Email = request.Email,
                    Name = request.Name
                };

                _service.Register(user);

                return Ok();
            }
            else
            {
                throw new Exception("As senhas não batem");
            }


        }


        private string HashPassword(string password)
        {
            // generate a 128-bit salt using a secure PRNG
            byte[] salt = new byte[128 / 8];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }

            // derive a 256-bit subkey (use HMACSHA1 with 10,000 iterations)
            string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: password,
                salt: salt,
                prf: KeyDerivationPrf.HMACSHA1,
                iterationCount: 10000,
                numBytesRequested: 256 / 8));

            return hashed;
        }
    }
}