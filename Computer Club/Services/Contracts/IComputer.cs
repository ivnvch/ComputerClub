using Computer_Club.Model.DataBaseModels;

namespace Computer_Club.Services.Contracts
{
    public interface IComputer
    {
        IEnumerable<Computer> GetComputers();
        Computer GetComputer(int id);
        void Create(Computer computer);
        void Update(int id, Computer computer);
        void Delete(int id);
    }
}
