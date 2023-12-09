﻿namespace MovieManagement.Domain.Entities
{
    public class Actor
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Genre Biography { get; set; }
        public List<Movie> Movies { get; set; }
    }
}