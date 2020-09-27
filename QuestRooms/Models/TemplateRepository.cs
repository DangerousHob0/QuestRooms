using System.Linq;
using QuestRooms.Models;
using System.Collections.Generic;

namespace QuestRooms.Models
{
    public class TemplateRoomsRepository : IRoomsRepository
    {
        private static List<QuestRoom> rooms;

        public IQueryable<QuestRoom> Rooms
        {
            get
            {
                return rooms.AsQueryable();
            }
        }
        static TemplateRoomsRepository() {
            rooms = new List<QuestRoom>();
            rooms.AddRange(new QuestRoom[]
                {
                    new QuestRoom
                    {
                        QuestId = 1,
                        Title = "DaVinci’s Workshop",
                        Description = @"*Competing rooms available! See below for details* Leonardo Da Vinci was truly a man of many talents. Far ahead of his time, Da Vinci pondered geom …",
                        Duration = 30,
                        MinPlayersCount = 2,
                        MaxPlayersCount = 4,
                        MinAgeOfPlayers = 10,
                        Adress = "Adress1",
                        PhoneNumbers = "123,123",
                        Email = "test1@test.com",
                        Company = "Company1",
                        Rating = 32,
                        FearRating = 1,
                        Difficulty = 1,
                        Logo = @"/img/escape-room-st-charles-davinci.jpg",
                        Galerry = null
                    },
                    new QuestRoom
                    {
                        QuestId = 2,
                        Title = "Creepy Lair",
                        Description = "Your group has been taken hostage by a psycho serial killer. To make sure no one hears your screams, he has taken you back to his old, dingy house, …",
                        Duration = 40,
                        MinPlayersCount = 4,
                        MaxPlayersCount = 8,
                        MinAgeOfPlayers = 20,
                        Adress = "Adress2",
                        PhoneNumbers = "222, 222",
                        Email = "test2@test.com",
                        Company = "Company2",
                        Rating = 25,
                        FearRating = 2,
                        Difficulty = 3,
                        Logo = @"/img/stl-escape-creepy-lair.jpg",
                        Galerry = null
                    },
                    new QuestRoom
                    {
                        QuestId = 3,
                        Title = "Electric Chair",
                        Description = "Your friend has been framed for a crime he didn’t commit. Your crew must rescue him before he is executed by the electric chair! You must fir …",
                        Duration = 120,
                        MinPlayersCount = 2,
                        MaxPlayersCount = 6,
                        MinAgeOfPlayers = 80,
                        Adress = "Adress3",
                        PhoneNumbers = "333, 333",
                        Email = "test3@test.com",
                        Company = "Company3",
                        Rating = 65,
                        FearRating = 3,
                        Difficulty = 3,
                        Logo = @"/img/electrical.jpg",
                        Galerry = null
                    },
                    new QuestRoom
                    {
                        QuestId = 4,
                        Title = "Diamond Heist",
                        Description = "Think you’ve got what it takes to be the world’s greatest cat burglar? Was “Confessions of a Master Jewel Thief” really abo …",
                        Duration = 40,
                        MinPlayersCount = 1,
                        MaxPlayersCount = 4,
                        MinAgeOfPlayers = 80,
                        Adress = "Adress3",
                        PhoneNumbers = "333, 444",
                        Email = "test3@test.com",
                        Company = "Company3",
                        Rating = 55,
                        FearRating = 3,
                        Difficulty = 3,
                        Logo = @"/img/st-louis-escape-room-diamond-heist.jpg",
                        Galerry = null
                    },
                    new QuestRoom
                    {
                        QuestId = 5,
                        Title = "Secret Society",
                        Description = "**Competing rooms available. See below for info** While researching an ancient secret society, you discover that little did you know, they were res …",
                        Duration = 60,
                        MinPlayersCount = 4,
                        MaxPlayersCount = 6,
                        MinAgeOfPlayers = 80,
                        Adress = "Adress3",
                        PhoneNumbers = "333, 4545",
                        Email = "test3@test.com",
                        Company = "Company3",
                        Rating = 70,
                        FearRating = 3,
                        Difficulty = 3,
                        Logo = @"/img/secret-society-st-louis-escape-room.jpg",
                        Galerry = null
                    },
                    new QuestRoom
                    {
                        QuestId = 6,
                        Title = "The Castle",
                        Description = "Trouble is afoot in the kingdom! The Evil King has stolen the Good King’s crown. It is your mission to gain access to the castle, make a sleeping …",
                        Duration = 30,
                        MinPlayersCount = 1,
                        MaxPlayersCount = 4,
                        MinAgeOfPlayers = 80,
                        Adress = "Adress3",
                        PhoneNumbers = "333, 4545",
                        Email = "test3@test.com",
                        Company = "Company3",
                        Rating = 88,
                        FearRating = 3,
                        Difficulty = 3,
                        Logo = @"/img/escape-stl-castle-room.jpg",
                        Galerry = null
                    }
                });
        }
        public void SaveRoom(QuestRoom r) {
            //Rooms.Append(r);
        }
        public void CreateRoom(QuestRoom r) {
            rooms.Add(r);
        }
        public void DeleteRoom(QuestRoom r) {
            rooms.Remove(r);
        }
    }
}