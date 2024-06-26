using System.ComponentModel.DataAnnotations;

namespace eTickets.Models;

public class Cinema
{
    [Key]
    public int CinemasId { get; set; }
    public string logo { get; set; }
    public string CinemasName { get; set; }
    public string Description { get; set; }
    public List<Movie> Movies { get; set; }

}
