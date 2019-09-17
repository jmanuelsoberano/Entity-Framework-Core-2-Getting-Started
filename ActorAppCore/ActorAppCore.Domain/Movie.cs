using System;
using System.Collections.Generic;
using System.Text;

namespace ActorAppCore.Domain
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public List<ActorMovie> ActorMovies { get; set; }

    }
}
