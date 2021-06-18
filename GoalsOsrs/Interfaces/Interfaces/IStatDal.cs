using Interfaces.DTO;

namespace Dal.Context
{
    public interface IStatDal
    {
        StatDTO GetStatByID(int id);
    }
}