using System;
namespace webServer1.Models;

public class Manager
{
	public int Id { get; set; }
    public string? ManagerId { get; set; }
    public string? Password { get; set; }
    public List<Appointment>? Appointments { get; set; }
}

