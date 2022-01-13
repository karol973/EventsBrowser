using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventsBrowser.Models
{
    public class Artist_Event
    {
        public int EventId { get; set; }

        public Event Event { get; set; }
        public int ArtistId { get; set; }
        public Artist Artist {get;set;}
    }
}
