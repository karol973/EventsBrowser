using EventsBrowser.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventsBrowser.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using(var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                context.Database.EnsureCreated();
                //EventPlaces
                if(!context.EventPlaces.Any())
                {
                    context.EventPlaces.AddRange(new List<EventPlace>()
                    {
                        new EventPlace()
                        {
                            City = "Warszawa-Służewiec",
                            Photo = "https://www.haloursynow.pl/img/artykuly/3935_wielkie-gwiazdy-na-torze-wyscigow-dla-tysi_1.jpg?d=1434199324",
                            Description = "Tor Wyścigów Konnych Służewiec"
                        },
                        new EventPlace()
                        {
                            City = "Łódź",
                            Photo = "https://akwa-mania.mud.pl/wp-content/uploads/198267243_231104952155622_2497464196077001799_n.jpg",
                            Description = "Atlas Arena"
                        },
                        new EventPlace()
                        {
                            City = "Kraków",
                            Photo = "https://www.eventim.pl/obj/media/PL-eventim/teaser/venue/984x333/2015/tauron-984.jpg",
                            Description = "Tauron Arena"
                        },
                        new EventPlace()
                        {
                            City = "Warszawa-PGE Narodowy",
                            Photo = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/f8/National_Stadium_Warsaw_aerial_view_2.jpg/1920px-National_Stadium_Warsaw_aerial_view_2.jpg",
                            Description = "PGE Narodowy"
                        },
                        new EventPlace()
                        {
                            City = "Poznań",
                            Photo = "http://www.inzynierbudownictwa.pl/images/magda/ib_05_12/poz2.jpg",
                            Description = "Stadion Poznań"
                        },
                    });
                    context.SaveChanges();
                }
                //Events
                if (!context.Events.Any())
                {
                    context.Events.AddRange(new List<Event>()
                    {
                        new Event()
                        {
                            Name = "Sting - My songs",
                            Description = "Koncert Sting: My Songs jest żywiołowym i dynamicznym wydarzeniem, skupiającym się na najbardziej kochanych przez fanów utworach napisanych przez Artystę i obejmującym twórczość siedemnastokrotnego zwycięzcy Grammy, zarówno solową, jak również jako członka zespołu The Police.",
                            Price = 150.00,
                            ImageUrl = "https://www.pgenarodowy.pl/upload/headerimages/sting_1440x500_optimized.jpg",
                            Date = DateTime.Now.AddDays(-10),
                            EventPlaceId = 3,
                           Category = EventCategory.music
                        },
                        new Event()
                        {
                             Name = "Andrea Bocelli - Music for hope",
                            Description = "Andrea Bocelli to legendarny artysta, światowej sławy tenor pochodzący z włoskiej Toskanii, występujący na największych światowych scenach od ponad 20 lat. ",
                            Price = 200.00,
                            ImageUrl = "https://ebilet-media.azureedge.net/media/39964/001_andrea-bocelli_ebilet_900x507_ogloszenie_05_2019450.jpg",
                            Date = DateTime.Now.AddDays(-10),
                            EventPlaceId = 1,
                           Category = EventCategory.music
                        },
                        new Event()
                        {
                           Name = "Phil Collins - Still not dead yet",
                            Description = "Phil Collins - jeden z najwybitniejszych brytyjskich muzyków powraca na scenę i rusza w trasę koncertową po Europie! Artysta wystąpi 26 czerwca na PGE Narodowym w Warszawie. Gośćmi specjalnymi będą Nile Rodgers & CHIC. Phil Collins bilety na koncert już w sprzedaży! ",
                            Price = 100.00,
                            ImageUrl = "https://ebilet-media.azureedge.net/media/30180/pc_new-900x507450.jpg",
                            Date = DateTime.Now.AddDays(-10),
                            EventPlaceId = 4,
                           Category = EventCategory.music
                        },
                        new Event()
                        {
                            Name = "Krzysztof Zalewski",
                            Description = "Jeden z najciekawszych Artystów na polskiej scenie muzycznej. Szerokiej publiczności znany z takich płyt jak „Zelig”, czy „Złoto”",
                            Price = 50.00,
                           ImageUrl = "https://ebilet-media.azureedge.net/media/42948/01_zalewski_mtv_unplugged_ebilet_900x507450.jpg",
                            Date = DateTime.Now.AddDays(-10),
                            EventPlaceId = 2,
                           Category = EventCategory.music
                        },
                        new Event()
                        {
                            Name = "Celine Dion",
                            Description = "Courage",
                             Price = 250.00,
                           ImageUrl = "https://www.prestigemjm.com/img/db6c36e7.jpg",
                            Date = DateTime.Now.AddDays(-10),
                            EventPlaceId = 1,
                           Category = EventCategory.music
                        },
                        new Event()
                        {
                            Name = "Guns N'Roses",
                             Description = "Guns N' Roses ponownie w Polsce! Legendarna kapela powróci do Polski w 2022 roku, by 20 czerwca zagrać na PGE Narodowym w Warszawie.",
                             Price = 120.00,
                           ImageUrl = "https://ebilet-media.azureedge.net/media/40106/gnr-900_507450.jpg",
                            Date = DateTime.Now.AddDays(-10),
                            EventPlaceId = 5,
                           Category = EventCategory.music
                        }
                    });
                    context.SaveChanges();
                }
            
                //Artist
                if (!context.Artists.Any())
                {
                    context.Artists.AddRange(new List<Artist>()
                    {
                        new Artist()
                        {
                            FullName = "Sting",
                            Bio = "This is the Bio of the first actor",
                            ProfilePictureUrl = "https://www.muzeumjazzu.pl/wp-content/uploads/2020/10/Sting-10.jpg"

                        },
                        new Artist()
                        {
                            FullName = "Andrea Bocelli",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureUrl = "https://amu.edu.pl/__data/assets/image/0008/20204/varieties/h600.jpg"
                        },
                        new Artist()
                        {
                            FullName = "Phil Collins",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureUrl = "https://yt3.ggpht.com/ytc/AKedOLRrklAGxzt4WwRDhAlnFNW0SFlWgymp-4IqZduyNA=s900-c-k-c0x00ffffff-no-rj"
                        },
                        new Artist()
                        {
                            FullName = "Krzysztof Zalewski",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureUrl = "https://bi.im-g.pl/im/d3/4d/19/z26531795V,Krzysztof-Zalewski.jpg"
                        },
                        new Artist()
                        {
                            FullName = "Celine Dion",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureUrl = "https://biletserwis.pl/wp-content/uploads/2021/03/01_CELINE-DION_biletserwis_700x470.jpg"
                         },
                    });
                    context.SaveChanges();
                }
                    //Artist_Event
                    if (!context.Artists_Events.Any())
                {
                    context.Artists_Events.AddRange(new List<Artist_Event>()
                    {
                        new Artist_Event()
                        {
                            ArtistId = 1,
                            EventId = 1
                        },
                        new Artist_Event()
                        {
                            ArtistId = 3,
                            EventId = 1
                        },

                         new Artist_Event()
                        {
                            ArtistId = 1,
                            EventId = 2
                        },
                         new Artist_Event()
                        {
                            ArtistId = 4,
                            EventId = 2
                        },

                        new Artist_Event()
                        {
                        ArtistId = 1,
                            EventId = 3
                        },
                        new Artist_Event()
                        {
                            ArtistId = 2,
                            EventId = 3
                        },
                        new Artist_Event()
                        {
                            ArtistId = 5,
                            EventId = 3
                        },


                        new Artist_Event()
                        {
                            ArtistId = 2,
                            EventId = 4
                        },
                        new Artist_Event()
                        {
                            ArtistId = 3,
                            EventId = 4
                        },
                        new Artist_Event()
                        {
                            ArtistId = 4,
                            EventId = 4
                        },


                        new Artist_Event()
                        {
                            ArtistId = 2,
                            EventId = 5
                        },
                        new Artist_Event()
                        {
                            ArtistId = 3,
                            EventId = 5
                        },
                        new Artist_Event()
                        {
                            ArtistId = 4,
                            EventId = 5
                        },
                        new Artist_Event()
                        {
                            ArtistId = 5,
                            EventId = 5
                        },


                        new Artist_Event()
                        {
                            ArtistId = 3,
                            EventId = 6
                        },
                        new Artist_Event()
                        {
                            ArtistId = 4,
                            EventId = 6
                        },
                        new Artist_Event()
                        {
                            ArtistId = 5,
                            EventId = 6
                        },
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
