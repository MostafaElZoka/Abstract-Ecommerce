using Data.Models;
using Full_Stack_Task.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface IUserService
    {
        User Register(RegisterDto dto);
        
        string Login(LoginDto loginDto);
    }
}
