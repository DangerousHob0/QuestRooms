using System;
using Xunit;
using Moq;
using QuestRooms.Controllers;
using QuestRooms.Models;
using System.Collections.Generic;
using System.Linq;

namespace QuestRooms.Tests
{
    public class HomeControllerTests
    {
        [Fact]
        public void Can_Use_Repository()
        {
            // Arrange
            Mock<IRoomsRepository> mock = new Mock<IRoomsRepository> ();
            mock.Setup (m => m.Rooms).Returns (new QuestRoom[]
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
                }.AsQueryable<QuestRoom>());

            HomeController controller = new HomeController(mock.Object);

            // Act
            IEnumerable<QuestRoom> result =
                controller.Index().ViewData.Model as IEnumerable<QuestRoom>;
            // Assert
            QuestRoom[] roomArray = result.ToArray();
            Assert.True (roomArray.Length == 3);
            Assert.Equal ("Room1", roomArray[0].Title);
            Assert.Equal ("Room2", roomArray[1].Title);
            Assert.Equal ("Room3", roomArray[2].Title);
        }
    }
}
