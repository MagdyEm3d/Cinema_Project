using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eTickets.Data;

namespace eTickets.Models;

public class Movie
{
    [Key]
    public int MovieId { get; set; }

    public string MovieName { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }
    public string MovieImageURL { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    
    public MovieCategory MovieCategory { get; set; }
    
    //Relationships
    public List<Actor_Movie> MovieActors { get; set; }
    public int CinemasId { get; set; }
    [ForeignKey("CinemasId")]
    public Cinema Cinema { get; set; }
    public int ProducerId { get; set; }
    [ForeignKey("ProducerId")]
    public Producer Producer { get; set; }


    /*
    //Cinema
    public int CinemaId { get; set; }
    [ForeignKey("CinemaId")]
    public Cinema Cinema { get; set; }

    //Producer
    public int ProducerId { get; set; }
    [ForeignKey("ProducerId")]
    public Producer Producer { get; set; }
    */
}