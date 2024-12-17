using App.Context;
using App.Models;

namespace App.Services;

public class UserService
{
    private readonly MyDbContext _context;

    public UserService(MyDbContext ctx) {
        _context = ctx;
    }

    public List<User> getAllUsers() {
        return this._context.Users.ToList();
    }

    public void loginUser(string email, string password) {
        
    }
}