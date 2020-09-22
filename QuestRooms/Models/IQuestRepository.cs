using System.Linq;

namespace QuestRooms.Models {
    public interface IRoomsRepository {
        IQueryable<QuestRoom> Rooms { get; }
    }
}