using System.Linq;
using QuestRooms.Models;

namespace QuestRooms.Models
{
    public class TemplateRoomsRepository : IRoomsRepository
    {
        public IQueryable<QuestRoom> Rooms
        {
            get
            {
                return new QuestRoom[]
                {
                    new QuestRoom
                    {
                        Title = "Room1",
                        Description = "Description1",
                        Duration = 10,
                        MinPlayersCount = 2,
                        MaxPlayersCount = 4,
                        MinAgeOfPlayers = 10,
                        Adress = "Adress1",
                        PhoneNumbers = new string[]{"123", "123"},
                        Email = "test1@test.com",
                        Company = "Company1",
                        Rating = 1,
                        FearRating = 1,
                        Difficulty = 1,
                        Logo = null,
                        Galerry = null
                    },
                    new QuestRoom
                    {
                        Title = "Room2",
                        Description = "Description2",
                        Duration = 20,
                        MinPlayersCount = 4,
                        MaxPlayersCount = 8,
                        MinAgeOfPlayers = 20,
                        Adress = "Adress2",
                        PhoneNumbers = new string[]{"222", "222"},
                        Email = "test2@test.com",
                        Company = "Company2",
                        Rating = 2,
                        FearRating = 2,
                        Difficulty = 2,
                        Logo = null,
                        Galerry = null
                    },
                    new QuestRoom
                    {
                        Title = "Room3",
                        Description = "Description3",
                        Duration = 30,
                        MinPlayersCount = 1,
                        MaxPlayersCount = 4,
                        MinAgeOfPlayers = 80,
                        Adress = "Adress3",
                        PhoneNumbers = new string[]{"333", "333"},
                        Email = "test3@test.com",
                        Company = "Company3",
                        Rating = 3,
                        FearRating = 3,
                        Difficulty = 3,
                        Logo = null,
                        Galerry = null
                    }
                }.AsQueryable();
            }
        }
    }
}