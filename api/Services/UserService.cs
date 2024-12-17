using App.Context;
using App.Models;
using System.Security.Cryptography;

namespace App.Services;

public class UserService
{
    private readonly MyDbContext _context;

    public UserService(MyDbContext ctx) {
        _context = ctx;
    }

    public List<User> getAllUsers() {
        return _context.Users.ToList();
    }


    public string hasherString(string initial) {
        string hashedStr = BCrypt.Net.BCrypt.HashPassword(initial);
        return hashedStr;
    }


    public void loginUser(string email, string password) {
        var user = _context.Users
            .Where(u => u.email.Equals(email))
            .Take(1);
        
    }
}