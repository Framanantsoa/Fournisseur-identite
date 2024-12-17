using Microsoft.EntityFrameworkCore;
using App.Models;

namespace App.Context;

public class MyDbContext : DbContext
{
    public MyDbContext(DbContextOptions<MyDbContext> o) : base(o){}

    public DbSet<User> Users {get; set;}
}
