namespace WebApplication2.Properties;

public class RentalsDTO
{
    public int Id { get; set; }
    public DateTime RentalDate { get; set; }
    public DateTime? ReturnDate { get; set; }
    public string Status { get; set; }
    public List<MoviesDTO> Movies { get; set; }
}