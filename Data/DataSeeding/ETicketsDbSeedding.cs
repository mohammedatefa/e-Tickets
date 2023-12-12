using e_Tickets.Context;
using e_Tickets.Models;

namespace e_Tickets.Data.DataSeeding
{
    public class ETicketsDbSeedding
    {
        public static void DataSeeding(IApplicationBuilder applicationBuilder)
        {
            using(var servicescope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = servicescope.ServiceProvider.GetService<ETicketsDbContext>();
                context?.Database.EnsureCreated();

                //seeding data 
                //Actor
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>
                    {
                        new Actor
                        {
                            FullName="Tom Cruise",
                            ImageUrl="https://image.tmdb.org/t/p/w500/eOh4ubpOm2Igdg0QH2ghj0mFtC.jpg",
                            Bio="Renowned for their captivating performances and versatile acting prowess,he has etched an indelible mark in the world of entertainment. With a career spanning several decades"
                        },
                        new Actor
                        {
                            FullName="Leonardo DiCaprio",
                            ImageUrl="https://image.tmdb.org/t/p/w500/5Brc5dLifH3UInk3wUaCuGXpCqy.jpg",
                            Bio="Renowned for their captivating performances and versatile acting prowess,he has etched an indelible mark in the world of entertainment. With a career spanning several decades"
                        },
                        new Actor
                        {
                            FullName="Hirokazu Kore-eda",
                            ImageUrl="https://th.bing.com/th/id/OIP.2p3J2xXoNL0-QkxiOlLA4gHaIy?rs=1&pid=ImgDetMain",
                            Bio="Renowned for their captivating performances and versatile acting prowess,he has etched an indelible mark in the world of entertainment. With a career spanning several decades"
                        },
                        new Actor
                        {
                            FullName="Brad Pitt",
                            ImageUrl="https://image.tmdb.org/t/p/w500/cckcYc2v0yh1tc9QjRelptcOBko.jpg",
                            Bio="Renowned for their captivating performances and versatile acting prowess,he has etched an indelible mark in the world of entertainment. With a career spanning several decades"
                        },
                        new Actor
                        {
                            FullName="Nicolas Cage",
                            ImageUrl="https://image.tmdb.org/t/p/w500/ar33qcWbEgREn07ZpXv5Pbj8hbM.jpg",
                            Bio="Renowned for their captivating performances and versatile acting prowess,he has etched an indelible mark in the world of entertainment. With a career spanning several decades"
                        }
                        ,
                        new Actor
                        {
                            FullName="Christopher Nolan",
                            ImageUrl="https://image.tmdb.org/t/p/w500/xuAIuYSmsUzKlUMBFGVZaWsY3DZ.jpg",
                            Bio="Renowned for their captivating performances and versatile acting prowess,he has etched an indelible mark in the world of entertainment. With a career spanning several decades"
                        }
                          ,
                        new Actor
                        {
                            FullName="Jason Statham",
                            ImageUrl="https://image.tmdb.org/t/p/w500/whNwkEQYWLFJA8ij0WyOOAD5xhQ.jpg",
                            Bio="Renowned for their captivating performances and versatile acting prowess,he has etched an indelible mark in the world of entertainment. With a career spanning several decades"
                        } ,
                        new Actor
                        {
                            FullName="Brady Noon",
                            ImageUrl="https://image.tmdb.org/t/p/w500/mbgwWA1uVXQ09T7jxs2D333O2JN.jpg",
                            Bio="Renowned for their captivating performances and versatile acting prowess,he has etched an indelible mark in the world of entertainment. With a career spanning several decades"
                        }
                    });
                    context.SaveChanges();
                }
                //Cinema
                if (!context.Cinemas.Any())
                {
                    context.AddRange(new List<Cinema>
                    {
                        new Cinema
                        {
                            Name="TCL Chinese Theatre (Grauman's Chinese Theatre), Los Angeles, USA",
                            Description="Known for its iconic hand and footprints of celebrities in the forecourt, this theater hosts many premieres and is a historic landmark.",
                            Logo="https://th.bing.com/th/id/R.39d7735a750ca51c2f70fcc4aed96e93?rik=Iajc6UE1G39dGQ&riu=http%3a%2f%2fwww.travelonline.com%2fusa%2flos-angeles%2fattractions%2fchinese-theatre%2fgraumans-chinese-theater-hollywood-los-angeles-36019.jpg&ehk=lQr%2f7G9KKlj07ScA5Qcv4HMHd%2bcA8sTqp61J6Ergurs%3d&risl=&pid=ImgRaw&r=0"
                        },new Cinema
                        {
                            Name="Odeon Leicester Square, London, UK",
                            Description=" Situated in London's West End, this theater is famous for hosting major film premieres and is one of the key venues during the London Film Festival.",
                            Logo="https://th.bing.com/th/id/R.1a86f30fbb90f3c274c1e88dd434b17f?rik=4tyxWFDU%2fm%2bXVA&pid=ImgRaw&r=0"
                        },new Cinema
                        {
                            Name="Cinecittà, Rome, Italy",
                            Description=" One of the largest film studios in Europe, it's known for its historical significance in the Italian film industry.",
                            Logo="https://th.bing.com/th/id/R.d6581fdd3cb840072085d5f5bca81985?rik=uy2HQpON7wTUXg&pid=ImgRaw&r=0"
                        },new Cinema
                        {
                            Name="Roxy Theatre, Kolkata, India",
                            Description="Known for its architectural beauty and historical significance in Indian cinema, it has been a landmark for film enthusiasts.",
                            Logo="https://th.bing.com/th/id/R.19848de85774d019c3289deb150e859b?rik=SZr7gPB7NeAAag&pid=ImgRaw&r=0"
                        }
                    });
                    context.SaveChanges();
                }
                //Producers
                if (!context.Producers.Any())
                {
                    context.AddRange(new List<Producer>
                    {
                        new Producer
                        {
                            FullName="Steven Spielberg",
                            Bio="Renowned for his work on iconic films like \"Jurassic Park,\" \"E.T. the Extra-Terrestrial,\" and \"Schindler's List,\" Spielberg's impact on cinema is immense",
                            ImageUrl="https://th.bing.com/th/id/R.c108fecd458b5b0a5829550fe7d35f2c?rik=Pj8rtO5LofXOJQ&riu=http%3a%2f%2f4.bp.blogspot.com%2f-nANrgyBU9xc%2fVlXMP7BBbOI%2fAAAAAAAAAUw%2fRHSykMXJNSI%2fs1600%2fSteven-Spielberg.jpeg&ehk=%2fFagme1I0TBApGmos%2bcaV1xhCaNfHwVhfqHhXFGj2Yc%3d&risl=&pid=ImgRaw&r=0"
                        }, new Producer
                        {
                            FullName="George Lucas",
                            Bio="Known for creating the \"Star Wars\" franchise and the Indiana Jones series, Lucas has significantly shaped modern cinema",
                            ImageUrl="https://th.bing.com/th/id/OIP.H2Tcqtq8K02sfW8OfFAbbAHaE_?rs=1&pid=ImgDetMain"
                        }, new Producer
                        {
                            FullName="Kathleen Kennedy",
                            Bio="As the current president of Lucasfilm, Kennedy has been involved in numerous successful projects, including the newer \"Star Wars\" films",
                            ImageUrl="https://th.bing.com/th/id/R.14c2cc917a4da9cb1a8fb83ffbf02fc4?rik=08Qq%2fVXCTAjecg&pid=ImgRaw&r=0"
                        }, new Producer
                        {
                            FullName="Christopher Nolan",
                            Bio="Has worked on numerous successful and critically acclaimed films like \"Inception,\" \"The Dark Knight\" trilogy, and \"Interstellar.\"",
                            ImageUrl="https://th.bing.com/th/id/R.074f7978450e0d130385bebfe0eddfce?rik=jnUk6SnDoAwgjg&pid=ImgRaw&r=0"
                        }, new Producer
                        {
                            FullName="Kevin Feige",
                            Bio="The president of Marvel Studios, Feige has overseen the development of the Marvel Cinematic Universe (MCU), which has become a massive, interconnected film franchise.\r\n\r\n",
                            ImageUrl="https://th.bing.com/th/id/OIP.Adw5em2AT8QNtYqGr2j_lgHaE6?rs=1&pid=ImgDetMain"
                        }, new Producer
                        {
                            FullName="Scott Rudin",
                            Bio="Known for producing a wide range of successful films and theater productions, Rudin has been a prominent figure in the industry.",
                            ImageUrl="https://th.bing.com/th/id/OIP.db-qeTR9-97yCqDev57LAgHaGd?rs=1&pid=ImgDetMain"
                        },
                    });
                    context.SaveChanges();
                }
                //movies
                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movies>
                    {
                        new Movies
                        {
                            Name="Killers of the Flower Moon",
                            ImageUrl="https://image.tmdb.org/t/p/w500/dB6Krk806zeqd0YNp2ngQ9zXteH.jpg",
                            Price=48.50m,
                            Description="When oil is discovered in 1920s Oklahoma under Osage Nation land, the Osage people are murdered one by one—until the FBI steps in to unravel the mystery.",
                            StartDate=DateTime.Now,
                            EndDate=DateTime.Now.AddDays(8),
                            CinemaId=1,
                            ProducerId=1,
                            Category=Enum.MovieCategory.Action,
                        }, new Movies
                        {
                            Name="Oppenheimer",
                            ImageUrl="https://image.tmdb.org/t/p/w500/8Gxv8gSFCU0XGDykEGv7zR1n2ua.jpg",
                            Price=39.65m,
                            Description="The story of J. Robert Oppenheimer's role in the development of the atomic bomb during World War II.",
                            StartDate=DateTime.Now,
                            EndDate=DateTime.Now.AddDays(12),
                            CinemaId=2,
                            ProducerId=4,
                            Category=Enum.MovieCategory.Hiestorical,
                        },new Movies
                        {
                            Name="Leave the World Behind",
                            ImageUrl="https://image.tmdb.org/t/p/w500/l2bqoY9rgPAgugPkOTowIPIv61j.jpg",
                            Price=29.65m,
                            Description="A family's getaway to a luxurious rental home takes an ominous turn when a cyberattack knocks out their devices — and two strangers appear at their door.",
                            StartDate=DateTime.Now,
                            EndDate=DateTime.Now.AddDays(7),
                            CinemaId=4,
                            ProducerId=4,
                            Category=Enum.MovieCategory.Hororr,
                        },
                        new Movies
                        {
                            Name="The Creator",
                            ImageUrl="https://image.tmdb.org/t/p/w500/vBZ0qvaRxqEhZwl6LWmruJqWE8Z.jpg",
                            Price=27.00m,
                            Description="Amid a future war between the human race and the forces of artificial intelligence, a hardened ex-special forces agent grieving the disappearance of his wife, is recruited to hunt down and kill the Creator.",
                            StartDate=DateTime.Now,
                            EndDate=DateTime.Now.AddDays(18),
                            CinemaId=3,
                            ProducerId=3,
                            Category=Enum.MovieCategory.Action,
                        },new Movies
                        {
                            Name="The Hunger Games: The Ballad of Songbirds & Snakes",
                            ImageUrl="https://image.tmdb.org/t/p/w500/mBaXZ95R2OxueZhvQbcEWy2DqyO.jpg",
                            Price=32.86m,
                            Description="64 years before he becomes the tyrannical president of Panem, Coriolanus Snow sees a chance for a change in fortunes when he mentors Lucy Gray Baird, the female tribute from District 12.",
                            StartDate=DateTime.Now,
                            EndDate=DateTime.Now.AddDays(10),
                            CinemaId=4,
                            ProducerId=3,
                            Category=Enum.MovieCategory.Drama,
                        },
                        new Movies
                        {
                            Name="The Marvels",
                            ImageUrl="https://image.tmdb.org/t/p/w500/3sXv15ymVkaV7E18m4TlTgwNkAN.jpg",
                            Price=34.50m,
                            Description="Carol Danvers, aka Captain Marvel, has reclaimed her identity from the tyrannical Kree and taken revenge on the Supreme Intelligence. But unintended consequences see Carol shouldering the burden of a destabilized universe",
                            StartDate=DateTime.Now,
                            EndDate=DateTime.Now.AddDays(8),
                            CinemaId=2,
                            ProducerId=5,
                            Category=Enum.MovieCategory.Action,
                        },new Movies
                        {
                            Name="Wonka",
                            ImageUrl="https://image.tmdb.org/t/p/w500/qhb1qOilapbapxWQn9jtRCMwXJF.jpg",
                            Price=34.50m,
                            Description="Willy Wonka – chock-full of ideas and determined to change the world one delectable bite at a time – is proof that the best things in life begin with a dream, and if you’re lucky enough to meet Willy Wonka, anything is possible",
                            StartDate=DateTime.Now,
                            EndDate=DateTime.Now.AddDays(8),
                            CinemaId=2,
                            ProducerId=5,
                            Category=Enum.MovieCategory.Family,
                        },new Movies
                        {
                            Name="Indiana Jones and the Dial of Destiny",
                            ImageUrl="https://image.tmdb.org/t/p/w500/Af4bXE63pVsb2FtbW8uYIyPBadD.jpg",
                            Price=29.42m,
                            Description="Finding himself in a new era, and approaching retirement, Indy wrestles with fitting into a world that seems to have outgrown him. But as the tentacles of an all-too-familiar evil return in the form of an old rival",
                            StartDate=DateTime.Now,
                            EndDate=DateTime.Now.AddDays(11),
                            CinemaId=3,
                            ProducerId=6,
                            Category=Enum.MovieCategory.Adventure,
                        }
                    });
                    context.SaveChanges();
                }
               

            }
        }
    }
}
