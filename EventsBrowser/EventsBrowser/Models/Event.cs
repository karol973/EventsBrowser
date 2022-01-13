using DocumentFormat.OpenXml.Drawing.Diagrams;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using EventsBrowser.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventsBrowser.Models
{
    public class Event
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public double Price { get; set; }
        public string ImageUrl { get; set; }

        public DateTime Date { get; set; }

        public EventCategory Category { get; set; }

        //Relationships

        public List<Artist_Event>Artists_Events { get; set; }

        //EventPlace

        public int EventPlaceId { get; set; }
        [ForeignKey("EventPlaceId")]
        public EventPlace EventPlace { get; set; }
    }
}
