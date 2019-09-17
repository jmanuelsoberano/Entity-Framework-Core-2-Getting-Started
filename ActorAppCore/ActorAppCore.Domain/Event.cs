using System;
using System.Collections.Generic;
using System.Text;

namespace ActorAppCore.Domain
{
    public class Event
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public Actor Actor { get; set; }
        public int ActorId { get; set; }
    }
}
