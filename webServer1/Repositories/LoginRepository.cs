using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using webServer1.Db_Context;
using webServer1.Models;
using webServer1.Repositories.Interfaces;

namespace webServer1.Repositories;

public class LoginRepository : ILoginRepository
{
    private ServerContext _context;
    public LoginRepository(ServerContext context)
    {
        _context = context;
    }

    public async Task<ActionResult<User>> UserCheck(string userID, string password)
    {
        try
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.UserId == userID);
            if (user == null)
            {
                throw new Exception($"User ID {userID} not found");
            }
            if(password != user.Password)
            {
                throw new Exception("Password is incorrect");
            }
            return user;
        }
        catch (Exception ex)
        {
            throw new Exception("Context error");
        }
    }

    public async Task<ActionResult<User>> AddNewUser(User user)
    {
        var userCheck = await _context.Users.FirstOrDefaultAsync(dataBaseUsers => dataBaseUsers.UserId == user.UserId);
        if(userCheck != null)
        {
            throw new Exception($"User Id {user.UserId} already exist");
        }
        return await _context.Users.AddAsync(user);
    }
}
