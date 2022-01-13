using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EventsBrowser.Models
{
    public class EventPlace
    {
        [Key]
        public int Id { get; set; }
        [Display(Name="Zdjęcie obiektu")]
        public string Photo { get; set; }
        [Display(Name = "Miasto")]
        public string City { get; set; }
        [Display(Name = "Opis")]
        public string Description { get; set; }

        // Relationship
        public List <Event>Events { get; set; }
    }
}
