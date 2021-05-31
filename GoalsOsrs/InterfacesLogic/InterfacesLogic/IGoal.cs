namespace Logic.Interfaces
{
    public interface IGoal
    {
        public int Id { get; }
        public string Title { get; }
        public string Item { get; }
        public int Level { get; }
        public int Killcount { get; }
        public string Description { get; }
        public string Kind { get; }
        void UpdateGoal(IGoal goal);
    }
}