using BoardGameLibraryInClass.Models;
using Microsoft.EntityFrameworkCore;

namespace BoardGameLibraryInClass.Data
{
    public class GameContext : DbContext
    {
        public DbSet<BoardGameModel> BoardGames { get; set; }
        public DbSet<PublisherModel> Publishers { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Server=(localdb)\\mssqllocaldb;Database=BoardGameLibrary;Trusted_Connection=True;";
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PublisherModel>().HasData(
                new PublisherModel()
                {
                    Id = 1,
                    Name = "Days of Wonder"
                },
                new PublisherModel()
                {
                    Id = 2,
                    Name = "Stonemaier Games"
                },
                new PublisherModel()
                {
                    Id = 3,
                    Name = "Rio Grande"
                },
                new PublisherModel()
                {
                    Id = 4,
                    Name = "Richard Garfield"
                });

            modelBuilder.Entity<BoardGameModel>().HasData(
                new BoardGameModel()
                {
                    Id = 1,
                    Name = "SmallWorld",
                    Description = "Control one fantasy race after another to expand throught the land",
                    ImageURL = "https://cf.geekdo-images.com/aoPM07XzoceB-RydLh08zA__imagepage/img/lHmv0ddOrUvpiLcPeQbZdT5yCEA=/fit-in/900x600/filters:no_upscale():strip_icc()/pic428828.jpg",
                    PublisherId = 1
                },
                 new BoardGameModel()
                 {
                     Id = 2,
                     Name = "WingSpan",
                     Description = "Attract a beautiful and diverse collection of birds to your wildwife preserve",
                     ImageURL = "https://cf.geekdo-images.com/yLZJCVLlIx4c7eJEWUNJ7w__imagepagezoom/img/yS4vL6iTCvHSvGySxyOjV_-R3dI=/fit-in/1200x900/filters:no_upscale():strip_icc()/pic4458123.jpg",
                     PublisherId = 2
                 },
                  new BoardGameModel()
                  {
                      Id = 3,
                      Name = "Ticket to ride",
                      Description = "Ticket to Ride Board Game | Family Board Game | Board Game for Adults and Family",
                      ImageURL = "https://m.media-amazon.com/images/I/91YNJM4oyhL._AC_UL400_.jpg",
                      PublisherId = 1
                  },
                   new BoardGameModel()
                   {
                       Id = 4,
                       Name = "Dominion",
                       Description = "You are a monarch, like your parents before you, a ruler of a small pleasant kingdom of rivers and evergreens. Unlike your parents, however, you have hopes and dreams!",
                       ImageURL = "https://cf.geekdo-images.com/j6iQpZ4XkemZP07HNCODBA__imagepage/img/bbKggiASKA1E8sAh2cH07czaGn4=/fit-in/900x600/filters:no_upscale():strip_icc()/pic394356.jpg",
                       PublisherId = 3
                   },
                   new BoardGameModel()
                   {
                       Id = 5,
                       Name = "Magic the Gathering",
                       Description = "In the Magic game, you play the role of a planeswalker—a powerful wizard who fights other planeswalkers for glory, knowledge, and conquest. Your deck of cards represents all the weapons in your arsenal. It contains the spells you know and the creatures you can summon to fight for you.",
                       ImageURL = "https://cf.geekdo-images.com/CxJmNl4wR4InjqyNrMdBTw__imagepage/img/G185gILyaxGCYka6LwuEhd9--WA=/fit-in/900x600/filters:no_upscale():strip_icc()/pic163749.jpg",
                       PublisherId = 4
                   },
                   new BoardGameModel()
                   {
                       Id = 6,
                       Name = "Five Tribes",
                       Description = "Move assassins, elders & builders through Naqala to claim oases & control djinns.",
                       ImageURL = "https://cf.geekdo-images.com/dmo-WD6HZHVUPrbVHunaTw__imagepage/img/6Zrd6v5Z7gukQ-18akZ2hesGr_c=/fit-in/900x600/filters:no_upscale():strip_icc()/pic2055255.jpg",
                       PublisherId = 1
                   },
                   new BoardGameModel()
                   {
                       Id = 7,
                       Name ="King of Tokoyo",
                       Description = "t's a fight to the death when giant monsters battle over Tokyo in this dice-roller.",
                       ImageURL = "https://cf.geekdo-images.com/m_RzXpHURC0_xLkvRSR_sw__imagepage/img/oSNvtltDuWj3LP74IEFj8Ov2B0k=/fit-in/900x600/filters:no_upscale():strip_icc()/pic3043734.jpg",
                       PublisherId = 4
                   });

                
              
        }

    }
}
