using System.Linq;

namespace QuestRooms.Models {
    public interface IRoomsRepository {
        IQueryable<QuestRoom> Rooms { get; }

        void SaveRoom(QuestRoom r);
        void CreateRoom(QuestRoom r);
        void DeleteRoom(QuestRoom r);
    }
}