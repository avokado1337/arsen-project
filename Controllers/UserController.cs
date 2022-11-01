using Flight_booking.Data;
using Flight_booking.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flight_booking.Controllers
{
    [ApiController]
    [Route("api/user")]
    public class UserController : ControllerBase
    {
        ApplicationDbContext _context;
        public UserController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpPost("register")]
        public IActionResult Register(UserRegistration user)
        {
            User newUser = new()
            {
                Email = user.Email,
                Password = user.Password
            };
            _context.Users.Add(newUser);
            _context.SaveChanges();
            return Ok(new { message = "Registration successful" });
        }

        [HttpPost("login")]
        public IActionResult Login(UserRegistration user)
        {
            var findUser = _context.Users.FirstOrDefault(x => x.Email == user.Email);
            if (findUser != null)
            {
                if (findUser.Password != user.Password)
                {
                    return Unauthorized("Password is incorrect");
                }
            }
            else
            {
                return NotFound("User doesn't exist");
            }
            return Ok("Authorization successfull");
        }

    }
}
