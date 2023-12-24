using Microsoft.AspNetCore.Mvc;
using webServer1.Models;

namespace webServer1.Repositories.Interfaces;

public interface ILoginRepository
{
    Task<ActionResult<User>> UserCheck(string username, string password);
   
}
