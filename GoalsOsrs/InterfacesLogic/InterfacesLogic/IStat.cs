namespace Logic.Interfaces
{
    public interface IStat
    {
        public int Id { get; }
        public int Value { get; }
        public string Title { get; }

        IStat GetStatByID(int id);
    }
}