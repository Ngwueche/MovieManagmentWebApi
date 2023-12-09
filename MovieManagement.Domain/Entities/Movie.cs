namespace MovieManagement.Domain.Entities
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int ActorId { get; set; }
        public Actor? Actor { get; set; }
        public List<Genre>? Genre { get; set; }
    }
}