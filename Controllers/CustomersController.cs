using Microsoft.AspNetCore.Mvc;
using WebApplication2.Services;

namespace WebApplication2.Controllers;
[ApiController]
[Route("api/[controller]")]
public class CustomersController : ControllerBase
{
    private readonly IRentalService _rentalService;

    public CustomersController(IRentalService rentalService)
    {
        _rentalService = rentalService;
    }
    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetCustomerRentals(int id)
    {
        var customer = await _rentalService.GetCustomerRentalsAsync(id);
        if (customer == null)
        {
            return NotFound();
        }
        return Ok(customer);
    }
}