using WebApplication2.Properties;

namespace WebApplication2.Services;

public interface IRentalService
{
    public Task<CustomerRentalDTO> GetCustomerRentalsAsync(int id);
}