using Microsoft.AspNetCore.Mvc;
using webServer1.Models;
using webServer1.Repositories;
using webServer1.Repositories.Interfaces;

namespace webServer1.Contollers;

public class AppointmentController : Controller
{
    private readonly IAppointmentRepository _appointmerntRepository;
    public AppointmentController(IAppointmentRepository appointmentRepository)
    {
        _appointmerntRepository = appointmentRepository;
    }

    [HttpGet("GetUserAppointments")]
    public async Task<ActionResult<Appointment>> GetUserAppointments(string customerID)
    {
        try
        {
            var customerAppointments = await _appointmerntRepository.GetAppointmentsByCustomerID(customerID);

            if (customerAppointments.Count == 0)
            {
                return BadRequest($"Customer {customerID} dont have appointments" );

            }
            else
            {

                foreach (var appointment in customerAppointments)
                {
                    Console.WriteLine($"AppointmentID: {appointment.Id},$customerName: {appointment.CotumerName}, Date: {appointment.AppointmentTime}, " +
                        $"appointmet kind :{appointment.Type}");
                }
                return Ok(customerAppointments);
            }
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
        
        
    }
}
