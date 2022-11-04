using CrudCustomers.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace CrudCustomers.Api.Controllers;


    [Route("api/[controller]")]
    [ApiController]

    public class CustomerController : ControllerBase
    {
        private readonly ApiDbContext _context;

        public CustomerController(ApiDbContext context)
        {
            _context = context;
        }

    [HttpGet]

    public object Get() => _context.Customers.Where(b => b.Full_name.Contains("Full_name")).Select((c) => new
    {
        Id = c.Id,
        Full_name = c.Full_name,
        Date_of_birth = c.Date_of_birth,
        Gender = c.Gender,
        Cuil = c.Cuil,
        Phone = c.Phone,
        Deleted = c.Deleted

    }).ToList();
}

