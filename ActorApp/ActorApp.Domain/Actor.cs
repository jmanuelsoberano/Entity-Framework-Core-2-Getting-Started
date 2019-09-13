using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActorApp.Domain
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
        public int MovieId { get; set; }
    }
}
