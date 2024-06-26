using System.ComponentModel.DataAnnotations;

namespace eTickets.Models;

public class Producer
{
    [Key]
    public int ProducerId { get; set; }
    public string ProfilepictureURL { get; set; }
    public string Name { get; set; }
    public string Bio { get; set; }

    public List<Movie> Movie { get; set; }
}
