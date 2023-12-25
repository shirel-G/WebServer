using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using webServer1.Db_Context;
using webServer1.Models;
using webServer1.Repositories;
using webServer1.Repositories.Interfaces;

namespace webServer1.Repositories;

public class AppointmentRepository : IAppointmentRepository
{
    private ServerContext _context;
    public AppointmentRepository(ServerContext context)
    {
        _context = context;
    }

    public async Task<List<Appointment>> GetAppointmentsByCustomerID(string customerID)
    { 
        var appointments = await _context.Appointments.ToListAsync();
        appointments = appointments.Where(a => a.CostumerId == customerID).ToList();
        if (appointments == null)
        {
            throw new Exception("Dont have appointments hestory");
        }
        return appointments;
    }

   
}
