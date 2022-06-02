using ExerciseWithManyToManyAtd.Database;
using ExerciseWithManyToManyAtd.Modells;
using Microsoft.EntityFrameworkCore;

namespace ExerciseWithManyToManyAtd.Services
{
    public class ServiceForEverything
    {
        private ApplicationDbContext Database;

        public ServiceForEverything(ApplicationDbContext database)
        {
            Database = database;
        }

        public ServiceForEverything()
        {

        }

        public void AddUser(string name,string surname,int clubId)
        {
            Database.Users.Add(new User(name, surname, clubId));
            Database.SaveChanges();
        }
        public void AddParty(string name)
        {
            Database.Parties.Add(new Party(name));
            Database.SaveChanges();
        }

        public List<User> GetListUsers()
        {
          return Database.Users.ToList();
        }

        public List<Party> GetListParties()
        {
            return Database.Parties.ToList();
        }

        public int Something(int number)
        {
            return number;
        }

        public List<Party> GetListOfUsersAndParties()
        {
            return Database.Users.Include(u=>u.PartyList).SelectMany(u=>u.PartyList).ToList();
        }
    }
}
