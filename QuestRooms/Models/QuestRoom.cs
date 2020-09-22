using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace QuestRooms.Models
{   
    public class QuestRoom
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int Duration { get; set; }
        public int MinPlayersCount { get; set; }
        public int MaxPlayersCount { get; set; }
        public int MinAgeOfPlayers { get; set; }
        public string Adress { get; set; }
        public string[] PhoneNumbers { get; set; }
        public string Email { get; set; }
        public string Company { get; set; }
        public double Rating { get; set; }
        [Range(1, 5, ErrorMessage = "Unacceptable FearRating")]
        public int FearRating { get; set; }
        [Range(1, 5, ErrorMessage = "Unacceptable Difficulty")]
        public int Difficulty { get; set; }
        public byte[] Logo { get; set; }
        public byte[][] Galerry { get; set; }
    }
}