using System;
namespace webServer1.Models;

public class Appointment
{
	public int Id { get; set; }
	public string? CostumerId { get; set; }
	public string? CotumerName { get; set; }
	public DateTime AppointmentTime { get; set; }
	public Kind Type { get; set; }
	public IsApproved IsApproved { get; set; }
}

public enum Kind { hands,legs};
public enum IsApproved {yes, no};