using System;
namespace webServer1.Models;

public class Customer
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? UserId { get; set; }
    public string? Adress { get; set; }
    public string? PhoneNum { get; set; }
    public string? Email { get; set; }
    public List<Appointment>? Appointments { get; set; }
}

