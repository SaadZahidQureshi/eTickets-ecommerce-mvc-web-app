using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class CinemaModel
    {

        [Key]
        public int Id { get; set; }
        public String Logo { get; set; }

        public String Name { get; set; }

        public String Description { get; set; }
    }
}
