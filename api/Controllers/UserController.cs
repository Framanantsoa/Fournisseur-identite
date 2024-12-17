using Microsoft.AspNetCore.Mvc;
using CsMVC.Models;

namespace CsMVC.Controllers;

[ApiController]
[Route("api")]
public class UserController : Controller
{
    [HttpPost]
    public IActionResult signUpUser([FromBody] User user) {

    }


    // [HttpPost]
    // public IActionResult signInUser([FromBody] User user) {
        
    // }
}
