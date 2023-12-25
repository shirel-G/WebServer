using Microsoft.EntityFrameworkCore;
using webServer1.Models;

namespace webServer1.Db_Context;

public class ServerContext : DbContext
{
    public ServerContext(DbContextOptions<ServerContext> options) : base(options) { }

    public DbSet<User> Users { get; set; }

    public DbSet<Appointment> Appointments { get; set; }
}
