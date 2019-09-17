using System;
using System.Collections.Generic;
using System.Text;

namespace ActorAppCore.Domain
{
    public class Biography
    {
        public int Id { get; set; }
        public string text { get; set; }
        public int ActorId { get; set; }
    }
}
