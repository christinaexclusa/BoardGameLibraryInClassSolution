﻿// <auto-generated />
using BoardGameLibraryInClass.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BoardGameLibraryInClass.Migrations
{
    [DbContext(typeof(GameContext))]
    [Migration("20230726161134_2")]
    partial class _2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BoardGameLibraryInClass.Models.BoardGameModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PublisherId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PublisherId");

                    b.ToTable("BoardGames");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Control one fantasy race after another to expand throught the land",
                            ImageURL = "https://cf.geekdo-images.com/aoPM07XzoceB-RydLh08zA__imagepage/img/lHmv0ddOrUvpiLcPeQbZdT5yCEA=/fit-in/900x600/filters:no_upscale():strip_icc()/pic428828.jpg",
                            Name = "SmallWorld",
                            PublisherId = 1
                        },
                        new
                        {
                            Id = 2,
                            Description = "Attract a beautiful and diverse collection of birds to your wildwife preserve",
                            ImageURL = "https://cf.geekdo-images.com/yLZJCVLlIx4c7eJEWUNJ7w__imagepagezoom/img/yS4vL6iTCvHSvGySxyOjV_-R3dI=/fit-in/1200x900/filters:no_upscale():strip_icc()/pic4458123.jpg",
                            Name = "WingSpan",
                            PublisherId = 2
                        },
                        new
                        {
                            Id = 3,
                            Description = "Ticket to Ride Board Game | Family Board Game | Board Game for Adults and Family",
                            ImageURL = "https://m.media-amazon.com/images/I/91YNJM4oyhL._AC_UL400_.jpg",
                            Name = "Ticket to ride",
                            PublisherId = 1
                        },
                        new
                        {
                            Id = 4,
                            Description = "You are a monarch, like your parents before you, a ruler of a small pleasant kingdom of rivers and evergreens. Unlike your parents, however, you have hopes and dreams!",
                            ImageURL = "https://cf.geekdo-images.com/j6iQpZ4XkemZP07HNCODBA__imagepage/img/bbKggiASKA1E8sAh2cH07czaGn4=/fit-in/900x600/filters:no_upscale():strip_icc()/pic394356.jpg",
                            Name = "Dominion",
                            PublisherId = 3
                        },
                        new
                        {
                            Id = 5,
                            Description = "In the Magic game, you play the role of a planeswalker—a powerful wizard who fights other planeswalkers for glory, knowledge, and conquest. Your deck of cards represents all the weapons in your arsenal. It contains the spells you know and the creatures you can summon to fight for you.",
                            ImageURL = "https://cf.geekdo-images.com/CxJmNl4wR4InjqyNrMdBTw__imagepage/img/G185gILyaxGCYka6LwuEhd9--WA=/fit-in/900x600/filters:no_upscale():strip_icc()/pic163749.jpg",
                            Name = "Magic the Gathering",
                            PublisherId = 4
                        },
                        new
                        {
                            Id = 6,
                            Description = "Move assassins, elders & builders through Naqala to claim oases & control djinns.",
                            ImageURL = "https://cf.geekdo-images.com/dmo-WD6HZHVUPrbVHunaTw__imagepage/img/6Zrd6v5Z7gukQ-18akZ2hesGr_c=/fit-in/900x600/filters:no_upscale():strip_icc()/pic2055255.jpg",
                            Name = "Five Tribes",
                            PublisherId = 1
                        },
                        new
                        {
                            Id = 7,
                            Description = "t's a fight to the death when giant monsters battle over Tokyo in this dice-roller.",
                            ImageURL = "https://cf.geekdo-images.com/m_RzXpHURC0_xLkvRSR_sw__imagepage/img/oSNvtltDuWj3LP74IEFj8Ov2B0k=/fit-in/900x600/filters:no_upscale():strip_icc()/pic3043734.jpg",
                            Name = "King of Tokoyo",
                            PublisherId = 4
                        });
                });

            modelBuilder.Entity("BoardGameLibraryInClass.Models.PublisherModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Publishers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Days of Wonder"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Stonemaier Games"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Rio Grande"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Richard Garfield"
                        });
                });

            modelBuilder.Entity("BoardGameLibraryInClass.Models.BoardGameModel", b =>
                {
                    b.HasOne("BoardGameLibraryInClass.Models.PublisherModel", "Publisher")
                        .WithMany("BoardGames")
                        .HasForeignKey("PublisherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Publisher");
                });

            modelBuilder.Entity("BoardGameLibraryInClass.Models.PublisherModel", b =>
                {
                    b.Navigation("BoardGames");
                });
#pragma warning restore 612, 618
        }
    }
}
