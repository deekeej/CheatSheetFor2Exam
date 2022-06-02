using ExerciseWithManyToManyAtd.Modells;

namespace ExerciseWithManyToManyAtd.IndexViewModel
{
    public class ViewModel
    {
        public List<User> ListOfUsers { get; set; }
        public List<Party> ListOfParties { get; set; }
        public List<Party> PartiesWithUser { get; set; }
    }
}
