using System.ComponentModel.DataAnnotations;

namespace eTickets.Models;

public class Actor
{
    [Key]
    public int ActorId { get; set; }

    public string Profilepicture { get; set; }
    public string FullName { get; set; }
    public string Bio { get; set; }

    public List<Actor_Movie>? ActorMovies { get; set; }
}
