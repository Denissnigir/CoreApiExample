using System.Net;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebApplication2.Classes;
using WebApplication2.Model;

namespace WebApplication2.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : Controller
{
    [HttpPost("AuthUser")]
    public ActionResult Auth(string login, string password)
    {
        var user = Context._con.Users.FirstOrDefault(p => p.Password == password && p.Login == login);
        if (user != null)
        {
            return Ok(user);
        }
        else
        {
            return NotFound();
        }
    }
}