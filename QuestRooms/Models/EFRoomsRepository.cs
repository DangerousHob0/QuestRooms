using System.Linq;

namespace QuestRooms.Models 
{
    public class EFRoomsRepository : IRoomsRepository 
    {  
        private RoomsDbContext context;

        public EFRoomsRepository(RoomsDbContext ctx) 
        { 
            context = ctx;
        }
        public IQueryable<QuestRoom> Rooms => context.Rooms; 

        public void SaveRoom(QuestRoom r) 
        {
            context.SaveChanges();
        }
        public void CreateRoom(QuestRoom r)
        {
            context.Add(r);
            context.SaveChanges();
        }
        public void DeleteRoom(QuestRoom r)
        {
            context.Remove(r); 
            context.SaveChanges();
        }
    }
}