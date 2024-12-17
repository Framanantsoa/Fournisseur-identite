using Microsoft.AspNetCore.Mvc;
using App.Models;
using App.Services;

namespace App.Controllers;

[ApiController]
[Route("api")]
public class UserController : Controller
{
    private readonly UserService service;

    public UserController(UserService sv) {
        this.service = sv;
    }


    [HttpGet("users")]
    public IActionResult getAll() {
        return Ok(this.service.getAllUsers());
    }


    // [HttpPost]
    // public IActionResult signIn([FromBody] LoginRequest login) {
    //     try {
            
    //     }
    //     catch(Exception e) {

    //     }
    // }
}