using OrientationExamTryJava.Database;
using OrientationExamTryJava.Models;

namespace OrientationExamTryJava.Services
{
    public class AliasService
    {
        private ApplicationDbContext Database { get; set; }
        private Random random = new Random();
        public AliasService(ApplicationDbContext database)
        {
            Database = database;
        }

        public void Add(Aliaser aliaser)
        {
            Database.Aliasers.Add(aliaser);
            Database.SaveChanges();
        }

        public List<Aliaser> GetList()
		{
            return Database.Aliasers.ToList();
		}

        public string GenerateRandomNo()
        {
            return random.Next(0, 9999).ToString("D4");
        }

        public void FindAndChange(string alias)
		{
            Aliaser al=Database.Aliasers.FirstOrDefault(a=>a.Alias==alias);
            al.HitCount++;
            Database.SaveChanges();
		}

        public int DeleteAlias(int id,string uniqueCode)
        {
            if (!Database.Aliasers.Any(a => a.Id == id))
            {
                return 404;
            }
            else if (Database.Aliasers.Any(a=>a.Id==id && a.SecretCode!=uniqueCode))
            {
                return 403;
            }
            else
            {
                Database.Aliasers.Remove(Database.Aliasers.Find(id));
                Database.SaveChanges();
                return 204;
            }
        }

    }
}
