using Business.Interfaces;
using Data.Data;
using Data.Models;
using Full_Stack_Task.DTOs;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class UserService(AppDbContext dbContext, ITokenService tokenService, PasswordHasher<User> passwordHasher) : IUserService
    {
        public string Login(LoginDto loginDto)
        {
            var user = dbContext.Users.FirstOrDefault(u=>u.Username == loginDto.UserName);
            if (user == null)
            {
                throw new Exception("User not found");
            }
            var result = passwordHasher.VerifyHashedPassword(user, user.Password, loginDto.Password);

            if (result != PasswordVerificationResult.Success)
                throw new Exception("Incorrect username or password");

            user.LastLoginTime = DateTime.Now; //set the last login time
            dbContext.SaveChanges();
            return tokenService.GenerateToken(user.Username, user.Password);
        }

        public User Register(RegisterDto dto)
        {
            if(dbContext.Users.Any(u => u.Username == dto.UserName))
               throw new Exception("Username already exists");

            if (dbContext.Users.Any(u => u.Email == dto.Email))
                throw new Exception("Email already exists");

            var user = new User
            {
                Username = dto.UserName,
                Email = dto.Email,
                //Password = passwordHasher.HashPassword(user,dto.Password),
                LastLoginTime = null // Initial value for new user
            };
            user.Password = passwordHasher.HashPassword(user, dto.Password);
            dbContext.Users.Add(user);
            dbContext.SaveChanges();
            return user;
        }

        


    }
}
