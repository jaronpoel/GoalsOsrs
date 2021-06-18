namespace Logic.Interfaces
{
    public interface IGoal
    {
        public int Id { get; }
        public int AccountId { get; }
        public string Title { get; }
        public string Item { get; }
        public string Description { get; }
        public string Status { get; }
        public string Kind { get; }

        void UpdateGoal(IGoal goal);
    }
}