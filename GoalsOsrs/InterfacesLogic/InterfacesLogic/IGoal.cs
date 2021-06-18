namespace Logic.Interfaces
{
    public interface IGoal
    {
        public int Id { get; }
<<<<<<< HEAD
        public int AccountId { get; }
        public string Title { get; }
        public string Item { get; }
        public string Description { get; }
        public string Status { get; }
        public string Kind { get; }

=======
        public string Title { get; }
        public string Item { get; }
        public int Level { get; }
        public int Killcount { get; }
        public string Description { get; }
        public string Kind { get; }
>>>>>>> main
        void UpdateGoal(IGoal goal);
    }
}