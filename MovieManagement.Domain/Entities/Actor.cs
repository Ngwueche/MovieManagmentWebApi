using System.ComponentModel.DataAnnotations;

namespace MovieManagement.Domain.Entities
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Biography { get; set; }
        public List<Movie> Movies { get; set; }
    }
}
