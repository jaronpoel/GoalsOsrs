namespace Logic.Interfaces
{
    public interface IIngameAccount
    {
        public int Id { get; }
        public string Username { get; }
        public string Type { get; }

        void UpdateIngameAccount(IIngameAccount ingameAccount);
    }
}