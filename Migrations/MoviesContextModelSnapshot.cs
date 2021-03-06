// <auto-generated />
using System;
using IntroductionToAsp.NET_WypozyczalniaMovieow.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace IntroductionToAsp.NET_WypozyczalniaFilmow.Migrations
{
    [DbContext(typeof(MoviesContext))]
    partial class MoviesContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.14")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("IntroductionToAsp.NET_WypozyczalniaFilmow.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Straszne Moviey",
                            Name = "Horror"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Movie oparty na faktach",
                            Name = "Dokumentalny"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Dreszczowce",
                            Name = "Thriller"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Moviey z akcja",
                            Name = "Sensacyjne"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Elementy magiczne i nadprzyrodzone",
                            Name = "Fantasy"
                        });
                });

            modelBuilder.Entity("IntroductionToAsp.NET_WypozyczalniaFilmow.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("Director")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            CreatedAt = new DateTime(2020, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "20 sierpnia 1973 roku teksańska policja trafiła do stojącego na uboczu domu Thomasa Hewitta - byłego pracownika lokalnej rzeźni. Na miejscu odkryli rozkładające się zwłoki 33 osób, które zostały zamordowane przez psychopatycznego zabójcę noszącego na twarzy maskę z ludzkiej skóry i posługującego się piłą mechaniczną.",
                            Director = "Marcus Nispel",
                            Price = 10m,
                            Title = "Teksańska Masakra Piłą Mechaniczną"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 3,
                            CreatedAt = new DateTime(2021, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Mężczyzna dostaje obsesji na punkcie książki, która według niego opisuje i przewiduje jego życie i przyszłość.",
                            Director = "Joel Schumacher",
                            Price = 14m,
                            Title = "Numer 23"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 3,
                            CreatedAt = new DateTime(2020, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Uznany pisarz przenosi się na prowincję, by w spokoju tworzyć kolejne książki. Wkrótce odwiedzi go tajemniczy mężczyzna, który oskarży Raineya o plagiat.",
                            Director = "David Koepp",
                            Price = 12m,
                            Title = "Sekretne Okno"
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 5,
                            CreatedAt = new DateTime(2020, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Podróż hobbita z Shire i jego ośmiu towarzyszy, której celem jest zniszczenie potężnego pierścienia pożądanego przez Czarnego Władcę - Saurona.",
                            Director = "Peter Jackson",
                            Price = 20m,
                            Title = "Władca Pierścieni: Drużyna Pierścienia"
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 4,
                            CreatedAt = new DateTime(2020, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Emerytowani agenci specjalni CIA zostają wrobieni w zamach. By się ratować, muszą reaktywować stary zespół.",
                            Director = "Robert Schwentke",
                            Price = 11m,
                            Title = "Red"
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 2,
                            CreatedAt = new DateTime(2021, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Dziennikarz śledczy rozmawia z dziewięcioma księżmi katolickimi, którzy dopuścili się zbrodni pedofilii i molestowania nieletnich, a także ich ofiarami.",
                            Director = "Tomasz Sekielski",
                            Price = 0m,
                            Title = "Tylko nie mów nikomu"
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 5,
                            CreatedAt = new DateTime(2020, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Wiedeń u progu XX w. Syn rzemieślnika, iluzjonista Eisenheim, wykorzystuje niezwykłe umiejętności, by zdobyć miłość arystokratki, narzeczonej austro-węgierskiego księcia.",
                            Director = "Neil Burger",
                            Price = 13m,
                            Title = "Iluzjonista"
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 3,
                            CreatedAt = new DateTime(2021, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Grupa osób budzi się w pełnym śmiertelnych pułapek sześcianie. Nieznajomi muszą zacząć współpracować ze sobą, by przeżyć.",
                            Director = "Vincenzo Natali",
                            Price = 15m,
                            Title = "Cube"
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 1,
                            CreatedAt = new DateTime(2020, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Frank Cotton nabywa tajemniczą kostkę, za pomocą której można przywołać demony z piekła.",
                            Director = "Clive Barker",
                            Price = 16m,
                            Title = "Hellraiser: Wysłannik Piekieł"
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 3,
                            CreatedAt = new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Seryjny morderca i inteligentna agentka łączą siły, by znaleźć przestępcę obdzierającego ze skóry swoje ofiary.",
                            Director = "Jonathan Demme",
                            Price = 17m,
                            Title = "Milczenie Owiec"
                        });
                });

            modelBuilder.Entity("IntroductionToAsp.NET_WypozyczalniaFilmow.Models.Movie", b =>
                {
                    b.HasOne("IntroductionToAsp.NET_WypozyczalniaFilmow.Models.Category", "Category")
                        .WithMany("Movies")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("IntroductionToAsp.NET_WypozyczalniaFilmow.Models.Category", b =>
                {
                    b.Navigation("Movies");
                });
#pragma warning restore 612, 618
        }
    }
}
