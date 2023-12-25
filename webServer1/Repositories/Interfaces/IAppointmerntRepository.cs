using Microsoft.AspNetCore.Mvc;
using webServer1.Models;

namespace webServer1.Repositories.Interfaces
{
    public interface IAppointmentRepository
    {
        //Task<ActionResult<Appointment>> AddAppointment(Appointment appointment);
        Task<List<Appointment>> GetAppointmentsByCustomerID(string customerID);
    }
}
