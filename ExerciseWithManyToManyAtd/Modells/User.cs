namespace ExerciseWithManyToManyAtd.Modells
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int ClubId { get; set; }
        public List<Party> PartyList { get; set; }
        public User()
        {

        }

        public User( string name, string surname, int clubId)
        {
            Name = name;
            Surname = surname;
            ClubId = clubId;
        }
    }
}
