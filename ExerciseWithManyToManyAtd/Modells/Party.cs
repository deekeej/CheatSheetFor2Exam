namespace ExerciseWithManyToManyAtd.Modells
{
    public class Party
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<User> UserList { get; set; }

        public Party(string name)
        {
            Name = name;
        }

        public Party()
        {

        }
    }
}
