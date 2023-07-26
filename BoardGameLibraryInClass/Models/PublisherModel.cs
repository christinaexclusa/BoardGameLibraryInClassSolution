using System.ComponentModel.DataAnnotations;

namespace BoardGameLibraryInClass.Models
{
    public class PublisherModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        //holds all the board games associated with this publishers Id property
        public virtual IEnumerable<BoardGameModel>? BoardGames { get; set; }
    }
}
