using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EventsBrowser.Models
{
    public class Artist
    {
        [Key]                             // primary key
        public int Id { get; set; }       // entinty framework rozpoznaje samo "id"
        [Display(Name ="Zdjęcie profilowe")]
        [Required(ErrorMessage = "Zdjęcie profilowe jest wymagane")]
        public string ProfilePictureUrl { get; set; }

        //walidacja nazwy
        [Display(Name = "Nazwa")]
        [Required(ErrorMessage = "Nazwa jest wymagana")]
        [StringLength(50,MinimumLength =2, ErrorMessage = "Nazwa musi mieć co najmniej 2 znaki")]
        public string FullName { get; set; }

        // walidacja Bio
        [Display(Name = "Bio")]
        [Required(ErrorMessage = "To pole jest wymagane")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Bio musi zawierać minimum 5 znaków")]
        public string Bio { get; set; }

        //Relationship
        public List<Artist_Event> Artists_Events { get; set; }
    }
}
