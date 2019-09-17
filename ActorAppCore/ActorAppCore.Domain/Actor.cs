using System;
using System.Collections.Generic;
using System.Text;

namespace ActorAppCore.Domain
{
    public class Actor
    {
        public Actor()
        {
            Events = new List<Event>();
        }
        public int Id { get; set; }
        public int Name { get; set; }
        public List<Event> Events { get; set; }
        public List<ActorMovie> ActorMovies { get; set; }
        public Biography Biography { get; set; }
    }
}
