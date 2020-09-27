using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace QuestRooms.Models
{   
    public class QuestRoom
    {
        [Key]
        public long QuestId { get; set; }
        [Required(ErrorMessage = "Please enter a room title")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Please enter a room description")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Please enter Duration")]
        public int Duration { get; set; }
        [Required(ErrorMessage = "Please enter MinPlayersCount")]
        public int MinPlayersCount { get; set; }
        [Required(ErrorMessage = "Please enter MaxPlayersCount")]
        public int MaxPlayersCount { get; set; }
        [Required(ErrorMessage = "Please enter MinAgeOfPlayers")]
        public int MinAgeOfPlayers { get; set; }
        [Required(ErrorMessage = "Please enter Adress")]
        public string Adress { get; set; }
        [Required(ErrorMessage = "Please enter Phone numbers")]
        public string PhoneNumbers { get; set; }
        [Required(ErrorMessage = "Please enter E-mail")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter Company")]
        public string Company { get; set; }
        [Required(ErrorMessage = "Please enter rating")]
        public double Rating { get; set; }
        [Required(ErrorMessage = "Please enter FearRating")]
        [Range(1, 5, ErrorMessage = "Unacceptable FearRating")]
        public int FearRating { get; set; }
        [Required(ErrorMessage = "Please enter Difficulty")]
        [Range(1, 5, ErrorMessage = "Unacceptable Difficulty")]
        public int Difficulty { get; set; }
        [Required(ErrorMessage = "Please load path logo")]
        public string Logo { get; set; }
        [Required(ErrorMessage = "Please etner path to gallery folder")]
        public string Galerry { get; set; }
    }
}