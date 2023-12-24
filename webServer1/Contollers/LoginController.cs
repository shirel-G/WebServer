using Microsoft.AspNetCore.Mvc;
using webServer1.Models;
using webServer1.Repositories.Interfaces;

namespace webServer1.Contollers;

public class LoginController : Controller
{
    private readonly ILoginRepository _loginRepository;

    public LoginController(ILoginRepository loginRepository)
    {
        _loginRepository = loginRepository;
    }

    [HttpGet("CheckUserLogin")]
    public async Task<ActionResult<User>> CheckUserLogin(string username, string password)
    {
        try
        {
            var user = await _loginRepository.UserCheck(username, password);
            return Ok(user);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpPost("SingUp")]
    public async Task<ActionResult<User>> NewUser(User user)
    {
        try
        {
            var newUser = await _loginRepository.AddNewUser(user);
            return Ok(newUser);

        }
        catch(Exception ex)
        {
            return BadRequest(ex.Message);
        }

    }
   

}
