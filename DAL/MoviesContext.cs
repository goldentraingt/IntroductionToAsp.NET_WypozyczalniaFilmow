using IntroductionToAsp.NET_WypozyczalniaFilmow.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace IntroductionToAsp.NET_WypozyczalniaMovieow.DAL
{
    public class MoviesContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Category> Categories { get; set; }

        public MoviesContext(DbContextOptions<MoviesContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "Horror",
                    Description = "Straszne Moviey",

                },
                new Category
                {
                    Id = 2,
                    Name = "Dokumentalny",
                    Description = "Movie oparty na faktach"
                },
                new Category
                {
                    Id = 3,
                    Name = "Thriller",
                    Description = "Dreszczowce"
                },
                new Category
                {
                    Id = 4,
                    Name = "Sensacyjne",
                    Description = "Moviey z akcja"
                },
                new Category
                {
                    Id = 5,
                    Name = "Fantasy",
                    Description = "Elementy magiczne i nadprzyrodzone"
                }
                );

            modelBuilder.Entity<Movie>().HasData(
                   new Movie()
                   {
                       Id = 1,
                       CategoryId = 1,
                       Title = "Teksańska Masakra Piłą Mechaniczną",
                       Director = "Marcus Nispel",
                       Description = "20 sierpnia 1973 roku teksańska policja trafiła do stojącego na uboczu domu Thomasa Hewitta - byłego pracownika lokalnej rzeźni. Na miejscu odkryli rozkładające się zwłoki 33 osób, które zostały zamordowane przez psychopatycznego zabójcę noszącego na twarzy maskę z ludzkiej skóry i posługującego się piłą mechaniczną.",
                       Price = 10,
                       CreatedAt = new DateTime(2020, 5, 4)
                   },
                new Movie()
                {
                    Id = 2,
                    CategoryId = 3,
                    Title = "Numer 23",
                    Director = "Joel Schumacher",
                    Description = "Mężczyzna dostaje obsesji na punkcie książki, która według niego opisuje i przewiduje jego życie i przyszłość.",
                    Price = 14,
                    CreatedAt = new DateTime(2021, 3, 16)
                },
                new Movie()
                {
                    Id = 3,
                    CategoryId = 3,
                    Title = "Sekretne Okno",
                    Director = "David Koepp",
                    Description = "Uznany pisarz przenosi się na prowincję, by w spokoju tworzyć kolejne książki. Wkrótce odwiedzi go tajemniczy mężczyzna, który oskarży Raineya o plagiat.",
                    Price = 12,
                    CreatedAt = new DateTime(2020, 5, 4)
                },
                new Movie()
                {
                    Id = 4,
                    CategoryId = 5,
                    Title = "Władca Pierścieni: Drużyna Pierścienia",
                    Director = "Peter Jackson",
                    Description = "Podróż hobbita z Shire i jego ośmiu towarzyszy, której celem jest zniszczenie potężnego pierścienia pożądanego przez Czarnego Władcę - Saurona.",
                    Price = 20,
                    CreatedAt = new DateTime(2020, 5, 4)
                },
                new Movie()
                {
                    Id = 5,
                    CategoryId = 4,
                    Title = "Red",
                    Director = "Robert Schwentke",
                    Description = "Emerytowani agenci specjalni CIA zostają wrobieni w zamach. By się ratować, muszą reaktywować stary zespół.",
                    Price = 11,
                    CreatedAt = new DateTime(2020, 5, 4)
                },
                new Movie()
                {
                    Id = 6,
                    CategoryId = 2,
                    Title = "Tylko nie mów nikomu",
                    Director = "Tomasz Sekielski",
                    Description = "Dziennikarz śledczy rozmawia z dziewięcioma księżmi katolickimi, którzy dopuścili się zbrodni pedofilii i molestowania nieletnich, a także ich ofiarami.",
                    Price = 0,
                    CreatedAt = new DateTime(2021, 4, 4)
                },
                new Movie()
                {
                    Id = 7,
                    CategoryId = 5,
                    Title = "Iluzjonista",
                    Director = "Neil Burger",
                    Description = "Wiedeń u progu XX w. Syn rzemieślnika, iluzjonista Eisenheim, wykorzystuje niezwykłe umiejętności, by zdobyć miłość arystokratki, narzeczonej austro-węgierskiego księcia.",
                    Price = 13,
                    CreatedAt = new DateTime(2020, 5, 4)
                },
                new Movie()
                {
                    Id = 8,
                    CategoryId = 3,
                    Title = "Cube",
                    Director = "Vincenzo Natali",
                    Description = "Grupa osób budzi się w pełnym śmiertelnych pułapek sześcianie. Nieznajomi muszą zacząć współpracować ze sobą, by przeżyć.",
                    Price = 15,
                    CreatedAt = new DateTime(2021, 2, 1)
                },
                new Movie()
                {
                    Id = 9,
                    CategoryId = 1,
                    Title = "Hellraiser: Wysłannik Piekieł",
                    Director = "Clive Barker",
                    Description = "Frank Cotton nabywa tajemniczą kostkę, za pomocą której można przywołać demony z piekła.",
                    Price = 16,
                    CreatedAt = new DateTime(2020, 6, 21)
                },
                new Movie()
                {
                    Id = 10,
                    CategoryId = 3,
                    Title = "Milczenie Owiec",
                    Director = "Jonathan Demme",
                    Description = "Seryjny morderca i inteligentna agentka łączą siły, by znaleźć przestępcę obdzierającego ze skóry swoje ofiary.",
                    Price = 17,
                    CreatedAt = new DateTime(2020, 10, 10)
                }
                );
        }
    }
}
