namespace webServer1.Models;

public class User
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? UserId { get; set; }
    public string? Adress { get; set; }
    public string? PhoneNum { get; set; }
    public string? Email { get; set; }
    public string? Password { get; set; }
    public List<Appointment>? Appointments { get; set; }
    public bool IsLogged { get; set; } = false;
    public UserTypes Type { get; set; }

}
  public enum UserTypes { Manager, Customer };