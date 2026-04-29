using Microsoft.Data.SqlClient;
using WebApplication2.Properties;

namespace WebApplication2.Services;

public class RentalService : IRentalService
{
    string connectionString_;
    public RentalService(string connectionString)
    {
        connectionString_ = connectionString;
    }

    public async Task<CustomerRentalDTO> GetCustomerRentalsAsync(int id)
    {
        await using var connection = new SqlConnection(connectionString_);
        
    }
}