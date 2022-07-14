using eTickets.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class MovieModel
    {
        [Key]

        public int Id { get; set; }

        public String Name { get; set; }

        public String Description { get; set; }

        public double Price { get; set; }

        public String  ImageURL { get; set; }

        public DateTime StartDadte { get; set; }

        public DateTime EndDate { get; set; }

        public MovieCategory MovieCategory { get; set; }
    }
}
