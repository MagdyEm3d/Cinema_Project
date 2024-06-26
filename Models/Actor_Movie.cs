using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eTickets.Models;

public class Actor_Movie
{
    [Key]
    public int MovieId { get; set; }
    [ForeignKey("MovieId")]
    public Movie movie { get; set; }


    [Key]
    public int ActorId { get; set; }
    [ForeignKey("ActorId")]
    public Actor actor { get; set; }

}
