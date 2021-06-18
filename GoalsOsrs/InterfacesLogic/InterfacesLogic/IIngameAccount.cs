using System.Collections.Generic;

namespace Logic.Interfaces
{
    public interface IIngameAccount
    {
        public int Id { get; }
        public string Username { get; }
        public string Type { get; }
        public List<IStat> Stats { get; }

        void UpdateIngameAccount(IIngameAccount ingameAccount);
    }
}